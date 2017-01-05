using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerryContract.ETO
{
    [Serializable]
    class PersonCapacityException : ArgumentOutOfRangeException
    {
        public PersonCapacityException(string message) : base(message)
        {

        }
    }
}
