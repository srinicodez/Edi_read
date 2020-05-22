using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi;
using indice.Edi.Serialization;
using indice.Edi.Utilities;

namespace Edi_read
{
    [EdiMessage, EdiCondition("UTLTLR", Path = "MHD/1")]
    public class InterchangeTrailer
    {

        [EdiValue("9(1)", Path = "MHD/1/1")]
        public int Version { get; set; }
    }
}
