using OdevInterfaces.DaireNo;
using OdevInterfaces.KatSayisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevInterfaces
{
    public class Apartman : IKatSayisi, IDaireNo
    {
        public int KatSayisi { get ; set; }
        public string OdaSayisi { get; set; }
        public int DaireNo { get; set; }
    }
}
