// Regex patterns are just String's in C#
// You can then use the Regex class to match strings
using System.Text.RegularExpressions;

string startsWithA = "^A";
string testString = "An apple a day keeps the doctors away.";
bool isStartingWithA = Regex.IsMatch(testString, startsWithA);
if (isStartingWithA)
{
    Console.WriteLine($"'{testString}' starts with an A!");
}
else
{
    Console.WriteLine($"'{testString}' does not start with an A.");
}
