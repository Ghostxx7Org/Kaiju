using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKaiju
{
    public class Titan : Kaiju
    {
        protected float _thicknessOfTitanium;
        public StringBuilder sb = new StringBuilder("Titan");

        public Titan()
        {
            Name = "Base Titan";
            _thicknessOfTitanium = 1.1f;
        }

        public Titan(float thicknessOfTitanium, string name, float version)
            : base(name, version)
        {
            ThicknessOfTitanium = thicknessOfTitanium;
        }

        public float ThicknessOfTitanium
        {
            set
            {
                if (value > 0)
                {
                    _thicknessOfTitanium = value;
                }
                else
                {
                    throw new System.Exception("Incorrect thicknessOfTitanium!");
                }
            }
            get
            {
                return _thicknessOfTitanium;
            }
        }

        public override string GetСompleteInformation()
        {
            return base.GetСompleteInformation() + "\n ThicknessOfTitanium: " + _thicknessOfTitanium;
        }

        public override bool Equals(object o1)
        {
            Titan t1 = (Titan)o1;
            if (this.Name == t1.Name & this.Version == t1.Version & this.ThicknessOfTitanium == t1.ThicknessOfTitanium)
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
            int result = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                result += Name[i];
            }
            return base.GetHashCode() + result + (int)ThicknessOfTitanium * 10;
        }

        public override string ToString()
        {
            return this.GetСompleteInformation();
        }
        public override string StringForFile()
        {
            return base.StringForFile() + "ThicknessOfTitanium: " +'%'+ _thicknessOfTitanium+'%';
        }
    }
}
