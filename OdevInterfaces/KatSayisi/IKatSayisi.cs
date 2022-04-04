using OdevInterfaces.KatSayisi.OdaSayisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevInterfaces.KatSayisi
{
    public interface IKatSayisi : IOdaSayisi
    {
        public int KatSayisi { get; set; }
    }
}
