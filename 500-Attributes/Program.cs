/**
 * Attributes
 */
// Attributes are used to tag entities with extra info / features to any entities in C#.

// This line gives compilation warnings because the `OldResult` static method is marked as obsolete
Utils.OldResult();

// Once an attribute is added to an entity, we can inquire it using REFLECTION;
var newFunctionalityObj = new MyNewClass();
// Get the `Type` object of `newFunctionalityObj` using `GetType` first.
// - A `Type` object is an object representation of a type
// - Every object has `GetType` since they all inherit from System.Object
// - To access the type of a METHOD, use `GetMethod()`, e.g. `Utils.GetMethod("NewResult")`
var typeOfMyObj = newFunctionalityObj.GetType(); 
Console.WriteLine($"typeOfMyObj has Type {typeOfMyObj}"); // typeOfMyObj has Type MyNewClass
// Then we get the attributes from the Type.
// - `GetCustomAttributes` will return an array of all attributes associated to this Type.
//   - If we do not specify an attribute to filter, then it will return all attributes associated to it.
// - What happens under the hood: when calling `GetCustomAttributes`, it creates an Attribute object from the Attribute class and returns it in the array
// - Instead of `GetType` for an objectm, we have `typeof()` for getting the Type object directly from a type.
// - `inherit: false` means we don't want to look into the base classes of this class
// - Have to use `System.Reflection` namespace to use GetCustomAttributes
var customAttrs = (NewFunctionalityAttribute[])typeOfMyObj.GetCustomAttributes(typeof(NewFunctionalityAttribute), inherit: false); 
Console.WriteLine($"Found {customAttrs.Length} NewFunctionalityAttribute in typeOfMyObj:"); // Found 1 NewFunctionalityAttribute in typeOfMyObj
// Then you can access the members of the attribute object:
Console.WriteLine($"1. Version {customAttrs[0].Version}"); // 1. Version 1.0.0

class Utils
{
    // `ObsoleteAttribute` is `a .NET built-in attribute
    // When using an attribute, you can omit the `-Attribute` and the compiler will understand
    // ObsoleteAttribute has a CONSTRUCTOR which accepts an optional `string` message 
    [Obsolete("This is deprecated, don't use!")]
    public static string OldResult()
    {
        return "old";
    }
    public static string NewResult()
    {
        return "new";
    }
}

// If you attribute has settable fields / properties, you can also set them immediately after instantiation like the object initialiser syntax { Version = "xxx" }
// However, you do it inside the () parenthesis instead, and always AFTER the parameters of the constructor (if present)
[NewFunctionality(Version = "1.0.0")]
class MyNewClass {}


// You can also define your own attribute class
// The class must inherit from `System.Attribute`
class NewFunctionalityAttribute: Attribute
{
        public string Version { get; set; } = "0.0.0";
}
