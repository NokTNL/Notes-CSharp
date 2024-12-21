// In C#, primitves (int, double, char, ...) are VALUE types. They are stored as the values as-is in the stack, and the values are copied every time they are passed around.
// Classes and Strings are REFERENCE types. They are stored as a pointer in the stack, which points to the actual object stored in the heap, and only the reference are copied and passed around during assignment.
// - Even though strings are stored as references, it behaves like a de facto value type.
//   This is because when a new string value is assigned to a variable, the reference stored assigned in the variable changes (instead of mutating the value the reference is pointing to, because strings are immutable).

// When used as parameters, primitives are by values by default, i.e. copied of the original values are passed in.
// You can force it to be passed BY REFERENCE so you can mutate the original value, using the `ref` keyword
// Note: using `ref` assumes that the variable is already initialised so you can use the variable in the method straight away

static void WrongAddOneToNumber (int num){
    ++num;
}
static void AddOneToNumber(ref int num){
    ++num;
}

var initialNum = 2;
WrongAddOneToNumber(initialNum);
Console.WriteLine($"intialNum: {initialNum}"); // 2

AddOneToNumber(ref initialNum);
Console.WriteLine($"intialNum: {initialNum}"); // 3

// Similar to `ref` is `out`, but is designed to be assigned as an output in the method, so the `out` argument does not need to be initisliased
static void AddTwoNum(int a, int b, out int sum) {
    sum = a + b;
}
AddTwoNum(1, 2, out int sum); // `out` variable declartion can be INLINED
Console.WriteLine($"1 + 2 = {sum}");