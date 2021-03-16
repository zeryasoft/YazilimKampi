using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //private Urun _urun;

        //public SepetManager(Urun urun)
        //{
        //    _urun = urun;
        //}
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, {0} Sepete Eklendi.",urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler, {0} Sepete Eklendi.", urunAdi);
        }
    }
}
