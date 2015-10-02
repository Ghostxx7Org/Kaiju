using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKaiju
{
    interface INameVersion
    {
        string Name { get; set; }
        float Version { get; set; }
    }
}
