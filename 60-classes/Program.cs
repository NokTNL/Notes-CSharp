using _60_classes.HR;

/**
 * `using` namespaces
 */
// To use members inside a namespace, just `using` a namespace + just the class name:
Employee myEmployee = new("Adam", "Smith");
// If there are ambiguous cases (i.e. two namespaces have members with the same name), you can:
// 1. Use aliases:
//   - using HR = _60_classes.HR;
//     new HR.Employee();
//   OR:
//   - using HREMployee = _60_classes.HR.Employee;
//     new HREMployee();
// 2. Use the fully qualified name at where you are using it (no need `using` in this case):
//   `_60_classes.HR.Employee`

/*
 * Object initialisers
 */
 // If your class has fields / properties with write access in the current context (e.g. public fields, or properties with a public set / init), ...
 // ... you can assign to them striaght away using object initialisers {}.
 // Simply put it right after the contructor call
Employee mySecondEmployeeAgain = new()
{
    FirstName = "John",
    LastName = "Doe"
};
// instead of
Employee myThirdEmployee = new();
myThirdEmployee.FirstName = "John";
myThirdEmployee.LastName = "Doe";