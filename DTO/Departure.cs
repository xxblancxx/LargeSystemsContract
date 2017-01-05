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
        public int ID ;
        public DateTime Date ;
        public DateTime Time ;
        public Departure()
        {

        }
        public Departure(DateTime date, DateTime time)
        {
            Date = date;
            Time = time;
        }
    }
}
