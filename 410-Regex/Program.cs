// You can then use the Regex class to match strings
using System.Text.RegularExpressions;

// Regex patterns are just String's in C#
// - People typically use verbatim strings because we often time wants to match special characters that have meanings in Regex (. $ ^ { [ ( | ) * + ? \) and any chracter classes (e.g. \w, \d, \s)
// - So that you can match e.g. a "|" character with @"\|" instead of "\\|"
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

/*
 * Groups
 */
// Like usual regex, you can use `()` to match a subexpression as a whole and/or provide alternations with "|"
var matches = Regex.Matches("I ate one banana and two apples", @"(apple|banana|pear|orange)s?");
Console.WriteLine("Found these fruit names:");
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}
// Groups are CAPTURING by default, i.e. you can access the matched groups within the regex, using BACKREFERENCES (`\1, \2` ... `\9`)
// This is most useful when e.g. making use of duplicates
var duplicateMatches = Regex.Matches("I do this this. That as as well.", @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase); // Find a word, find a space and then find the word again; this finds continuous duplicates sitting
Console.WriteLine("Found these duplicates:");
foreach (Match match in duplicateMatches)
{
    Console.WriteLine($"{match.Value} - {match.Groups[1].Value}"); // this this - this; as as - as; Remember capture groups starts from 1; 0 is the whole match instead of groups
}
// You can also switch off the capturing, or name the group and then backreference it with `\k<name>`
