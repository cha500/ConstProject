using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kategori k1 = new Kategori();

            //Console.WriteLine("---0-Boş 1-Bahçe 2-Ebeveyn Banyosu, 3-Şömine Hangisini Seçmek istersiniz---");


            Console.WriteLine("1.Daire - 2.Villa - 3.Müstakil - 4.Dubleks");
            Console.Write("Yapı Tipini Seçiniz:");
            int daireTuru = Convert.ToInt32(Console.ReadLine());
            switch (daireTuru)
            {

                case 0: //BOŞ
                    Console.WriteLine("Boş Seçim");
                    break;
                case 1: //Daire 
                    Console.WriteLine("Örneğin Güney,Kuzey");

                    Console.Write("Cepheyi giriniz:");
                    k1.Cephe = Console.ReadLine();

                    Console.Write("Kat Sayisini Giriniz:");
                    k1.KatSayisi = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Banyo Sayısını Giriniz:");
                    k1.BanyoSayisi = Convert.ToInt32(Console.ReadLine());

                    //AylikOdeme(k1.Cephe,k1.KatSayisi,k1.BanyoSayisi);

                    k1.AylikOdeme(k1.Cephe, k1.BanyoSayisi, k1.DaireDurum);


                    //k1.AylikOdeme(k1.Cephe,k1.BanyoSayisi,"aa");
                    break;

                case 2: //Villa
                    Console.WriteLine("Villa");
                    break;

                case 3:
                    Console.WriteLine("Müstakil");
                    break;
                case 4:
                    Console.WriteLine("Dubleks");

                    break;





                default:
                    break;
            }




            //Console.WriteLine("Örneğin Güney,Kuzey");

            //Console.Write("Cepheyi giriniz:");
            //k1.Cephe = Console.ReadLine();

            //Console.WriteLine("Kat Sayisini Giriniz:");
            //k1.KatSayisi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Banyo Sayısını Giriniz:");
            //k1.BanyoSayisi = Convert.ToInt32(Console.ReadLine());



            Console.ReadLine();


            //Ogrenciler ogr1 = new Ogrenciler();
            ////yapıcı method



            //Console.WriteLine("ogrenci no:"+ogr1.ogrno);
            //Console.WriteLine("Öğrenci adsyoad:"+ogr1.ogadsoyad);

            //Console.ReadLine();


            //Muhendislik m1 = new Muhendislik();

            //Console.WriteLine("Bölüm no giriniz");
            //m1.BolumNo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bölüm adi giriniz:");
            //m1.BolumAdi = Console.ReadLine();
            //Console.WriteLine("Hoca adi giriniz:");
            //m1.BolumHoca = Console.ReadLine();
            //Console.WriteLine("Kampüs giriniz:");
            //m1.BolumKampus = Console.ReadLine();

            //Console.Clear();


            //Console.WriteLine(" BolumNo no:" + m1.BolumNo);
            //Console.WriteLine(" BolumAdi:" + m1.BolumAdi);
            //Console.WriteLine(" BolumHoca:" + m1.BolumHoca);
            //Console.WriteLine(" BolumKampus:" + m1.BolumKampus);

            //Console.ReadLine();

            Mustakil mr = new Mustakil();
            

        }
    }
}
