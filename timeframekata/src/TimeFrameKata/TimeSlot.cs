using TimeFrameKata;
namespace TimeFrameKata;

    public class TimeSlot
    {
        public DateTime Start { get; }
        public DateTime End { get; }

        private TimeSlot(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public static TimeSlot CreateTimeSlot(DateTime start, DateTime end)
        {
            if(start >= end)
            {
                throw new ArgumentException("Der Startzeitpunkt muss vor dem Endzeitpunkt liegen.");
            }

            if((end - start).TotalMinutes < 15)
            {
                throw new ArgumentException("Der Zeitabschnit muss mindestens 15 Minuten lang sein");
            }

            if (start.Date != end.Date)
            {
                throw new ArgumentException("Der Zeitabschnitt darf sich nicht über mehrere Tage erstrecken.");
            }

            if (start.Second != 0 || end.Second != 0)
            {
                throw new ArgumentException("Die Uhrzeitangaben müssen im Minutentakt erfolgen.");
            }

            return new TimeSlot(start, end);
        }

        public bool OverlapsWith(TimeSlot other)
        {
            return !(Start >= other.End || End <= other.Start);
        }
    }

/* public static bool IsValidDuration()
        {
            return (End - Start).TotalMinutes >= 15;
        }

        public bool IsValidOrder()
        {
            return Start < End;
        } 

        public bool RunAcceptanceTests()
        {
            bool test1 = !IsValidDuration() && !IsValidOrder();
            bool test2 = !IsValidDuration() && IsValidOrder();
            bool test3 = IsValidDuration() && IsValidOrder();

            return test1 || test2 || test3;
        } */