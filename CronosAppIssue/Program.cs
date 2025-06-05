// See https://aka.ms/new-console-template for more information

using System.Globalization;
using CronosAppIssue.Cronos;

const string TIME = "30 2 * * *";

var cron = CronExpression.Parse(TIME);

var next = cron.GetNextOccurrence(DateTimeOffset.Now, TimeZoneInfo.Local)!;

Console.WriteLine(next.Value.DateTime.ToString(CultureInfo.CurrentCulture));
