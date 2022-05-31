using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Shift.Entities
{
  public  class CerrahiDoktor : Personel
    {
        public override string ToString()
        {
            return isim + "  TC:" + tcno + "  MAAŞ:" + maas;
        }
    }
}
