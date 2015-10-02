using System;

namespace NKaiju
{
    interface INameAndVersion
    {
        string Name
        {
            get;
            set;
        }
        float Version
        {
            get;
            set;
        }
    }
}
