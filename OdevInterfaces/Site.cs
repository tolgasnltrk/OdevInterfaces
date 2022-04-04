using OdevInterfaces.DaireNo;
using OdevInterfaces.KatSayisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevInterfaces
{
    public class Site : IKatSayisi, IDaireNo
    {
        public int KatSayisi { get; set; }
        public string OdaSayisi { get; set; }

        public Blok Blok { get; set; }
        public int DaireNo { get; set; }
    }
}
