using Hospital_Shift.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital_Shift.Entities
{
  public  class Hemsire:Personel,INobet
    {
       

        public int nobetsaati { get; set; } = 20;

        public void nobettut()
        {
            double sonuc;
            sonuc = maas * nobetsaati * 0.4;
            System.Windows.Forms.MessageBox.Show($"{isim} bu ay {nobetsaati} saat nöbet tutmuştur. Alacağı ek ücret {sonuc}tldir.");
        }
        public override string ToString()
        {
            return isim + "  TC:" + tcno + "  MAAŞ:" + maas;
        }
    }
}
