using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000;

            Console.WriteLine("Bakiyeniz : " + bakiye);
            Console.WriteLine("1. Para Çekme");
            Console.WriteLine("2. Para Yatırma");
            Console.WriteLine("3. Bakiye Sorgulama");
            Console.WriteLine("4. Kart İade");
            menu:
            Console.WriteLine("Seçim Yapınız");
            int islem;
            islem = Convert.ToInt32(Console.ReadLine());
            

            switch (islem)
            {
                case 1:
                    Console.WriteLine("Bakiyeniz : " + bakiye);
                    Console.Write("Çekmek İstediğiniz Tutar: ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar > bakiye)
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        tutar = Convert.ToInt32(Console.ReadLine());
                    }
                    bakiye = bakiye - tutar;
                    Console.WriteLine("Yeni Bakiyeniz: " + bakiye);
                    
                    break;
                 case 2:
                    Console.WriteLine("Bakiyeniz: " + bakiye);
                    Console.Write("Yatırmak İstediğiniz Tutar: ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye = bakiye + tutar;
                    Console.WriteLine("Yeni Bakiyeniz: " + bakiye);
                    break;
                 case 3:
                    Console.WriteLine("Bakiyeniz: " + bakiye);
                    break;
                 case 4:
                    Console.WriteLine("Kartınız İade Ediliyor..!");
                    break;
            }
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("Ana Menüye Geçiliyor Lütfen Bekleyiniz");
            Thread.Sleep(500);
            goto menu;
        }
    }
}
