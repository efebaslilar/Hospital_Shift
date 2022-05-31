using Hospital_Shift.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Shift.Entities
{
  public  class AsistanDoktor : Personel,INobet
    {
        public bool nobettutacakmı { get; set; } = true;
        public int nobetsaati { get; set; } = 15;



        double sonuc=0;
        public void nobettut()
        {
            if (nobettutacakmı)
            {
                sonuc = maas * nobetsaati * 0.8;
                System.Windows.Forms.MessageBox.Show($"{isim} bu ay {nobetsaati} saat nöbet tutmuştur. Alacağı ek ücret {sonuc}tldir.");
            }
            else
            {
             System.Windows.Forms.MessageBox.Show($"{isim} bu ay nöbet tutmamıştır.");
            }
            
        }
        public override string ToString()
        {
            return isim + "  TC:" + tcno + "  MAAŞ:" + maas;
        }
    }
    
}
