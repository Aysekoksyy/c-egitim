//Console.WriteLine("Hello, World!");
//yorum satırı için satırı seç cmd+k cmd+c yap
internal class Program
{
    static void Main(string[] args)
    {
        #region yazdırmakomutları
        // Console.Write("Merhaba Dünya");

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

        #region stringDegiskenler

        string name;
        name = "Ayşe";
        Console.WriteLine(name);

        string customerName;
        string customerSurname;
        string customerPhone;
        string customerEmail, district , city;

        customerName = "Cemal";
        customerSurname = "Karslı";
        customerPhone = "+90 553 218 93 77";
        customerEmail = "cemal1907@gmail.com";
        district = "Mimsin";
        city = "Kayseri";
        
        Console.WriteLine("**** Rezervasyon Kart ****");
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Müşeri:  " + customerName + " " + customerSurname);
        Console.WriteLine("İletişim: " + customerPhone );
        Console.WriteLine("Email Adresi: " +customerEmail );
        Console.WriteLine("Adres: " + district + "/" +city);
        Console.WriteLine("------------------------------------------------");

        customerName = "Ayşe";
        customerSurname = "Köksoy";
        customerPhone = "+90 537 050 73 15";
        customerEmail = "akoksoy8@icloud.com";
        district = "Merkez";
        city = "Nevşehir";
        Console.WriteLine("Müşeri:  " + customerName + " " + customerSurname);
        Console.WriteLine("İletişim: " + customerPhone );
        Console.WriteLine("Email Adresi: " +customerEmail );
        Console.WriteLine("Adres: " + district + "/" +city);
        Console.WriteLine("------------------------------------------------");
        
        #endregion

        #region IntDegiskenler

        int number = 24;
        Console.WriteLine(number);

        int hamburgerPrice = 300;
        int cokePrice = 35;
        int waterPrice = 10;
        int friesPrice = 50;
        int pizzaPrice = 250;
        int lemonadePrice = 30;
        
        Console.WriteLine("**** Menü Fiyat ****");
        Console.WriteLine();
        Console.WriteLine("-----:Hamburger Fiyatı:: "+hamburgerPrice+ "TL" );
        Console.WriteLine("-----:Pizza: "+pizzaPrice+"TL");
        Console.WriteLine("-----:Kola: "+cokePrice+"TL");
        Console.WriteLine("-----:Limonata: "+lemonadePrice+"TL");
        Console.WriteLine("-----:Su "+waterPrice+"TL");
        Console.WriteLine();
        Console.WriteLine("**** Menü Fiyat ****");
        
        Console.WriteLine();
        int hamburgerCount;
        int cokeCount;
        int waterCount;
        int friesCount;
        int pizzaCount;
        int lemonadeCount;
        
        int totalHamburgerPrice = 0;
        int totalCokePrice = 0;
        int totalWaterPrice = 0;
        int totalFriesPrice = 0;
        int totalPizzaPrice = 0;
        int totalLemonadePrice = 0;
        int totalPrice = 0;
        
        hamburgerCount = 3;
        cokeCount = 3;
        waterCount = 3;
        friesCount = 1;
        pizzaCount = 0;
        lemonadeCount = 0;
        totalHamburgerPrice = hamburgerCount * hamburgerPrice;
        totalCokePrice = cokePrice * cokeCount;
        totalWaterPrice = waterPrice * waterCount;
        totalFriesPrice = friesCount * friesPrice;
        totalPizzaPrice = pizzaPrice * pizzaCount;
        totalLemonadePrice = lemonadePrice * lemonadeCount;
        totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice +
                     totalLemonadePrice;
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Hamburger Tutarı: "+ totalHamburgerPrice +"TL");
        Console.WriteLine("Kola Tutarı: "+ totalCokePrice +"TL");
        Console.WriteLine("Su Tutarı: "+ totalWaterPrice +"TL");
        Console.WriteLine("Kızartma Tutarı: "+ totalFriesPrice+"TL");
        Console.WriteLine("Pizza Tutarı: "+ totalPizzaPrice+ "TL");
        Console.WriteLine("limonata Tutarı: "+ totalLemonadePrice+ "TL");
        Console.WriteLine();
        Console.WriteLine("Toplam Hesap Tutarı: "+ totalPrice+"TL");

        #endregion
        Console.Read();
    }
}