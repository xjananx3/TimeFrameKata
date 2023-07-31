// See https://aka.ms/new-console-template for more information
using System.Globalization;
using TimeFrameKata;

List<TimeSlot> reservierungen = new List<TimeSlot>();

Console.WriteLine("Geben Sie den Startzeitpunkt für den Zeitabschnitt(yyyy - MM - dd HH: mm) ein: ");
var start1 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Geben Sie den Endzeitpunkt für den Zeitabschnitt(yyyy - MM - dd HH: mm) ein: ");
var end1 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

var timeSlot1 = TimeSlot.CreateTimeSlot(start1, end1);
reservierungen.Add(timeSlot1);


Console.WriteLine("Geben Sie den Startzeitpunkt für den Zeitabschnitt(yyyy - MM - dd HH: mm) ein: ");
var start2 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Geben Sie den Endzeitpunkt für den Zeitabschnitt(yyyy - MM - dd HH: mm) ein: ");
var end2 = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

var timeSlot2 = TimeSlot.CreateTimeSlot(start2, end2);
reservierungen.Add(timeSlot2);


//var start1 = new DateTime(2023, 7, 1, 23, 45, 0);
//var end1 = new DateTime(2023, 7, 2, 00, 15, 0);

//var start2 = new DateTime(2023, 7, 1, 15, 00, 0);
//var end2 = new DateTime(2023, 7, 1, 15, 14, 0);

// var timeSlot1 = new TimeSlot(start1, end1);
// var timeSlot2 = new TimeSlot(start2, end2);

foreach (var slot in reservierungen)
{
    
    Console.WriteLine("Ihre Reservierungen: " +  slot.Start + " - " + slot.End);
}

Console.WriteLine(start1);
Console.WriteLine(end1);
