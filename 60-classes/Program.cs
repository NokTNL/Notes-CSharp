using _60_classes.HR;

// To use members inside a namespace, you have tow choices:
// 1. `using` a namespace + just the class name:
var myEmployee = new Employee("Adam", "Smith");
// If there are ambiguous cases (i.e. two namespaces have members with the same name), you can:
// 2. Use aliases:
//   - using HR = _60_classes.HR;
//     new HR.Employee();
//   OR:
//   - using HREMployee = _60_classes.HR.Employee;
//     new  HREMployee();
// 3. Use the fully qualified name at where you are using it (no need `using` in this case):
//   `_60_classes.HR.Employee`
Console.WriteLine(myEmployee.GetFullName());