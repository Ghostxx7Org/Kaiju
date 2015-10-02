using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKaiju
{
    public class Apollon : Titan
    {
        int _levelOfLibido;

        public Apollon()
        {
            Name = "Base Apollon";
            _levelOfLibido = 1;
        }
        public Apollon(int levelOfLibido, float thicknessOfTitanium, string name, float version)
            : base(thicknessOfTitanium, name, version)
        {
            LevelOfLibido = levelOfLibido;
        }

        public int LevelOfLibido
        {
            set
            {
                if (value > 0)
                {
                    _levelOfLibido = value;
                }
                else
                {
                    throw new System.Exception("Incorrect levelOfLibido!");
                }
            }
            get
            {
                return _levelOfLibido;
            }
        }

        public override string GetСompleteInformation()
        {
            return base.GetСompleteInformation() + "\n LevelOfLibido: " + _levelOfLibido;
        }

        public override bool Equals(object o1)
        {
            Apollon A1 = (Apollon)o1;
            if (this.Name == A1.Name & this.Version == A1.Version & this.ThicknessOfTitanium == A1.ThicknessOfTitanium & this.LevelOfLibido == A1.LevelOfLibido)
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
            return base.GetHashCode() + LevelOfLibido;
        }

        public override string ToString()
        {
            return this.GetСompleteInformation();
        }
        public override string StringForFile()
        {
            return base.StringForFile() + " LevelOfLibido: " + '%' + _levelOfLibido + '%';
        }
    }
}
