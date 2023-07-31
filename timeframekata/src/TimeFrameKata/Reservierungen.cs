using System.Collections.Generic;
using TimeFrameKata;
namespace TimeFrameKata;

public class Reservierungen 
{
    private List<TimeSlot> reservierungsListe;

    public Reservierungen()
    {
        reservierungsListe = new List<TimeSlot>();
    }
        
    public void AddReservierung(TimeSlot timeSlot)
    {
        reservierungsListe.Add(timeSlot);
    }

    public List<TimeSlot> GetReservierungen()
    {
        return reservierungsListe;
    }
}
