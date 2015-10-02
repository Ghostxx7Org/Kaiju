using System;

namespace NKaiju
{
    public class Kaiju : INameVersion, IComparable, IComparable<Kaiju>
    {
        public Guid ID;

        string _name;
        float _version;

        static int countKaiju;

        //static Kaiju()
        //{
        //    countKaiju = 0;
        //}

        public Kaiju()
        {
            ID = Guid.NewGuid();
            Name = "Base Kaiju";
            Version = 1.0f;
        }

        public Kaiju(string name, float version)
        {
            Name = name;
            Version = version;
            ID = Guid.NewGuid();
        }


        public string Name
        {
            set
            {
                if (!String.IsNullOrWhiteSpace(value) & value.IndexOf('%') == -1)
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new System.Exception("Incorrect name!");
                }
            }
            get
            {
                return _name;
            }
        }

        public float Version
        {
            set
            {
                if (value > 0)
                {
                    _version = value;
                }
                else
                {
                    throw new IncorectedVersionExeption(value, this.GetType().Name, "Test Inner Exeption", new DivideByZeroException());
                }
            }
            get
            {
                return _version;
            }
        }

        public virtual string GetСompleteInformation()
        {
            return "\n Kaiju: \n id: " + ID + "\n Name: " + Name + "\n Version: " + Version;
        }

        public virtual string StringForFile()
        {
            return this.GetType().Name + "%" + " id: " + "%" + ID + "%" + " Name: " + "%" + Name + "%" + " Version: " + "%" + Version+'%';
        }

        public override bool Equals(object o1)
        {
            if (o1.GetType().Name != namesKaiju.Kaiju.ToString())
            {
                return false;
            }
            Kaiju K1 = (Kaiju)o1;
            if (this.Name == K1.Name & this.Version == K1.Version)
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
            int x = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                x += Name[i];
            }
            return x + (int)Version * 10;
        }

        public override string ToString()
        {
            return this.GetСompleteInformation();
        }

        public int CompareTo(object o1)
        {
            if (o1 is Kaiju)
            {
                Kaiju k1 = (Kaiju)o1;
                if (this.Version == k1.Version)
                {
                    return 0;
                }
                else if (this.Version < k1.Version)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                throw new System.Exception();
            }
        }

        public virtual int CompareTo(Kaiju k1)
        {
            if (k1 == null)
            {
                throw new NullReferenceException();
            }
            if (this.Version == k1.Version)
            {
                return 0;
            }
            else if (this.Version < k1.Version)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}