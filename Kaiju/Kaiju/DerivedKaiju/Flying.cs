using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKaiju
{
    public class Flying : Kaiju
    {
        int _flightSpeed;

        public Flying()
        {
            Name = "Base Flying";
            _flightSpeed = 1;
        }

        public Flying(int flightSpeed, string name, float version)
            : base(name, version)
        {
            FlightSpeed = flightSpeed;
        }

        public int FlightSpeed
        {
            set
            {
                if (value > 0)
                {
                    _flightSpeed = value;
                }
                else
                {
                    throw new System.Exception("Incorrect flightSpeed!");
                }
            }
            get
            {
                return _flightSpeed;
            }
        }

        public override string GetСompleteInformation()
        {
            return base.GetСompleteInformation() + "\n FlightSpeed: " + _flightSpeed;
        }

        public override bool Equals(object o1)
        {
            Flying f1 = (Flying)o1;
            if (this.Name == f1.Name & this.Version == f1.Version & this.FlightSpeed == f1.FlightSpeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + FlightSpeed;
        }

        public override string ToString()
        {
            return this.GetСompleteInformation();
        }
        public override string StringForFile()
        {
            return base.StringForFile() + "FlightSpeed: " + '%' + _flightSpeed + '%';
        }
    }
}
