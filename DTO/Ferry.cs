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
       
        public int ID ;
        public string Name ;
        public int PeopleCapacity ;
        public int VehicleCapacity ;
        public int WeightCapacity ;
        public Ferry()
        {

        }
        public Ferry(string name, int peoplecap, int vehiclecap, int weightcap)
        {
            Name = name;
            PeopleCapacity = peoplecap;
            VehicleCapacity = vehiclecap;
            WeightCapacity = weightcap;
        }
    }
}
