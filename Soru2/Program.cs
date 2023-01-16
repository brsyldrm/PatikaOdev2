using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int[] enKucuk = new int[3];
            int[] enBuyuk = new int[3];
            int enKucuklerToplam = 0;
            int enBuyuklerToplam = 0;

            for (int i = 0; i < 20; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = n;
            }

            Array.Sort(sayilar);
            for (int j = 0; j < 3; j++)
            {
                enKucuk[j] = sayilar[j];
                enKucuklerToplam += enKucuk[j];
            }
            Console.WriteLine("En küçük sayılar:" +
            enKucuk[0] + "," + enKucuk[1] + "," + enKucuk[2]);


            Array.Reverse(sayilar);
            for (int x = 0; x < 3; x++)
            {
                enBuyuk[x] = sayilar[x];
                enBuyuklerToplam += enBuyuk[x];
            }
            Console.WriteLine("En büyük sayılar:" +
            enBuyuk[0] + "," + enBuyuk[1] + "," + enBuyuk[2]);


            Console.WriteLine("En kücük 3 sayının ortalaması: " + enKucuklerToplam / 3);
            Console.WriteLine("En büyük 3 sayının ortalaması: " + enBuyuklerToplam / 3);
            Console.WriteLine("Ortalamalar toplamı: " + ((enKucuklerToplam / 3) + (enBuyuklerToplam / 3)));
        }
    }
}
