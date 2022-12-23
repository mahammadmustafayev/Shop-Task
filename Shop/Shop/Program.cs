using Shop.Models;
using System;
namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xosh Gelmisiniz");
            Bread bread = new Bread();
            Soups soups = new Soups();
            int choise;
            do
            {
                Console.WriteLine("Secim Edin:");
                Console.WriteLine("\t 1-Admin ");
                Console.WriteLine("\t 2-Customer");
                Console.WriteLine("\t 3-Cixis");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        char secim;
                            
                        do
                        {
                            Console.WriteLine("\t A-Corek Ucun ");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("\t B-Souplar Ucun ");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("\t Cixis ucun 'E' yazin");
                            Console.WriteLine("----------------------------");
                            secim =Convert.ToChar(Console.ReadLine().ToUpper());
                            switch (secim)
                            {
                                case 'A':
                                    //Bread bread = new Bread();
                                    Console.WriteLine("Productun Adini Daxil Edin:");
                                    bread.productname = Console.ReadLine();
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun Sayini Daxil Edin:");
                                    bread.productcount = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Product Haqqinda qisa melumat Daxil Edin:");
                                    bread.productdescription = Console.ReadLine();
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun son istifade  gunu");
                                    bread.productdeadday=Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun son istifade  ayi");
                                    bread.productdeadmonth=Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun son istifade  ili");
                                    bread.productdeadyear=Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun Istifade Yerini daxil edin");
                                    bread.useplace = Console.ReadLine();
                                    Console.WriteLine("--------------------------------");
                                    break;
                                case 'B':
                                    //Soups soups =new Soups();
                                    Console.WriteLine("Productun Adini Daxil Edin:");
                                    soups.productname = Console.ReadLine();
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun Sayini Daxil Edin:");
                                    soups.productcount = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Product Haqqinda qisa melumat Daxil Edin:");
                                    soups.productdescription = Console.ReadLine();
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun son istifade  gunu");
                                    soups.productdeadday = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun son istifade  ayi");
                                    soups.productdeadmonth = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun son istifade  ili");
                                    soups.productdeadyear = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Productun Istifade Yerini daxil edin");
                                    soups.useplace = Console.ReadLine();
                                    Console.WriteLine("--------------------------------");
                                    break;
                            }
                        } while (secim != 'E');
                        break;
                    case 2:
                        char secimshop;
                        do
                        {
                            Console.WriteLine("\t B- Corek Ucun");
                            Console.WriteLine("\t S- Souplar Ucun");
                            Console.WriteLine("\t E- Cixis Ucun");
                            secimshop = Convert.ToChar(Console.ReadLine().ToUpper());
                            switch (secimshop)
                            {
                                case 'B':
                                    Console.WriteLine($"Productun Adi:{bread.productname} ve Sayi:{bread.productcount}");
                                    int choisebread;
                                    do
                                    {
                                        Console.WriteLine("\t 1-ShowInfo");
                                        Console.WriteLine("\t 2-Buy");
                                        Console.WriteLine("\t 3-Cixis");
                                        choisebread= Convert.ToInt32(Console.ReadLine());
                                        switch (choisebread)
                                        {
                                            case 1:
                                                bread.ShowInfo();
                                                break;
                                            case 2:
                                                bread.Buy();
                                                break;
                                            default:
                                                Console.WriteLine("Bele Secim Yoxdur");
                                                break;
                                        }
                                    } while (choisebread !=3);
                                    break;
                                case 'S':
                                    Console.WriteLine($"Productun Adi:{soups.productname} ve Sayi:{soups.productcount}");
                                    int choisesoup;
                                    do
                                    {
                                        Console.WriteLine("\t 1-ShowInfo");
                                        Console.WriteLine("\t 2-Buy");
                                        Console.WriteLine("\t 3-Cixis");
                                        choisesoup = Convert.ToInt32(Console.ReadLine());
                                        switch (choisesoup)
                                        {
                                            case 1:
                                                soups.ShowInfo();
                                                break;
                                            case 2:
                                                soups.Buy();
                                                break;
                                            default:
                                                Console.WriteLine("Bele Secim Yoxdur");
                                                break;
                                        }
                                    } while (choisesoup != 3);
                                    break;
                                default:
                                    //Console.WriteLine("Bele Secim Yoxdur");
                                    break;
                            }
                        } while (secimshop != 'E');
                        break;
                        case 3:
                        Console.WriteLine("Saqolun");
                        break;
                    default:
                        Console.WriteLine("Bele Secim Yoxdur");
                        break;
                }
            } while (choise !=3);
        }
    }
}