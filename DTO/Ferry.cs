using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FerryContract
{
    [Serializable]
    public class Ferry
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int PeopleCapacity { get; private set; }
        public int VehicleCapacity { get; private set; }
        public int WeightCapacity { get; private set; }
    }
}
