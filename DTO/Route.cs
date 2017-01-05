﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FerryContract
{
    [Serializable]
    public class Route
    {
        public int ID { get; private set; }
        public string Origin { get; private set; }
        public string Destination { get; private set; }
        public TimeSpan Duration { get; private set; }
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
