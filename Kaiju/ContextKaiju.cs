using System;

namespace NKaiju
{
    public class ContextKaiju
    {
        Kaiju[] masKaiju;
        int countKaiju;

        public ContextKaiju()
        {
            masKaiju = new Kaiju[15];
            countKaiju = 0;
        }

        public ContextKaiju(int i)
        {
            if (i > 0)
            {
                masKaiju = new Kaiju[i];
                countKaiju = 0;
            }
            else
            {
                throw new System.Exception("ContextKaiju(int i) - argument exeption.");
            }
        }

        public Kaiju this[int index]
        {
            set
            {
                if (index >= 0 & index < countKaiju)
                {
                    for (int i = 0; i < countKaiju - index; i++)
                    {
                        masKaiju[countKaiju - i] = masKaiju[countKaiju - i - 1];
                    }
                    masKaiju[index] = value;
                    countKaiju++;
                }
                else if (index >= countKaiju & index < masKaiju.Length)
                {
                    masKaiju[countKaiju++] = value;
                }
            }
            get
            {
                if (index >= 0 & index < masKaiju.Length)
                {
                    return masKaiju[index];
                }
                else
                {
                    return null;
                }
            }
        }

        public void Add(params Kaiju[] kaiju)
        {
            if (kaiju != null & kaiju.Length != 0)
            {
                if (countKaiju + kaiju.Length > masKaiju.Length)
                {
                    Kaiju[] copyMasKaiju = new Kaiju[masKaiju.Length];
                    for (int i = 0; i < masKaiju.Length; i++)
                    {
                        copyMasKaiju[i] = masKaiju[i];
                    }
                    masKaiju = new Kaiju[countKaiju + kaiju.Length + 10];
                    for (int i = 0; i < copyMasKaiju.Length; i++)
                    {
                        masKaiju[i] = copyMasKaiju[i];
                    }
                }

                for (int i = 0; i < kaiju.Length; i++)
                {
                    masKaiju[countKaiju] = kaiju[i];
                    countKaiju++;
                }

            }
        }

        //public void RemoveByID(params int[] removId)
        //{
        //    if (removId != null & removId.Length != 0)
        //    {
        //        for (int iRem = 0; iRem < removId.Length; iRem++)
        //        {
        //            for (int iMasK = 0; iMasK < countKaiju; iMasK++)
        //            {
        //                if (masKaiju[iMasK] != null && masKaiju[iMasK].ID == removId[iRem])
        //                {
        //                    for (int x = iMasK; x < countKaiju; x++)
        //                    {
        //                        if (x < countKaiju - 1)
        //                        {
        //                            masKaiju[x] = masKaiju[x + 1];
        //                        }
        //                        if (x == countKaiju - 1)
        //                        {
        //                            masKaiju[x] = null;
        //                            countKaiju--;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //public void SortingArrayById()
        //{
        //    for (int j = 0; j < countKaiju - 1; j++)
        //    {
        //        for (int i = 0; i < countKaiju - 1; i++)
        //        {
        //            if (masKaiju[i].ID > masKaiju[i + 1].ID)
        //            {
        //                Kaiju temp = new Kaiju();
        //                temp = masKaiju[i];
        //                masKaiju[i] = masKaiju[i + 1];
        //                masKaiju[i + 1] = temp;
        //            }
        //        }
        //    }
        //}

        public void OutputKaiju()
        {
            for (int i = 0; i < countKaiju; i++)
            {
                if (masKaiju[i] != null)
                {
                    Console.WriteLine(masKaiju[i].GetСompleteInformation());
                }
            }
        }

        public void Clear()
        {
            for (int i = 0; i < countKaiju - 1; i++)
            {
                masKaiju[i] = null;
            }
        }

        public Kaiju[] GetArrayKaiju()
        {
            Kaiju[] tempMasKaiju = new Kaiju[countKaiju];
            for (int i = 0; i < countKaiju; i++)
            {
                tempMasKaiju[i] = masKaiju[i];
            }
            return tempMasKaiju;
        }

        //public Kaiju GetKaijuByID(int kaijuId)
        //{
        //    if (kaijuId > 0)
        //    {
        //        for (int i = 0; i < countKaiju; i++)
        //        {
        //            if (masKaiju[i].ID == kaijuId)
        //            {
        //                return masKaiju[i];
        //            }
        //        }
        //        Kaiju temp = new Kaiju();
        //        temp = null;
        //        return temp;
        //    }
        //    else
        //    {
        //        throw new System.ArgumentException("KaijyId<=0");
        //    }
        //}

        public Gorilla[] GetArrayGorilla()
        {
            Kaiju[] k1 = GetArrayForName("Gorilla");
            Gorilla[] g1 = new Gorilla[k1.Length];
            for (int i = 0; i < k1.Length; i++)
            {
                g1[i] = (Gorilla)k1[i];
            }
            return g1;
        }

        public Flying[] GetArrayFlying()
        {
            Kaiju[] k1 = GetArrayForName("Flying");
            Flying[] f1 = new Flying[k1.Length];
            for (int i = 0; i < k1.Length; i++)
            {
                f1[i] = (Flying)k1[i];
            }
            return f1;
        }

        public Titan[] GetArrayTitan()
        {
            Kaiju[] k1 = GetArrayForName("Titan");
            Titan[] t1 = new Titan[k1.Length];
            for (int i = 0; i < k1.Length; i++)
            {
                t1[i] = (Titan)k1[i];
            }
            return t1;
        }

        public Apollon[] GetArrayApollon()
        {
            Kaiju[] k1 = GetArrayForName("Apollon");
            Apollon[] a1 = new Apollon[k1.Length];
            for (int i = 0; i < k1.Length; i++)
            {
                a1[i] = (Apollon)k1[i];
            }
            return a1;
        }

        public Zeus[] GetArrayZeus()
        {
            Kaiju[] k1 = GetArrayForName("Zeus");
            Zeus[] z1 = new Zeus[k1.Length];
            for (int i = 0; i < k1.Length; i++)
            {
                z1[i] = (Zeus)k1[i];
            }
            return z1;
        }

        private Kaiju[] GetArrayForName(string name)
        {
            int countKaijuMethod = 0;
            string NameType = name;
            for (int i = 0; i < countKaiju; i++)
            {
                Type t1 = masKaiju[i].GetType();
                if (NameType == t1.Name)
                {
                    countKaijuMethod++;
                }
            }
            Kaiju[] mKaiju = new Kaiju[countKaijuMethod];
            for (int iKaiju = 0, iTrueKaiju = 0; iKaiju < countKaiju; iKaiju++)
            {
                Type t1 = masKaiju[iKaiju].GetType();
                if (NameType == t1.Name)
                {
                    mKaiju[iTrueKaiju++] = masKaiju[iKaiju];
                }
                if (iTrueKaiju == countKaijuMethod)
                {
                    break;
                }
            }
            return mKaiju;
        }

        public static ContextKaiju operator +(ContextKaiju context1, ContextKaiju context2)
        {
            Kaiju[] k1 = context1.GetArrayKaiju();
            Kaiju[] k2 = context2.GetArrayKaiju();
            ContextKaiju context3 = new ContextKaiju(k1.Length + k2.Length);
            context3.Add(k1);
            context3.Add(k2);
            return context3;
        }

        public override bool Equals(object o1)
        {
            ContextKaiju context1 = (ContextKaiju)o1;
            if (this.masKaiju.Length == context1.masKaiju.Length & this.countKaiju == context1.countKaiju)
            {
                for (int i = 0; i < this.countKaiju; i++)
                {
                    if (this.masKaiju[i].GetType().Name == context1.masKaiju[i].GetType().Name)
                    {
                        if (!this.masKaiju[i].Equals(context1.masKaiju[i]))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int sumHashKaiju = 0;
            for (int i = 0; i < countKaiju; i++)
            {
                sumHashKaiju += masKaiju[i].GetHashCode();
            }
            return sumHashKaiju + masKaiju.Length + countKaiju;
        }
    }
}