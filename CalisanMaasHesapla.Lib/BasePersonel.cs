namespace CalisanMaasHesapla.Lib
{
    public abstract class BasePersonel
    {

        #region Fields

        private int kimliknumarasi;
        private string ad;
        private string soyad;


        #endregion

        #region Properties

        public int Kimliknumarasi { get => kimliknumarasi; set => kimliknumarasi =Math.Abs(value); }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }



        #endregion

        #region Constructors

        public BasePersonel(int kimliknumarasi, string ad, string soyad)
        {
            Kimliknumarasi = kimliknumarasi;
            Ad = ad;
            Soyad = soyad; 
        }

        public BasePersonel()
        {
                
        }
        #endregion

        #region Methods


        public virtual string AdSoyadGetir()


        {

            return $"KimlikNumarasi : {Kimliknumarasi}\nAd : {Ad}\nSoyad : {Soyad}";

        }

        public virtual int AylikHesapla()
        {
            return 0;
        }
       

        #endregion

    }



}