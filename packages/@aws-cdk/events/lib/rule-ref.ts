import { Construct, Output } from '@aws-cdk/core';
import { events } from '@aws-cdk/resources';

export interface EventRuleRefProps {
    /**
     * The value of the event rule Amazon Resource Name (ARN), such as
     * arn:aws:events:us-east-2:123456789012:rule/example.
     */
    eventRuleArn: events.RuleArn;
}

export abstract class EventRuleRef extends Construct {

    /**
     * Imports a rule by ARN into this stack.
     */
    public static import(parent: Construct, name: string, props: EventRuleRefProps): EventRuleRef {
        return new ImportedEventRule(parent, name, props);
    }

    /**
     * The value of the event rule Amazon Resource Name (ARN), such as
     * arn:aws:events:us-east-2:123456789012:rule/example.
     */
    public abstract readonly ruleArn: events.RuleArn;

    /**
     * Exports this rule resource from this stack and returns an import token.
     */
    public export(): EventRuleRefProps {
        return {
            eventRuleArn: new Output(this, 'RuleArn', { value: this.ruleArn }).makeImportValue()
        };
    }
}

class ImportedEventRule extends EventRuleRef {
    public readonly ruleArn: events.RuleArn;

    constructor(parent: Construct, name: string, props: EventRuleRefProps) {
        super(parent, name);

        this.ruleArn = props.eventRuleArn;
    }
}
