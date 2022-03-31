using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstProject
{
    internal class Kategori
    {
        private string _tipSecim;
        private string _cephe;
        private string _dairedurumu;
        private int _katsayisi;
        private int _banyosayi;


        //public Kategori(string tipSecim ,string cephe,string daireDurumu , int katSayi, int banyoSayi)
        //{
        //    _tipSecim = tipSecim;
        //    _cephe = cephe; 
        //    _dairedurumu = daireDurumu;
        //    _katsayisi = katSayi;
        //    _banyoSayisi = banyoSayi;



        //}
        //public void Aylikodeme(string cephe, int banyosayisi, string dairedurum);

        //cephe güney ve banyo sayısı 3'den büyük ise aidat ve yönetici üretici girlecek yıllık ödemesini yazdır.
        // cephe kuzey dairedurum site ise
        //1 aylik odeme teknik bakım servis ücreti + aidat yönetici ücreti hesaplat..
        //2 yillik odeme seçenekleri sun..


        ///teklifler method içerik aşağıda seçeneğe göre fiyat ekleme yap
        ///
        //private string tipsecimi;
        //private string cephe;
        //private string dairedurumu;
        //private int katsayisi;
        //private int banyosayisi;
        //private int ata;


        // public Kategori()
        // {

        // }




        public string Cephe
        {
            get { return _cephe; }
            set
            {
                if (_cephe == "Güney")
                {
                    Console.WriteLine("Cephe Güney");
                    _cephe = value;
                }
                else
                {
                    _cephe = value;

                }
            }
        }




        //public string Cephe
        //{
        //    get { return Cephe; }
        //    set
        //    {

        //        if (value == "Güney")
        //        {
        //            Console.WriteLine($"Cehpe :{_cephe}");
        //            _cephe = value;


        //        }
        //        else if (value == "Kuzey")
        //        {
        //            Console.WriteLine("Kuzey Cephe");
        //            _cephe = value;



        //        }
        //        else
        //        {
        //            Console.WriteLine("Tek");
        //        }


        //    }
        //}


        //Banyo Sayısı 3^TEN BUYUKse cephe güney ise...

        public int BanyoSayisi
        {
            get { return _banyosayi; }
            set
            {

                if (_banyosayi >= 3)
                {
                    Console.WriteLine("3 ");
                    _banyosayi = value;

                }
                else
                {
                    _banyosayi = value;
                }
            }
        }


        public string DaireDurum
        {
            get { return _dairedurumu; }
            set
            {
                // her iki durumda aynı ücretleri odeyecektir...
                if (_dairedurumu == "Kiralık" || _dairedurumu == "Satılık")
                {
                    _dairedurumu = value;
                }


            }
        }


        public int KatSayisi
        {
            get { return _katsayisi; }
            set
            {


                _katsayisi = value;


            }
        }






        public void AylikOdeme(string cephe, int banyoSayisi, string daireDurum)
        {

            cephe = _cephe;
            banyoSayisi = _banyosayi;
            daireDurum = _dairedurumu;

            if (cephe == "Güney" && banyoSayisi >= 3)
            {
                Console.WriteLine("Aidat bilgisi giriniz:");
                int aidat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yönetici ücreti giriniz:");
                int yoneticiUcret = Convert.ToInt32(Console.ReadLine());
                int toplamSonuc = (aidat * 12) + (yoneticiUcret * 12);
                Console.WriteLine($"Toplam Tutar:{toplamSonuc}");
                Console.Write("Aylık veya Yıllık Ödeme Yapmak İstiyor musunuz ? A/Y:");
                char secim = Convert.ToChar(Console.ReadLine());
                if (secim == 'A')
                {
                    Console.WriteLine("Aylık Ödeme seçildi");
                    Console.WriteLine("Ödenmesi Gereken Tutar:{0}", toplamSonuc);
                }
                else if (secim == 'Y')
                {
                    Console.WriteLine("Yıllık Ödeme Seçildi");
                    int yillikOdeme = toplamSonuc / 100 * 20;//yüzde 20 indirim
                    toplamSonuc -= yillikOdeme;
                    Console.WriteLine($"İndirimli Odemniz Gereken Tutar: {toplamSonuc}");
                }
                else { Console.WriteLine("hata"); }

            }
        }



    }
}
