using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi;
using indice.Edi.Serialization;
using indice.Edi.Utilities;
using System.IO;

namespace Edi_read
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Srinivas.lakkineni\Documents\Working Copy\indice\po.edi";



            var grammar = EdiGrammar.NewEdiFact();
            int msgCount = 0;

            var interchange = default(Interchange);
            var unh = new Quote();
            var lin = default(LineItem);

            using (var stream = new StreamReader(path))
            {
                interchange = new EdiSerializer().Deserialize<Interchange>(stream, grammar);
                unh = new EdiSerializer().Deserialize<Quote>(stream, grammar);
                lin = new EdiSerializer().Deserialize<LineItem>(stream, grammar);

                string aa = null;
            }



        }
    }
}
