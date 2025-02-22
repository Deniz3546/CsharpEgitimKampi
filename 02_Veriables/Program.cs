using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    class Program
    {
        static void Main(string[] args)
        {
            //double number;
            //number = 4.88;
            //Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice,orangePrice,strawberryPrice,tomatoPrice,potatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("-----Elmanın Birim Fiyati: " + applePrice + " TL");
            //Console.WriteLine("-----portakal Birim Fiyati: " + orangePrice + " TL");
            //Console.WriteLine("-----Çilek Birim Fiyati: " + strawberryPrice + " TL");
            //Console.WriteLine("-----Domates Birim Fiyati: " + tomatoPrice + " TL");
            //Console.WriteLine("-----Patates Birim Fiyati: " + potatoPrice + " TL");
            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;
            //double appletotalPrice = applePrice * appleGram;
            //double orangetotalPrice = orangePrice * orangeGram;
            //double strawberrytotalPrice = strawberryPrice * strawberryGram;
            //double potatototalPrice = potatoPrice * potatoGram;
            //double tomatototalPrice = tomatoPrice * tomatoGram;
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün :Elma - " + "Birim Fiyat:" + applePrice + " -Gramaj: " + appleGram + " - Toplam Ürün Fiyat:" + appletotalPrice + " TL"); 
            //Console.WriteLine("Alınan Ürün :Portakal - " + "Birim Fiyat:" + orangePrice + " -Gramaj: " + orangeGram + " - Toplam Ürün Fiyat:" + orangetotalPrice + " TL"); 
            //Console.WriteLine("Alınan Ürün :Çilek - " + "Birim Fiyat:" + strawberryPrice + " -Gramaj: " + strawberryGram + " - Toplam Ürün Fiyat:" + strawberrytotalPrice + " TL"); 
            //Console.WriteLine("Alınan Ürün :Domates - " + "Birim Fiyat:" + tomatoPrice + " -Gramaj: " + tomatoGram + " - Toplam Ürün Fiyat:" + tomatototalPrice + " TL"); 
            //Console.WriteLine("Alınan Ürün :patates - " + "Birim Fiyat:" + potatoPrice + " -Gramaj: " + potatoGram + " - Toplam Ürün Fiyat:" + potatototalPrice + " TL"); 
            //double shoppingTotalPrice = appletotalPrice + orangetotalPrice + strawberrytotalPrice + potatototalPrice + tomatototalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Fiyat: " + shoppingTotalPrice + " TL");
            //char symbol = 'a';
            //Console.WriteLine(symbol);
            //Console.WriteLine("***** Csharp HavaYollari Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;
            //Console.Write("Yolcu Adi:");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadi:");
            //passengerSurname = Console.ReadLine();
            //Console.Write("ilçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş bilgisi: ");
            //passengerAge = Console.ReadLine();
            //Console.Write(" TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Yolcu Tc kimlik Numarasi: "+passengerIdentityNumber+  "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname   +  " " + passengerDistrict + "/" + passengerCity + " " + passengerAge); ;
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığın Ayakkabı Adedini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığın Bilgisayar Adedini Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığın Sandalye Adedini Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığın Televizyon Adedini Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalprice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Fiyat: " + totalprice + " TL");
            //double exam1, exam2, exam3, result;
            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //C/*onsole.WriteLi/*ne("Ortalama: " + result);*/*/
            char gender;
            Console.Write("Cinsiyetinizi Giriniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Girdiğiniz Cinsiyet: " + gender);
            Console.Read();
        }
    }
}
