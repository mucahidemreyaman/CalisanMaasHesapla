using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanMaasHesapla.Lib
{
    public class SozlesmeliPersonel : BasePersonel
    {
        #region Fields 

        private int gun;
        private int gunlukucret;



        #endregion

        #region Properties

        public int Gun { get => gun; set => gun =Math.Abs(value); }
        public int Gunlukucret { get => gunlukucret; set => gunlukucret =Math.Abs(value); }

        #endregion

        #region Constructors
        public SozlesmeliPersonel(int kimliknumarasi, string ad, string soyad, int gun, int gunlukucret )
            :base(kimliknumarasi, ad, soyad)
        {

            Gun = gun;
            Gunlukucret=gunlukucret;

        }
        public SozlesmeliPersonel()
        {
            
        }

        #endregion

        #region Methods

        public override string AdSoyadGetir()


        {

            return base.AdSoyadGetir();

        }

       public override int AylikHesapla()
        {
            return 
                Gun*Gunlukucret;

        }
        #endregion


    }
}
