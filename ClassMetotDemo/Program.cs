using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri mstr1 = new Musteri();
            mstr1.Adi = "Zişan";
            mstr1.Soyadi = "Büyüközkan";
            mstr1.TelNo = 1111;
            mstr1.Email = "zisanbuyukozkan@gmail.com";

            Musteri mstr2 = new Musteri();
            mstr2.Adi = "Müşerref";
            mstr2.Soyadi = "Selçok";
            mstr2.TelNo = 2222;
            mstr2.Email = "msrrfselck@gmail.com";

            Musteri mstr3 = new Musteri();
            mstr3.Adi = "Kübra";
            mstr3.Soyadi = "Tanıyan";
            mstr3.TelNo = 3333;
            mstr3.Email = "kbrtnyn@gmail.com";

            Musteri mstr4 = new Musteri();
            mstr4.Adi = "Vahide";
            mstr4.Soyadi = "Özdemir";
            mstr4.TelNo = 4444;
            mstr4.Email = "vhdozdmr@gmail.com";

            MusteriManager musteriManeger = new MusteriManager();
            musteriManeger.Ekle(mstr1);
            musteriManeger.Ekle(mstr2);
            musteriManeger.Ekle(mstr3);
            musteriManeger.Ekle(mstr4);

            Musteri[] musteriler = new Musteri[] { mstr1, mstr2, mstr3, mstr4 };
            foreach(var mstr in musteriler)
            {
                musteriManeger.Listele(mstr);
            }
            musteriManeger.Sil(mstr1);
            musteriManeger.Sil(mstr2);
            musteriManeger.Sil(mstr3);
            musteriManeger.Sil(mstr4);
        }
    }
}
