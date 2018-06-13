import { AwsAccountId, Construct, FnConcat, Output, Token } from 'aws-cdk';
import { glue } from 'aws-cdk-resources';
import * as s3 from 'aws-cdk-s3';

/**
 * A reference to a database. The easiest way to instantiate is to call
 * `stream.export()`. Then, the consumer can use `Stream.import(this, ref)` and
 * get a `Stream`.
 */
export interface DatabaseRefProps {
    /**
     * The DatabaseIn of the stream.
     */
    databaseInputName: DatabaseInputName;
}

export class DatabaseInputName extends Token {
}

/**
 * Represents a Glue Database.
 *
 * Databases can be either defined within this stack:
 *
 *     new Database(this, 'MyDatabase', { props });
 *
 * Or imported from an existing database:
 *
 *     DatabaseRef.import(this, 'MyImportedDatabase', { databaseId: ... });
 *
 * You can also export a database and import it into another stack:
 *
 *     const ref = myDatabase.export();
 *     DatabaseRef.import(this, 'MyImportedStream', ref);
 *
 */
export abstract class DatabaseRef extends Construct {
    /**
     * Creates a Database construct that represents an external database.
     *
     * @param parent The parent creating construct (usually `this`).
     * @param name The construct's name.
     * @param ref A DatabaseRefProps object. Can be obtained from a call to
     * `database.export()`.
     */
    public static import(parent: Construct, name: string, props: DatabaseRefProps): DatabaseRef {
        return new ImportedDatabaseRef(parent, name, props);
    }

    /**
     * The DatabaseInput name of the stream.
     */
    public abstract readonly databaseInputName: DatabaseInputName;

    /**
     * Exports this stream from the stack.
     */
    public export(): DatabaseRefProps {
        return {
            databaseInputName: new Output(this, 'DatabaseInputName', { value: this.databaseInputName }).makeImportValue()
        };
    }
}

export interface DatabaseProps {
    name?: string;

    locationUri?: string | Token;

    s3Location?: S3Location;

    description?: string;

    parameters?: object;
}

export interface S3Location {
    bucket?: s3.BucketRef;

    prefix?: S3LocationPrefix;
}

type S3LocationPrefix = Token | string;

/**
 * A Kinesis stream. Can be encrypted with a KMS key.
 */
export class Database extends DatabaseRef {
    public readonly databaseInputName: DatabaseInputName;

    private readonly database: glue.DatabaseResource;

    constructor(parent: Construct, name: string, props: DatabaseProps = {}) {
        super(parent, name);

        this.database = new glue.DatabaseResource(this, "Database", {
            catalogId: new AwsAccountId(),
            databaseInput: {
                description: props.description,
                locationUri: this.buildLocationUri(props),
                name: props.name,
                parameters: props.parameters
            }
        });
        this.databaseInputName = this.database.ref;

        if (props.name) {
            this.addMetadata('aws:cdk:hasPhysicalName', props.name);
        }
    }

    private buildLocationUri(props: DatabaseProps) {
        if (props.locationUri) {
            return props.locationUri;
        } else if (props.s3Location && props.s3Location.bucket && props.s3Location.prefix) {
            const bucket = props.s3Location.bucket;
            const prefix = props.s3Location.prefix;
            return new FnConcat("s3://", bucket, prefix);
        } else {
            return undefined;
        }
    }
}

class ImportedDatabaseRef extends DatabaseRef {
    public readonly databaseInputName: DatabaseInputName;

    constructor(parent: Construct, name: string, props: DatabaseRefProps) {
        super(parent, name);

        this.databaseInputName = props.databaseInputName;
    }
}
