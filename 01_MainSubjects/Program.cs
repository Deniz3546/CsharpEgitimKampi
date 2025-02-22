using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Merhaba Dunya");
            //Console.WriteLine("Selam");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-içecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //string name;
            //name = "Deniz";
            //Console.Write(name);
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 400 300 3020";
            //customerEmail = "deneme@gmail.com";
            //district = "kadıköy";
            //city = "istanbul";
            //Console.WriteLine("***** Rezervasyon kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");
            //customerName = "Ayşe";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 400 3020";
            //customerEmail = "test@gmail.com";
            //district = "sapanca";
            //city = "sakarya";
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("***** Restoran menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice+ " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice+ " TL");
            Console.WriteLine("----Kola: " + cokePrice+ " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice+ " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine("----kızartma: " + friesPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran menü Fiyatı *****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;
            int totalCokePrice = cokePrice * cokeCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalFriesPrice = friesPrice * friesCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalLemonadePrice = lemonadePrice * lemonadeCount;
            int totalhamburgerPrice = hamburgerPrice * hamburgerCount;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutari: " + totalhamburgerPrice + " TL");
            Console.WriteLine("pizza Tutari: " + totalPizzaPrice + " TL");
            Console.WriteLine("kola Tutari: " + totalCokePrice + " TL");
            Console.WriteLine("su Tutari: " + totalWaterPrice + " TL");
            Console.WriteLine("Limonata Tutari: " + totalLemonadePrice + " TL");
            Console.WriteLine("kızartma Tutari: " + totalFriesPrice + " TL");
           
            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalhamburgerPrice;
            Console.WriteLine("Toplam Tutar: " + totalPrice);
            Console.Read();
        }
    }
}
