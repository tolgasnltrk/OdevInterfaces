
using OdevInterfaces.DaireNo;
using OdevInterfaces.KatSayisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevInterfaces
{
    public class Yazlik : IMustakil, IDaireNo
    {
        public string BahceliMi { get; set; }
        public int DaireNo { get; set; }
    }
}
