using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_Sapma_Iterative
{
    internal class Standart_Sapma_İterative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet değer gireceksiniz?");
            int s=Convert.ToInt16(Console.ReadLine());
            double [] dizi = new double[s];
            double toplam = 0, varyans, carpan2 = 0,S_sapma;
            for(int i = 0; i < s; i++)
            {
                Console.WriteLine(i + 1 + " . değeri giriniz:");
                dizi[i] = Convert.ToDouble(Console.ReadLine());
                toplam += dizi[i];
            }
            double mean = toplam / s;
            double carpan1 =  (s - 1)/Math.Pow((s-1),2);

            for(int i = 0; i < s;i++)
            {
                carpan2 += (double)Math.Pow(Math.Abs(dizi[i]-mean),2);
            }
            varyans = carpan1 * carpan2;
            S_sapma = (double)Math.Sqrt(varyans);
            Console.WriteLine(S_sapma);


            Console.ReadKey();
        }
    }
}
//H.TNG
