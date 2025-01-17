// When you want to convert values in a class into a string so that it can be sent / saved as data, it is called "Serialization".
// e.g. using JsonSerializer.Serialize
// - !!! It only converts PUBLIC PROPERTIES by default

using System.Text.Json;
using _400_JSON;

MyObject myObj = new()
{
    Name = "Nok",
    Age = 30
};

string myObjString = JsonSerializer.Serialize(myObj);
Console.WriteLine(myObjString); // {"Name":"Nok","Age":30}

// The opposite is deserialization, which is parsing a string back to a class
// You need to provide a class for it to generate into
// - Note that deserialisation is case-sensitive
// - If a certain property has no match, it will be IGNORED (it simply falls back to the default value as defined in the class)
// - You can make a property REQUIRED in deserialization by adding the `required` modifier to the property. If there's no match, it will throw
string myJsonObjString = @"
    {
     ""Name"": ""Jason""
    }
"; // Ignoring `Age` is fine because it is not `required`
MyObject myJsonObj = JsonSerializer.Deserialize<MyObject>(myJsonObjString);
myJsonObj.SayName(); // My name is Jason!