using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FerryContract
{
    [Serializable]
    public class Reservation
    {
        public int ID { get; private set; }
        public int ReservationNumber { get; set; }
        public bool HasArrived { get; set; }
    }
}
