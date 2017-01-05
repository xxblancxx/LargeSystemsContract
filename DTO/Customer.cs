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
        public int ID ;
        public string Name ;
        public string Email ;
        public Customer()
        {

        }
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

    }
}
