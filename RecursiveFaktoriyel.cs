using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_for_Faktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyelini hesapmalak istediğiniz değeri giriniz");
            double n=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(n + "' in faktöriyeli = " + Faktoriyel(n));
            Console.ReadKey();
        }
        public static double Faktoriyel(double n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n*Faktoriyel(n-1);
            }
        }
    }
}
//H.TNG
