﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerryContract.ETO
{
    [Serializable]
    class VehicleInvalidException : ArgumentOutOfRangeException
    {
        public VehicleInvalidException()
        {

        }
        public VehicleInvalidException(string message) : base(message)
        {

        }
    }
}
