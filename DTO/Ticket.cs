using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FerryContract
{
    [Serializable]
    public class Ticket
    {
        public int ID ;
        public float Price ;
        public Ticket()
        {

        }
        public Ticket(float price)
        {
            Price = price;
        }
    }
}
