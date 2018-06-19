package com.acme;

import com.amazonaws.cdk.App;
import com.amazonaws.cdk.Stack;
import com.amazonaws.cdk.StackProps;
import com.amazonaws.cdk.sqs.Queue;
import com.amazonaws.cdk.sqs.QueueProps;
import com.amazonaws.cdk.sns.Topic;

final class %name.PascalCased%Stack extends Stack {
    public %name.PascalCased%Stack(final App parent, final String name) {
        this(parent, name, StackProps.builder().build());
    }

    public %name.PascalCased%Stack(final App parent, final String name, final StackProps props) {
        super(parent, name, props);

        final Queue queue = new Queue(this, "%name.PascalCased%Queue", QueueProps.builder().withVisibilityTimeoutSec(300).build());
        final Topic topic = new Topic(this, "%name.PascalCased%Topic");

        topic.subscribeQueue(queue);
    }
}
