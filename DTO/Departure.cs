using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FerryContract
{
    [Serializable]
    public class Departure
    {
        public int ID { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime Time { get; private set; }

        public Departure(DateTime date, DateTime time)
        {
            Date = date;
            Time = time;
        }
    }
}
