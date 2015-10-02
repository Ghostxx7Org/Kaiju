using System;

namespace NKaiju
{
    delegate void Del_2();
    class Cls1
    {
        public static event Del_2 Even1;
        public static void GoEvent()
        {
            if (Even1 != null)
                Even1();
        }
    }
    class Cls2
    {
        public static void Meth21()
        {
            Console.WriteLine("Meth21go");
        }
        public void Meth22()
        {
            Console.WriteLine("Meth22go");
        }
    }


    class Program
    {
        static void Main()
        {
      
            FileKaiju obj_FileKaiju = new FileKaiju();
            ContextKaiju objContext_1 = new ContextKaiju(2);
            //obj_FileKaiju.AddToFile(new Apollon());
            //obj_FileKaiju.AddToFile(new Kaiju());
            //obj_FileKaiju.AddToFile(new Zeus());
            //obj_FileKaiju.AddToFile(new Titan());
            //obj_FileKaiju.AddToFile(new Gorilla());
            //obj_FileKaiju.AddToFile(new Flying());
            objContext_1.Add(obj_FileKaiju.ReadFile());
            objContext_1.OutputKaiju();
            Del_2 D_2 = new Del_2(Cls2.Meth21);
            Del_2 D_3 = Cls2.Meth21;
            D_3 += D_2;
            Cls1.Even1 += Cls2.Meth21;
            Cls2 o1 = new Cls2();
            Cls1.Even1 += o1.Meth22;
            Cls1.GoEvent();

            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}