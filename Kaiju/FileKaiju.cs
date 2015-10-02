using System;
using System.IO;
using System.Text;


namespace NKaiju
{
    public class FileKaiju
    {

        public void AddToFile(Kaiju obj)
        {
            StreamWriter sw = new StreamWriter(Resource_1.pathSaveKaiju, true);
            sw.WriteLine(obj.StringForFile());
            sw.Close();
        }

        public int CountObjInFile()
        {
            int counterObj = 0;
            try
            {
                StreamReader sr = new StreamReader(Resource_1.pathSaveKaiju);
                while (sr.ReadLine() != null)
                {
                    counterObj++;
                }

                sr.Close();

            }
            catch
            {
                throw new System.Exception("Шняга");

            }
            return counterObj;

        }


        public Kaiju[] ReadFile()
        {
            int counterObj = CountObjInFile();
            Kaiju[] resultArrayKaiju = new Kaiju[counterObj];
            StreamReader sr = new StreamReader(Resource_1.pathSaveKaiju);
            string[] ArrayStringData;
            string tempString;
            string name=null;
            float version = 0;
            int id;
            float thicknessOfTitanium=0;
            int levelOfLibido=0;
            int lightningStrikes=0;
            int distanceOfJump=0;
            int flightSpeed=0;

            for (int i = 0; i < counterObj; i++)
            {
                tempString = sr.ReadLine();
                ArrayStringData = ParseString(tempString);
                for (int j = 0; j < ArrayStringData.Length; j++)
                {
                    if (ArrayStringData[j].IndexOf("id") > -1)
                    {
                        Int32.TryParse(ArrayStringData[j + 1], out id);
                    }
                    if (ArrayStringData[j].IndexOf("Name") > -1)
                    {
                        name = ArrayStringData[j + 1];
                    }
                    if (ArrayStringData[j].IndexOf("Version") > -1)
                    {
                        float.TryParse(ArrayStringData[j + 1], out version);
                    }
                    if (ArrayStringData[j].IndexOf("ThicknessOfTitanium") > -1)
                    {
                        float.TryParse(ArrayStringData[j + 1], out thicknessOfTitanium);
                    }
                    if (ArrayStringData[j].IndexOf("LevelOfLibido") > -1)
                    {
                        Int32.TryParse(ArrayStringData[j + 1], out levelOfLibido);
                    }
                    if (ArrayStringData[j].IndexOf("LightningStrikes") > -1)
                    {
                        Int32.TryParse(ArrayStringData[j + 1], out lightningStrikes);
                    }
                    if (ArrayStringData[j].IndexOf("DistanceOfJump") > -1)
                    {
                        Int32.TryParse(ArrayStringData[j + 1], out distanceOfJump);
                    }
                    if (ArrayStringData[j].IndexOf("FlightSpeed") > -1)
                    {
                        Int32.TryParse(ArrayStringData[j + 1], out flightSpeed);
                    }
                }
                switch (ArrayStringData[0])
                {
                    case "Kaiju":
                        resultArrayKaiju[i] = new Kaiju(name, version);
                        break;
                    case "Titan":
                        resultArrayKaiju[i] = new Titan(thicknessOfTitanium, name, version);
                        break;
                    case "Apollon":
                        resultArrayKaiju[i] = new Apollon(levelOfLibido, thicknessOfTitanium, name, version);
                        break;
                    case "Zeus":
                        resultArrayKaiju[i] = new Zeus(lightningStrikes, thicknessOfTitanium, name, version);
                        break;
                    case "Gorilla":
                        resultArrayKaiju[i] = new Gorilla(distanceOfJump, name, version);
                        break;
                    case "Flying":
                        resultArrayKaiju[i] = new Flying(flightSpeed, name, version);
                        break;
                }
            }                
            sr.Close();

            return resultArrayKaiju;
        }
                       
        public string[] ParseString(string StringFromFile)
        {
            string[] resultArray = StringFromFile.Split('%');
            return resultArray;

        }
    }

}
