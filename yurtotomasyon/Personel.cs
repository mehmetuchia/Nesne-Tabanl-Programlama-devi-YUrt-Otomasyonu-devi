using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace yurtotomasyon
{
    public class Personel
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Bolum { get; set; }
        public string Gorev { get; set; }

        public Personel(string isim, string soyisim, string bolum, string gorev)
        {
            Isim = isim;
            Soyisim = soyisim;
            Bolum = bolum;
            Gorev = gorev;
        }
        // Polymorphism için bir metot (virtual) ekliyoruz
        public virtual string BilgileriGetir()
        {
            return $"{Isim} {Soyisim} - {Bolum} - {Gorev}";
        }
    }
    public class IdarePersonel : Personel
    {
        public IdarePersonel(string isim, string soyisim, string gorev)
            : base(isim, soyisim, "İdare", gorev)  // "İdare" bölümünü varsayılan olarak atıyoruz
        { }

        // Personel sınıfındaki BilgileriGetir metodunu override ediyoruz
        public override string BilgileriGetir()
        {
            return $"{Isim} {Soyisim} - İdare Bölümü - {Gorev}";
        }
    }
    public class YemekhanePersonel : Personel
    {
        public YemekhanePersonel(string isim, string soyisim, string gorev)
            : base(isim, soyisim, "Yemekhane", gorev)  // "Yemekhane" bölümünü varsayılan olarak atıyoruz
        { }

        // Personel sınıfındaki BilgileriGetir metodunu override ediyoruz
        public override string BilgileriGetir()
        {
            return $"{Isim} {Soyisim} - Yemekhane Bölümü - {Gorev}";
        }
    }
    public class CamasirhanePersonel : Personel
    {
        public CamasirhanePersonel(string isim, string soyisim, string gorev)
            : base(isim, soyisim, "Çamaşırhane", gorev)  // "Çamaşırhane" bölümünü varsayılan olarak atıyoruz
        { }

        // Personel sınıfındaki BilgileriGetir metodunu override ediyoruz
        public override string BilgileriGetir()
        {
            return $"{Isim} {Soyisim} - Çamaşırhane Bölümü - {Gorev}";
        }
    }
    public class GuvenlikPersonel : Personel
    {
        public GuvenlikPersonel(string isim, string soyisim, string gorev)
            : base(isim, soyisim, "Güvenlik", gorev)  // "Güvenlik" bölümünü varsayılan olarak atıyoruz
        { }

        // Personel sınıfındaki BilgileriGetir metodunu override ediyoruz
        public override string BilgileriGetir()
        {
            return $"{Isim} {Soyisim} - Güvenlik Bölümü - {Gorev}";
        }
    }
    public class TemizlikPersonel : Personel
    {
        public TemizlikPersonel(string isim, string soyisim, string gorev)
            : base(isim, soyisim, "Temizlik", gorev)  // "Temizlik" bölümünü varsayılan olarak atıyoruz
        { }

        // Personel sınıfındaki BilgileriGetir metodunu override ediyoruz
        public override string BilgileriGetir()
        {
            return $"{Isim} {Soyisim} - Temizlik Bölümü - {Gorev}";
        }
    }
}
