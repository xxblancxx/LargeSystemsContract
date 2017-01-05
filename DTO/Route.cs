using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FerryContract
{
    [Serializable]
    public class Route
    {
        public int ID ;
        public string Origin ;
        public string Destination ;
        public TimeSpan Duration ;
        public Route()
        {

        }
        public Route(string origin, string destination, TimeSpan duration)
        {
            Origin = origin;
            Destination = destination;
            Duration = duration;
        }
    }
}
