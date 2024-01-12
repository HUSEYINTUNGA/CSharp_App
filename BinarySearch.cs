using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikili_Arama
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] a = { 27,21,20,55,42,63,23,215,420,6 };
            Array.Sort(a);
            Console.WriteLine("Dizi içerisinde aramak istediğiniz değeri giriniz");
            int aranan = Convert.ToInt16(Console.ReadLine());
            int ebuyuk = a.Length;
            int ekucuk = 0;
            int sayac = 0;
            while (ebuyuk - ekucuk > 1)
            {
                int ort = (ebuyuk + ekucuk) / 2;
                if (a[ort] == aranan)
                {
                   sayac = 1;
                    Console.Write("Aranan "+aranan+" elemanı, dizinin " + ort +". indisinde");
                    break;
                }
                else if (a[ort] < aranan)
                {
                    ekucuk = ort;
                }
                else
                {
                    ebuyuk = ort;
                }
                
            }
            if (sayac == 0)
            {
                Console.Write("Eleman dizi içerisinde bulunamadı!!");
            }
            Console.ReadKey();
        }
    }
}
