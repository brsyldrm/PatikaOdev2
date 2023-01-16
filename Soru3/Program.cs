using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList sesliHarfler = new ArrayList();

            Console.WriteLine("Metni giriniz:");
            string cumle = Console.ReadLine();

            char[] cumleHarfleri = cumle.ToCharArray();

            int harfAdet = cumleHarfleri.Length;

            for(int i=0; i<harfAdet; i++)
            {
                if (cumleHarfleri[i]== 'I'|| cumleHarfleri[i] == 'ı' || cumleHarfleri[i] == 'İ' || cumleHarfleri[i] == 'i' 
                    || cumleHarfleri[i] == 'U' || cumleHarfleri[i] == 'u' || cumleHarfleri[i] == 'Ü' || cumleHarfleri[i] == 'ü'
                    || cumleHarfleri[i] == 'o' || cumleHarfleri[i] == 'O' || cumleHarfleri[i] == 'Ö' || cumleHarfleri[i] == 'ö' ||
                    cumleHarfleri[i] == 'E' || cumleHarfleri[i] == 'e' || cumleHarfleri[i] == 'A' || cumleHarfleri[i] == 'a')
                {
                    sesliHarfler.Add(cumleHarfleri[i]);
                }
            }

            foreach (var item in sesliHarfler)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
