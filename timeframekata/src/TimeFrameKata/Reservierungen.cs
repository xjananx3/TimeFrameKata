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
        foreach (var existingTimeslot in reservierungsListe)
        {
            if(timeSlot.OverlapsWith(existingTimeslot))
            {
                throw new ArgumentException("Die Reservierung kann nicht durchgeführt werden, da es bereits eine Überlappung mit einer bestehenden Reservierung gibt.");
            }
        }
        reservierungsListe.Add(timeSlot);
    }

    public List<TimeSlot> GetReservierungen()
    {
        return reservierungsListe;
    }
}
