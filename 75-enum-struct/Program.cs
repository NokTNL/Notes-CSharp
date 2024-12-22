using Utils;

static string GenErrorMsg(ErrorCode code)
{
    return code switch
    {
        ErrorCode.TypeError => "Oops the value has the wrong type",
        ErrorCode.ValueError => "Oops the value is invalid",
        ErrorCode.ReferenceError => "Ooops no such value defined",
        _ => "" // We need to provide default case even when we restrict the cases with an enum. 
                // This is because user can cast any `int` as our Enum (which is just `int` under the hood) and will result in a RUNTIME error when there's no match
    };
}

// Console.WriteLine(GenErrorMsg(1)); <--- not allowed unless you explictly cast it
Console.WriteLine(GenErrorMsg(ErrorCode.TypeError));

var coords = new Coords(1.5, -2.5);
Console.WriteLine($"Coordinates: {coords.x}, {coords.y}");