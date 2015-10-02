using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKaiju
{
    public class Zeus : Titan
    {
        int _lightningStrikes;

        public Zeus()
        {
            Name = "Base Zeus";
            _lightningStrikes = 1;
        }

        public Zeus(int lightningStrikes, float thicknessOfTitanium, string name, float version)
            : base(thicknessOfTitanium, name, version)
        {
            LightningStrikes = lightningStrikes;
        }

        public int LightningStrikes
        {
            set
            {
                if (value > 0)
                {
                    _lightningStrikes = value;
                }
                else
                {
                    throw new System.Exception("Incorrect lightningStrikes!");
                }
            }
            get
            {
                return _lightningStrikes;
            }
        }

        public override string GetСompleteInformation()
        {
            return base.GetСompleteInformation() + "\n LightningStrikes: " + _lightningStrikes;
        }

        public override bool Equals(object o1)
        {
            Zeus z1 = (Zeus)o1;
            if (this.Name == z1.Name & this.Version == z1.Version & this.ThicknessOfTitanium == z1.ThicknessOfTitanium & this.LightningStrikes == z1.LightningStrikes)
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
            return base.GetHashCode() + LightningStrikes;
        }

        public override string ToString()
        {
            return this.GetСompleteInformation();
        }
        public override string StringForFile()
        {
            return base.StringForFile() + "LightningStrikes: " +'%'+ _lightningStrikes+'%';
        }
    }
}
