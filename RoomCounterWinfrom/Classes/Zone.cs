using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCounterWinfrom
{
    public class Zone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxPeople { get; set; }
        public int CurrentAmountPeople { get; set; }
        public int Employee { get; set; }
        public List<Location> locations { get; set; }

        public Zone(int _ID, string _name, int _MaxPeople)
        {
            ID = _ID;
            Name = _name;
            locations = new List<Location>();
            MaxPeople = _MaxPeople;
        }

        public void AddLocation(Location _location)
        {
            this.locations.Add(_location);
        }

        public void AddEmployee()
        {
            Employee++;
        }

        public void SubEmployee()
        {
            Employee--;
        }

        public void AddToAmountPeople()
        {
            CurrentAmountPeople++;
        }

        public void SubAmountPeople()
        {
            CurrentAmountPeople--;
        }

        public void SetAmountPeople(int _AmountPeople)
        {
            CurrentAmountPeople = _AmountPeople;
        }
    }
}
