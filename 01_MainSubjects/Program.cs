using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            Console.WriteLine("Merhaba, Dünya");
            Console.WriteLine("Selam");

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");


            #endregion

            #region Değişkenler

            //string name;
            //name = "Hira";
            //Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Hiranur";
            customerSurname = "Sazak";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "hira64@gmail.com";
            district = "Merkez";
            city = "Uşak";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine();

            customerName = "Rümeysa";
            customerSurname = "Ağlar";
            customerPhone = "+90 500 440 30 20";
            customerEmail = "rüm64@gmail.com";
            district = "Üsküdar";
            city = "İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);

            Console.WriteLine("--------------------------------------");


            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int cokePrice = 35;
            int lemonadePrice = 30;
            int friesPrice = 50;
            int waterPrice = 10;

            Console.WriteLine("**** Restoran Menü Fiyat Listesi ****");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hamburger: " + hamburgerPrice + "₺");
            Console.WriteLine("Pizza: " + pizzaPrice + "₺");
            Console.WriteLine("Kola: " + cokePrice + "₺");
            Console.WriteLine("Limonata: " + lemonadePrice + "₺");
            Console.WriteLine("Kızartma: " + friesPrice + "₺");
            Console.WriteLine("Su: " + waterPrice + "₺");
            Console.WriteLine("**** Restoran Menü Fiyat Listesi ****");
            Console.WriteLine();

            int hamburgerCount = 3;
            int pizzaCount = 0;
            int cokeCount = 3;
            int lemonadeCount = 0;
            int friesCount = 1;
            int waterCount = 3;

            int totalHamburgerPrice = 0;
            int totalPizzaPrice = 0;
            int totalCokePrice = 0;
            int totalLemonadePrice = 0;
            int totalFriesPrice = 0;
            int totalWaterPrice = 0;
            int totalPrice = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalCokePrice = cokePrice * cokeCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalFriesPrice = friesPrice * friesCount;
            totalWaterPrice = waterPrice * waterCount;
            totalPrice = totalHamburgerPrice + totalPizzaPrice + totalCokePrice + totalLemonadePrice + totalFriesPrice + totalWaterPrice;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "₺");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "₺");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "₺");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "₺");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "₺");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "₺");
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "₺");

            Console.Read();

            #endregion
        }
    }
}
