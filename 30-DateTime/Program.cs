// A DateTime needs to be INSTANTIATED in C# with a constructor, with arguments for year, month, day, hour, minutes ....
// This constructor has overloads so you can omit some arugments
DateTime someDate = new(2022, 2, 1); // DateTime constructor overloads typically start with YEAR, and then go down to smaller units
Console.WriteLine($"someDate                    : {someDate}"); // 2/1/2022 12:00:00 AM
Console.WriteLine($"someDate, but longDateString: {someDate.ToLongDateString()}"); // Tuesday, February 1, 2022
// Get the CURRENT DateTime by using the static DateTime.Now method
DateTime timeNow = DateTime.Now;
Console.WriteLine($"Time now is                 : {timeNow}");
// DateTime has loads of built-in members for you to use and manipulate the dates
Console.WriteLine($"someDate's day of week      : {someDate.DayOfWeek}"); // Tuesday
DateTime someDayPlus15Days = someDate.AddDays(15); // !!! Note that a NEW DateTime is returned instead of mutating the original DateTime
Console.WriteLine($"someDatePlus15Days          : {someDayPlus15Days}"); // 2/16/2022 12:00:00 AM

// C# also have TimeSpan which represents a time interval
TimeSpan aFewHours = new(2, 30, 30); // TimeSpan constructor, if called with 3 arguments, starts from HOURS
Console.WriteLine(aFewHours); // 02:30:30
// There is a DateTime.Add(TimeSpan) method that you can conviniently add a TimeSpan to a date
DateTime someDateAddedTimeSpan = someDate.Add(aFewHours);
Console.WriteLine($"someDateAddedTimeSpan       : {someDateAddedTimeSpan}"); // 2/1/2022 2:30:30 AM
