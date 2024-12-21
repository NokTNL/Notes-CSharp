namespace Utils {
    internal class NumberUtils {
        /*
        * Methods
        */
        // Methods are the basic form of "functions" you will see in C#. They need to be defined in a class
        // They follow this common structure:
        // <modifier> <return-type> FunctionName (<paramters>) { /* .... */ }
        // So for example:
        public static int AddTwoInt(int a, int b) { // `public` so it is acessible by other classes; `static` because it does not belong to an instance
            return a + b;
        }

        /* 
        * Expression-bodied Members
        */
        // C# also supports a method defined like an "arrow function". 
        public static int AddTwoIntShort(int a, int b) => a + b;
    }

    internal class ConsoleUtils {
        /*
         * Method overloading
         */
        // C# allows you to have multiple methods in a class bearing the exact same name; the only criteria is that they have a different parameter list
        // It will decide which one is the correct one based on the list of parameters used at the point of call
        public static void SayHi() {
            // You can even call an overload INSIDE another overload
            SayHi("Mom");
        }
        public static void SayHi(string name) {
            Console.WriteLine($"Hi {name}!");
        }
        /*
         * Optional parameters
         */
        // Alternatively, you can define a function with optional parameters to avoid overloading
        public static void SmartSayHi(string name = "Barbie") {
            Console.WriteLine($"Hi {name}!");
        }
    }
}

// If you only have one namespace in a file, you can use FILE-SCOPED NAMESPACE, and simply put all the class declarations under it (instead of inside brackets).
// It makes it way more readable, but you cannot have more than one namespaces if you use this.

// namesapce Foo;
//
// class Bar
// {
//      public static void Baz () {}
// }
//
// namespace Extra; <--- NOT ALLOWED