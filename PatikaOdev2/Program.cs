using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Soru
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            ArrayList sayilar= new ArrayList();
            ArrayList asalListe = new ArrayList();
            ArrayList asalOListe = new ArrayList();
            int kontrol = 0;
            Console.WriteLine("Sayı Girin : ");
            for (int i = 0; i < 20; i++)
            { 
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Pozitif tam sayı giriniz.");
                    }

                    else
                    {
                        sayilar.Add(n);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Veri tipi uygun değil. Girilen deger bir sayi olmalidir.");
                }
            }

            foreach (var sayi in sayilar)
            {
                int isayi =Convert.ToInt32(sayi.ToString());
                for (int i = 2; i < isayi; i++)
                {
                    if (isayi % i == 0)
                        kontrol++;
                }

                if (kontrol != 0)
                    asalOListe.Add(isayi);
                else
                    asalListe.Add(isayi);

            }
            asalListe.Sort();
            asalOListe.Sort();
            asalListe.Reverse();
            asalOListe.Reverse();
            int asalListeToplam = 0;
            int asalOListeToplam = 0;

            foreach(var asal in asalListe)
            {
                Console.WriteLine(asal.ToString());
                asalListeToplam += int.Parse(asal.ToString());
            }
                
            foreach ( var asalO in asalOListe)
            {
                Console.WriteLine(asalO.ToString());
                asalOListeToplam += int.Parse(asalO.ToString());
            }

            Console.WriteLine("Asal olanların Eleman sayısı= {0} ve Ortalaması {1}", asalListe.Count, asalListeToplam / asalListe.Count);
            Console.WriteLine("Asal olmayanların Eleman sayısı= {0} ve Ortalaması {1}", asalOListe.Count, asalOListeToplam / asalOListe.Count);


            Console.ReadKey();
        }
        
    }
}
