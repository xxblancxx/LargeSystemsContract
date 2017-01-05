using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerryContract.ETO
{
    [Serializable]
    class WeightCapacityException : ArgumentOutOfRangeException
    {
        public WeightCapacityException()
        {

        }
        public WeightCapacityException(string message) : base(message)
        {

        }
    }
}
