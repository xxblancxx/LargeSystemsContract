using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FerryContract
{
    [Serializable]
    public class Passenger
    {
        public int ID { get; private set; }
        public bool IsLocal { get; private set; }
    }
}
