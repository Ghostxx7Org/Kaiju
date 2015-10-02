using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKaiju
{
    delegate string Deleg(bool b);
    interface InewinterTEst
    {
        void ShowMeTits(bool b);
    }
    class TestClass:InewinterTEst
    {
        public string Meth_1 (bool b)
        {
            if (b) return "true Meth1";
            else return "false";
        }
        public string Meth_2(bool b)
        {
            if (b) return "true Meth2";
            else return "false Meth2";
        }
        public string Meth_3 (bool b)
        {
            if (b) return "true Meth3";
            else return "false Meth3";
        }
        public void ShowMeTits(bool b)
        {
            if (b)
            Console.WriteLine("Class realise interface InewinterTest");
        }
    }
    static class FactoryKaiju
    {
        
        public static Kaiju[] GetKaiju(namesKaiju name, int numberName, float version, int count)
        {
            if (name >= namesKaiju.Kaiju & name <= namesKaiju.Zeus & numberName > 0 & count > 0)
            {
                Kaiju[] masKaiju = new Kaiju[count];
                for (int i = 0; i < masKaiju.Length; i++)
                {
                    masKaiju[i] = new Kaiju(name.ToString() + numberName++, version);
                }
                return masKaiju;
            }
            else
            {
                throw new System.Exception("The parameter is incorrect!");
            }
        }

        public static Flying[] GetFlying(namesKaiju name, int numberName, float version, int flyghtSpeed, int count)
        {
            if (name == namesKaiju.Flying & numberName > 0 & count > 0)
            {
                Flying[] masFlying = new Flying[count];
                for (int i = 0; i < masFlying.Length; i++)
                {
                    masFlying[i] = new Flying(flyghtSpeed, name.ToString() + numberName++, version);
                }
                return masFlying;
            }
            else
            {
                throw new System.Exception("The parameter is incorrect!");
            }
        }

        public static Gorilla[] GetGorilla(namesKaiju name, int numberName, float version, int distanceOfJump, int count)
        {
            if (numberName > 0 & count > 0)
            {
                Gorilla[] masGorilla = new Gorilla[count];
                for (int i = 0; i < masGorilla.Length; i++)
                {
                    masGorilla[i] = new Gorilla(distanceOfJump, name.ToString() + numberName++, version);
                }
                return masGorilla;
            }
            else
            {
                throw new System.Exception("The parameter is incorrect!");
            }
        }

        public static Titan[] GetTitan(namesKaiju name, int numberName, float version, float thicknessOfTitanium, int count)
        {
            if (numberName > 0 & count > 0)
            {
                Titan[] masTitan = new Titan[count];
                for (int i = 0; i < masTitan.Length; i++)
                {
                    masTitan[i] = new Titan(thicknessOfTitanium, name.ToString() + numberName++, version);
                }
                return masTitan;
            }
            else
            {
                throw new System.Exception("The parameter is incorrect!");
            }
        }

        public static Apollon[] GetApollon(namesKaiju name, int numberName, float version, float thicknessOfTitanium, int levelOfLibido, int count)
        {
            if (numberName > 0 & count > 0)
            {
                Apollon[] masApollon = new Apollon[count];
                for (int i = 0; i < masApollon.Length; i++)
                {
                    masApollon[i] = new Apollon(levelOfLibido, thicknessOfTitanium, name.ToString() + numberName++, version);
                }
                return masApollon;
            }
            else
            {
                throw new System.Exception("The parameter is incorrect!");
            }
        }

        public static Zeus[] GetZeus(namesKaiju name, int numberName, float version, float thicknessOfTitanium, int lightningStrikes, int count)
        {
            if (numberName > 0 & count > 0)
            {
                Zeus[] masZeus = new Zeus[count];
                for (int i = 0; i < masZeus.Length; i++)
                {
                    masZeus[i] = new Zeus(lightningStrikes, thicknessOfTitanium, name.ToString() + numberName++, version);
                }
                return masZeus;
            }
            else
            {
                throw new System.Exception("The parameter is incorrect!");
            }
        }

        public static Kaiju[] GetAllKaiju(int count, string newName, int numberName, float version, int distanceOfJump = 3, int flyghtSpeed = 4, float thicknessOfTitanium = 1.1f, int levelOfLibido = 1, int lightningStrikes = 1)
        {
            if (count > 0 & numberName > 0)
            {
                int sumOfAllKaiju = count * 6;
                Kaiju[] masAllKaiju = new Kaiju[sumOfAllKaiju];
                Kaiju[] tempKaiju = GetKaiju(namesKaiju.Kaiju, numberName, version, count);
                Gorilla[] tempGorilla = GetGorilla(namesKaiju.Gorila, numberName, version, distanceOfJump, count);
                Flying[] tempFluing = GetFlying(namesKaiju.Flying, numberName, version, flyghtSpeed, count);
                Titan[] tempTitan = GetTitan(namesKaiju.Titan, numberName, version, thicknessOfTitanium, count);
                Apollon[] tempApollon = GetApollon(namesKaiju.Apollon, numberName, version, thicknessOfTitanium, levelOfLibido, count);
                Zeus[] tempZeus = GetZeus(namesKaiju.Zeus, numberName, version, thicknessOfTitanium, lightningStrikes, count);
                for (int i = 0; i < count; i++)
                {
                    tempKaiju[i].Name = "Kaiju: " + newName + numberName++;
                    masAllKaiju[i] = tempKaiju[i];
                }
                for (int i = count, j = 0; i < count * 2; i++, j++)
                {
                    tempGorilla[j].Name = "Gorilla: " + newName + numberName++;
                    masAllKaiju[i] = tempGorilla[j];
                }
                for (int i = count * 2, j = 0; i < count * 3; i++, j++)
                {
                    tempFluing[j].Name = "Fluing: " + newName + numberName++;
                    masAllKaiju[i] = tempFluing[j];
                }
                for (int i = count * 3, j = 0; i < count * 4; i++, j++)
                {
                    tempTitan[j].Name = "Titan: " + newName + numberName++;
                    masAllKaiju[i] = tempTitan[j];
                }
                for (int i = count * 4, j = 0; i < count * 5; i++, j++)
                {
                    tempApollon[j].Name = "Apollon: " + newName + numberName++;
                    masAllKaiju[i] = tempApollon[j];
                }
                for (int i = count * 5, j = 0; i < count * 6; i++, j++)
                {
                    tempZeus[j].Name = "Zeus: " + newName + numberName++;
                    masAllKaiju[i] = tempZeus[j];
                }
                return masAllKaiju;
            }
            else
            {
                throw new System.Exception("The parameter is incorrect!");
            }
        }
    }
}
