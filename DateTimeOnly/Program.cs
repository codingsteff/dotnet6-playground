DateOnly d1 = new DateOnly(2021, 12, 31);
TimeOnly t1 = new TimeOnly(11, 59, 20, 10);
Console.WriteLine($"{d1} - {t1}");

var workStart = new TimeOnly(8, 0);
var workEnd = new TimeOnly(17, 0);
var now = TimeOnly.FromDateTime(DateTime.Now);
if (now.IsBetween(workStart, workEnd))
{
    Console.WriteLine("During working hours");
    TimeSpan workRest = workEnd - now;
    Console.WriteLine($"{workRest:hh}h and {workRest:mm}min. until closing time");
}
else
{
    Console.WriteLine("Outside working hours");
}