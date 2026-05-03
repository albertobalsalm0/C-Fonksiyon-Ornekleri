using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ile ilgili fonksiyonklar//

            Console.WriteLine("Merhaba Dünya!"); //ekrana yazı yazar

            string girdi = Console.ReadLine(); //metin girdisi alır

            int sayi = int.Parse("42"); //metni tam sayıya dönüştürür

            string buyuk = "merhaba".ToUpper(); //metni büyük harfe çevirir

            string metin = sayi.ToString(); //sayıyı metne çevirir

            int donusturulen = Convert.ToInt32("100"); // değeri tam sayıya çevirir

            string yeni = "Merhaba Dünya".Replace("Dünya", "C#"); //metin içerisinde kelimeleri değiştirir

            string[] parcalar = "elma,armut,kiraz".Split(','); //metni böler dizi haline getirir

            string birlesik = string.Join(" - ", parcalar); //dizi elemanlarını birleştirip tek bir metin yapar

            string temiz = "   boşluk var   ".Trim(); // baş ve sonlardaki boşlukları siler

            bool varMi = "Ankara Türkiye".Contains("Türkiye"); // metin içerisinde kelime bulunuyor mu kontrol eder



            // LINQ, diziler veya listeler üzerinde sorgulama veya ayıklama yapan fonksiyonlar

            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 5, 6 };

            var ciftler = sayilar.Where(x => x % 2 == 0); // Şarta uyan elemanları filtreler

            var kareler = sayilar.Select(x => x * x); // elemanların formatını değiştirir

            bool ondan = sayilar.Any(x => x > 5); //Şarta uyan bir eleman var mı kontrol eder

            var sirali = sayilar.OrderBy(x => x); //Küçükten büyüğe sıralama yapar

            var tekSizler = sayilar.Distinct(); //tekrar eden elemanları temizler


            // Matematik ve Zaman fonksiyonları

            double yuvarlak = Math.Round(4.6); // Ondalıklı sayıyı yuvarlar

            int enBuyuk = Math.Max(10, 25); // en büyük değeri seçer
            int enKucuk = Math.Min(10, 25); // en küçük değeri seçer

            DateTime simdi = DateTime.Now; // sistemin güncel tarih ve saatini alır

            DateTime gelecek = simdi.AddDays(7); // Tarihe gün ekler
            DateTime sonrakiay = simdi.AddMonths(1); //Tarihe ay aekler



            // Dosya ve Sistem Yönetimi

            File.WriteAllText("test.txt", "Merhaba Dosya!"); // dosyayı açar içine betin yazabilir ve dosyayı kapatabilir

            string[] satirlar = File.ReadAllLines("test.txt"); // Dosyadaki tüm satırları diziye aktarır

            bool klasorVar = Directory.Exists("C:\\Windows"); //belirtilen klasörün olup olmadığını kontrol eder

            string yol = Path.Combine("C:\\Kullanici", "Belgeler", "dosya.txt"); // Farklı klasör yollarını işletim sistemine uygun şekilde birleştirir

            Task.Run(() =>
                {
                    Console.WriteLine("arka planda çalışıyor");
                }); // bir işi ana plandan arka planda çalışmaya aktarır



            // fonksiyon çıktıları

            Console.WriteLine($"ToUpper     : {buyuk}");
            Console.WriteLine($"Replace     : {yeni}");
            Console.WriteLine($"Join        : {birlesik}");
            Console.WriteLine($"Contains    : {varMi}");
            Console.WriteLine($"Any         : {ondan}");
            Console.WriteLine($"Round       : {yuvarlak}");
            Console.WriteLine($"Max / Min   : {enBuyuk} / {enKucuk}");
            Console.WriteLine($"DateTime    : {simdi}");
            Console.WriteLine($"+7 gün      : {gelecek.ToShortDateString()}");
            Console.WriteLine($"Path        : {yol}");
            Console.WriteLine($"Dir Exists  : {klasorVar}");

            Console.ReadKey();





        }
    }
}
