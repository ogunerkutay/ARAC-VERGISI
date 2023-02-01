using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARAC_VERGISI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aracturu;
            int motorhacmi = 0, aracinyasi = 0;
            double vergi = 0;
            
            do
            {
                Console.WriteLine("Lütfen aracınızın türünü giriniz. binek / ticari");
                aracturu = Console.ReadLine();
                Console.WriteLine("Lütfen aracınızın yaşını giriniz.");
                aracinyasi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen aracınızın motor hacmini giriniz(litre olarak).");
                motorhacmi = Convert.ToInt32(Console.ReadLine());



                if (aracturu == "binek")
                {
                    vergi = 100;
                    if (aracinyasi>=1 && aracinyasi<=3)
                    {
                        vergi = vergi * 1.75;

                        if (motorhacmi >= 0 && motorhacmi <= 1300)
                        {
                            vergi = vergi * 2;
                        }
                        else if (motorhacmi > 1300 && motorhacmi <= 1600)
                        {
                            vergi = vergi * 3;
                        }
                        else if (motorhacmi > 1600 && motorhacmi <= 2000)
                        {
                            vergi = vergi * 4;
                        }
                        else if (motorhacmi > 2000)
                        {
                            vergi = vergi * 5;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen motor hacminiz için pozitif bir sayı giriniz.");
                        }
                    }
                    else if (aracinyasi >3 && aracinyasi <= 7)
                    {
                        vergi = vergi * 1.5;
                        if (motorhacmi >= 0 && motorhacmi <= 1300)
                        {
                            vergi = vergi * 2;
                        }
                        else if (motorhacmi > 1300 && motorhacmi <= 1600)
                        {
                            vergi = vergi * 3;
                        }
                        else if (motorhacmi > 1600 && motorhacmi <= 2000)
                        {
                            vergi = vergi * 4;
                        }
                        else if (motorhacmi > 2000)
                        {
                            vergi = vergi * 5;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen motor hacminiz için pozitif bir sayı giriniz.");
                        }
                    }
                    else if (aracinyasi > 7)
                    {
                        vergi = vergi * 1.25;
                        if (motorhacmi >= 0 && motorhacmi <= 1300)
                        {
                            vergi = vergi * 2;
                        }
                        else if (motorhacmi > 1300 && motorhacmi <= 1600)
                        {
                            vergi = vergi * 3;
                        }
                        else if (motorhacmi > 1600 && motorhacmi <= 2000)
                        {
                            vergi = vergi * 4;
                        }
                        else if (motorhacmi > 2000)
                        {
                            vergi = vergi * 5;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen motor hacminiz için pozitif bir sayı giriniz.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen aracınızın yaşı için pozitif bir sayı giriniz.");
                    }

                }
                else if (aracturu == "ticari")
                {
                    vergi = 150;
                    if (aracinyasi >= 1 && aracinyasi <= 3)
                    {
                        vergi = vergi * 1.75;

                        if (motorhacmi >= 0 && motorhacmi <= 1300)
                        {
                            vergi = vergi * 2;
                        }
                        else if (motorhacmi > 1300 && motorhacmi <= 1600)
                        {
                            vergi = vergi * 3;
                        }
                        else if (motorhacmi > 1600 && motorhacmi <= 2000)
                        {
                            vergi = vergi * 4;
                        }
                        else if (motorhacmi > 2000)
                        {
                            vergi = vergi * 5;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen motor hacminiz için pozitif bir sayı giriniz.");
                        }
                    }
                    else if (aracinyasi > 3 && aracinyasi <= 7)
                    {
                        vergi = vergi * 1.5;
                        if (motorhacmi >= 0 && motorhacmi <= 1300)
                        {
                            vergi = vergi * 2;
                        }
                        else if (motorhacmi > 1300 && motorhacmi <= 1600)
                        {
                            vergi = vergi * 3;
                        }
                        else if (motorhacmi > 1600 && motorhacmi <= 2000)
                        {
                            vergi = vergi * 4;
                        }
                        else if (motorhacmi > 2000)
                        {
                            vergi = vergi * 5;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen motor hacminiz için pozitif bir sayı giriniz.");
                        }
                    }
                    else if (aracinyasi > 7)
                    {
                        vergi = vergi * 1.25;
                        if (motorhacmi >= 0 && motorhacmi <= 1300)
                        {
                            vergi = vergi * 2;
                        }
                        else if (motorhacmi > 1300 && motorhacmi <= 1600)
                        {
                            vergi = vergi * 3;
                        }
                        else if (motorhacmi > 1600 && motorhacmi <= 2000)
                        {
                            vergi = vergi * 4;
                        }
                        else if (motorhacmi > 2000)
                        {
                            vergi = vergi * 5;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen motor hacminiz için pozitif bir sayı giriniz.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen aracınızın yaşı için pozitif bir sayı giriniz.");
                    }

                }
                else
                {
                    Console.WriteLine("Lütfen aracınızın türünü sadece 'binek' veya 'ticari' olarak giriniz.");
                }
                if (vergi > 0)
                {
                    Console.WriteLine("Verginiz: " + vergi);
                }
            } while (true);



        }
    }
}
