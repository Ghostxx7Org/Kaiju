using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKaiju
{
    public class Gorilla : Kaiju
    {
        int _distanceOfJump;

        public Gorilla()
        {
            Name = "Base Gorilla";
            _distanceOfJump = 1;
        }

        public Gorilla(int distanceOfJump, string name, float version)
            : base(name, version)
        {
            DistanceOfJump = distanceOfJump;
        }

        public int DistanceOfJump
        {
            set
            {
                if (value > 0)
                {
                    _distanceOfJump = value;
                }
                else
                {
                    throw new System.Exception("Incorrect distanceOfJump");
                }

            }
            get
            {
                return _distanceOfJump;
            }
        }

        public override string GetСompleteInformation()
        {
            return base.GetСompleteInformation() + "\n DistanceOfJump: " + _distanceOfJump;
        }

        public override bool Equals(object o1)
        {
            Gorilla G1 = (Gorilla)o1;
            if (this.Name == G1.Name & this.Version == G1.Version & this.DistanceOfJump == G1.DistanceOfJump)
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
            return base.GetHashCode() + DistanceOfJump;
        }

        public override string ToString()
        {
            return this.GetСompleteInformation();
        }
        public override string StringForFile()
        {
            return base.StringForFile() + " DistanceOfJump: " + '%' + _distanceOfJump + '%';
        }
    }
}
