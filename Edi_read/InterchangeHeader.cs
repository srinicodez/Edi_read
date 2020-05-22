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
    [EdiMessage, EdiCondition("UTLHDR", Path = "MHD/1")]
    public class InterchangeHeader
    {
        [EdiValue("9(4)"), EdiPath("TYP")]
        public string TransactionCode { get; set; }

        [EdiValue("9(1)", Path = "MHD/1/1")]
        public int Version { get; set; }
    }
}
