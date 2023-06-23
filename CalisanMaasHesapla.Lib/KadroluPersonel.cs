using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanMaasHesapla.Lib
{
    public class KadroluPersonel : BasePersonel
    {

        #region Fields 

        private int raporsayisi;
        private int aylik;


        #endregion

        #region Properties 
        public int Raporsayisi { get => raporsayisi; set => raporsayisi =Math.Abs(value); }
        public int Aylik { get => aylik; set => aylik =Math.Abs(value); }

        #endregion

        #region Constructors 

        public KadroluPersonel(int kimliknumarasi,string ad,string soyad,int raporsayisi,int aylik)
                                 : base(kimliknumarasi, ad, soyad)
        {
            Raporsayisi = raporsayisi;
            Aylik = aylik;

        }



        #endregion

        #region Methods 

        public override string AdSoyadGetir()


        {

            return base.AdSoyadGetir();

        }

        public override int AylikHesapla()
        {

            if (Raporsayisi <= 5)
                return Aylik;
            else
                return Aylik - (Aylik / 30) * Raporsayisi;


        }
        #endregion



    }
}
