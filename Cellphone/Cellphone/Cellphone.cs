using System;
using System.Collections.Generic;
using System.Text;

namespace Cellphone1
{
    class Cellphone
    {
        public string Phonenumber { get; set; }     // all the properties that are set inside of the class
        public string Serviceprovider { get; set; }
        public string OperatingSystem { get; set; }
        public bool Active { get; set; } = true;
        public int Capacity { get; set; }
        public string Model { get; set; }
    }
}
