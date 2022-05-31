using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Shift.Entities
{
    public  abstract class  Personel
    {
        #region Properties
        
        public string isim { get; set; }
        private string _telefon;
        public string telefon
        {
            get { return _telefon; }
            set
            {
                if (!HaneliMi(value,10))
                {
                    throw new Exception ("Telefon Numarası 10 Haneli olmalıdır. Lütfen Başında 0 olmadan 10 haneli olacak şekilde yazınız.");
                }
                if (!TumKarakterlerRakamMi(value))
                {
                    throw new Exception("Telefon Numarası yalnızca rakamlardan oluşmalıdır.");
                }
               
                _telefon = value; }

        }
        private string _tcno;
        public string tcno
        {
            get { return _tcno; }
            set
            {
                if (!HaneliMi(value,11))
                {
                    throw new Exception("TC no 11 haneli olmalıdır.");
                }
                if (!TumKarakterlerRakamMi(value))
                {
                    throw new Exception("TC yalnızca rakamlardan oluşmalıdır.");
                }
               

                _tcno = value; }

        }
        private double _maas;
        public double maas
        {
            get { return _maas; }
            set
            {
                if (!TumKarakterlerRakamMi(value.ToString()))
                {
                    throw new Exception("maaş yalnızca rakamlardan oluşmalıdır.");
                }
             
                _maas = value; 
               
            }
               

        }
        public  Cinsiyet Cinsiyet;

        #endregion
        
        public bool HaneliMi(string y,int x)
        {
            if (y.Length==x)
            {
                return true;
            }

            return false;
        }
       
        static bool TumKarakterlerRakamMi(string metin) //IsAllCharacterDigit
        {
            foreach (var item in metin)
            {
                if (!char.IsDigit(item)) 
                {
                    return false;
                }
            }

            return true;
        }
    

    }
     public enum Cinsiyet
        {
            erkek ,
            kadın 
        }
}
