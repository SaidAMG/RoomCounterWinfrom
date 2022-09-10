using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCounterWinfrom
{
    public class Sensor
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Sensor(int _ID, string _Name)
        { 
            ID = _ID;
            Name = _Name;
        }

    }
}
