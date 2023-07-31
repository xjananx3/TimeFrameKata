// See https://aka.ms/new-console-template for more information
using System.Globalization;
using TimeFrameKata;

Reservierungen reservierungen = new Reservierungen();

while (true)
{
    Console.WriteLine("Geben Sie den Startzeitpunkt für den Zeitabschnitt(yyyy - MM - dd HH: mm) ein: ");
    DateTime start = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

    Console.WriteLine("Geben Sie den Endzeitpunkt für den Zeitabschnitt(yyyy - MM - dd HH: mm) ein: ");
    DateTime end = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

    TimeSlot timeSlot = TimeSlot.CreateTimeSlot(start, end);
    reservierungen.AddReservierung(timeSlot);

    Console.WriteLine("Möchten sie weitere Reservierungen hinzufügen? 'ja' eingeben");
    string answer = Console.ReadLine();
    if (answer.ToLower() != "ja")
    {
        break;
    }
}

foreach (var reservierung in reservierungen.GetReservierungen())
{
    
    Console.WriteLine("Ihre Reservierungen: " +  reservierung.Start + " - " + reservierung.End);
}



//var start1 = new DateTime(2023, 7, 1, 23, 45, 0);
//var end1 = new DateTime(2023, 7, 2, 00, 15, 0);

//var start2 = new DateTime(2023, 7, 1, 15, 00, 0);
//var end2 = new DateTime(2023, 7, 1, 15, 14, 0);

// var timeSlot1 = new TimeSlot(start1, end1);
// var timeSlot2 = new TimeSlot(start2, end2);



