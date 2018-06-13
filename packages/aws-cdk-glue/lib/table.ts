import { AwsAccountId, Construct, FnConcat, Output, Token } from 'aws-cdk';
import { glue } from 'aws-cdk-resources';
import * as s3 from 'aws-cdk-s3';
import {DatabaseRef } from './';

export abstract class TableRef extends Construct {
    public abstract readonly database: DatabaseRef;
}

export interface TableProps {
    database: DatabaseRef;

    bucket?: s3.BucketRef;
    prefix?: string | Token;

    name: string | Token;
    columns: Column[];
    partitionKeys?: PartitionKey[]

    inputFormat?: string | CommonInputFormats
    outputFormat?: string | CommonOutputFormats;
    compressed?: boolean;
}

export enum CommonInputFormats {
    PARQUET = "org.apache.hadoop.hive.ql.io.parquet.MapredParquetInputFormat"
}

export enum CommonOutputFormats {
    PARQUET = "org.apache.hadoop.hive.ql.io.parquet.MapredParquetOutputFormat"
}

export class Table extends TableRef {
    public readonly columns: Column[];
    public readonly partitionKeys: Column[];

    public readonly database: DatabaseRef;
    private readonly bucket: s3.BucketRef;
    private readonly prefix: string | Token;
    private readonly table: glue.TableResource;

    constructor(parent: Construct, name: string, props: TableProps) {
        super(parent, name);

        this.columns = props.columns;
        this.partitionKeys = props.partitionKeys || [];

        this.database = props.database;
        this.bucket = props.bucket || new s3.Bucket(this, "Bucket");
        this.prefix = props.prefix || '';

        this.table = new glue.TableResource(this, "Table", {
            catalogId: new AwsAccountId(),
            databaseName: props.database.databaseInputName,
            tableInput: {
                storageDescriptor: {
                    columns: this.buildColumnProperties(this.partitionKeys),
                    partitionKeys: this.buildPartitionKeys(this.partitionKeys),
                    inputFormat: props.inputFormat,
                    outputFormat: props.outputFormat,
                    compressed: props.compressed
                }
            }
        });
    }

    private buildPartitionKeys(partitionKeys: PartitionKey[]): glue.TableResource.ColumnProperty[] {
        return this.buildColumnProperties(partitionKeys);
    }

    private buildColumnProperties(columns: Column[]): glue.TableResource.ColumnProperty[] {
        return columns.map(column => ({
            comment: column.comment,
            name: column.name,
            type: this.buildColumnType(column)
        }));
    }

    private buildColumnType(column: Column) {
        if (typeof(column.type) === 'string') {
            return column.type;
        } else {
            return column.type.toTypeString();
        }
    }
}

export class TableName extends Token {
}

export interface Column {
    name: string | Token;

    type: string | ColumnType;

    comment?: string | Token;
}

export interface PartitionKey {
    name: string | Token;

    type: string | PrimitiveType; // TODO: confirm we are restricted to primitives only.

    comment?: string | Token;
}

/**
 * Base of column type family.
 * @see https://docs.aws.amazon.com/athena/latest/ug/data-types.html
 */
export interface ColumnType {
    toTypeString(): string;
}

/**
 * Base class of all glue primtiive types
 */
export abstract class PrimitiveType implements ColumnType {
    public abstract toTypeString();
}

export class BooleanType extends PrimitiveType {
    public toTypeString(): string { return 'boolean'; }
}

export class DoubleType extends PrimitiveType {
    public toTypeString(): string { return 'double'; }
}

export class FloatType extends PrimitiveType {
    public toTypeString(): string { return 'float'; }
}

export class IntType extends PrimitiveType {
    public toTypeString(): string { return 'int'; }
}

export class SmallIntType extends PrimitiveType {
    public toTypeString(): string { return 'smallint'; }
}

export class StringType extends PrimitiveType {
    public toTypeString(): string { return 'string'; }
}

export class TimestampType extends PrimitiveType {
    public toTypeString(): string { return 'timestamp'; }
}

export class TinyIntType extends PrimitiveType {
    public toTypeString(): string { return 'tinyint'; }
}

export class CharType extends PrimitiveType {
    private readonly size: number;

    constructor(size: number) {
        super();
        this.size = size;
    }

    public toTypeString() {
        return `char(${this.size})`;
    }
}

export class VarcharType extends PrimitiveType {
    private readonly size: number;

    constructor(size: number) {
        super();
        this.size = size;
    }

    public toTypeString() {
        return `varchar(${this.size})`;
    }
}

export interface DecimalTypeProps {
    precision?: number;
    scale?: number;
}

export class DecimalType extends PrimitiveType {
    private readonly precision: number;
    private readonly scale: number;

    constructor(props: DecimalTypeProps) {
        super();
        this.precision = props.precision || 36;
        this.scale = props.scale || 2;
    }

    public toTypeString() {
        return `decimal(${this.precision},${this.scale})`;
    }
}

export class ArrayDataType implements ColumnType {
    private readonly elementDataType: ColumnType;

    constructor(elementDataType: ColumnType) {
        this.elementDataType = elementDataType;
    }

    public toTypeString(): string {
        return `array<${this.elementDataType.toTypeString()}>`;
    }
}

export class MapDataType implements ColumnType {
    private readonly keyDataType: ColumnType;
    private readonly valueDataType: ColumnType;

    constructor(keyDataType: PrimitiveType, valueDataType: ColumnType) {
        this.keyDataType = keyDataType;
        this.valueDataType = valueDataType;
    }

    public toTypeString(): string {
        return `map<${this.keyDataType.toTypeString()}, ${this.valueDataType.toTypeString()}>`;
    }
}

export class StructType implements ColumnType {
    public readonly columns: StructTypeColumn[];

    constructor(columns: StructTypeColumn[]) {
        this.columns = columns;
    }

    public toTypeString(): string {
        let typeString = "struct<";
        for (let i = 0; i < this.columns.length; i++) {
            const col = this.columns[i];
            typeString += `${col.name}:${col.type.toTypeString()}`;
            if (col.comment) {
                typeString += ` [COMMENT ${col.comment}]`;
            }
            if (i + 1 < this.columns.length) {
                typeString += ',';
            }
        }
        return typeString + '>';
    }
}

export interface StructTypeColumn {
    comment?: string | Token;
    name: string | Token;
    type: ColumnType;
}
