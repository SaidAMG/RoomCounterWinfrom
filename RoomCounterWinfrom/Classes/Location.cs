using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCounterWinfrom
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Sensor sensor { get; set; }

        public Location(int _ID, string _Name)
        {
            ID = _ID;
            Name = _Name;
            sensor = null;
        }

        public void SetSensor(Sensor _sensor)
        {
            this.sensor = _sensor;
        }
    }
}
