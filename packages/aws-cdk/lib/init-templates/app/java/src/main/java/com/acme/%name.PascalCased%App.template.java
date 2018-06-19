package com.acme;

import com.amazonaws.cdk.App;

import java.util.Arrays;

public final class %name.PascalCased%App {
    public static void main(final String[] args) {
        final App app = new App(Arrays.asList(args));
        final %name.PascalCased%Stack stack = new %name.PascalCased%Stack(app, "%name.PascalCased%Stack");
        System.out.println(app.exec());
    }
}
