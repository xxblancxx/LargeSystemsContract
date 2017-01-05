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
        public int ID ;
        public bool IsLocal ;
        public Passenger()
        {

        }
        public Passenger(bool isLocal)
        {
            IsLocal = isLocal;
        }
    }
}
