using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FerryContract
{
    [Serializable]
    public class Customer
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

    }
}
