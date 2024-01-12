using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Standart_Sapma_Recursive
{
     public  class Standart_Sapma_Recursive
    {

        public static double[] dizi ;
        public static double[] dizi1;

        static void Main(string[] args)
        {
            Console.WriteLine("Kaç değer gireceksiniz?");
            int m = int.Parse(Console.ReadLine());
            dizi = new double[m];
            dizi1 = new double[m];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(i + 1 + ". değeri giriniz");
                dizi[i] = Convert.ToDouble(Console.ReadLine());
                toplam += dizi[i];
            }
            
            Console.WriteLine(StandartSapma(dizi[0]));

            Console.ReadKey();
        }
        public static double toplam = 0, carpan1, carpan2 = 0, mean, varyans, S_sapma;
        public static int k = 0;
        public static double StandartSapma(double deger)
        {
            mean = toplam / dizi.Length;
            if (k <= dizi.Length)
            {
                k++;
                dizi1[k-1] = (deger - mean)*(deger-mean);
                
            }
            if(k<=dizi.Length-1)
            {
                StandartSapma(dizi[k]);
                
            }
            

            for (int j=0; j<dizi1.Length;j++)
            { 
            carpan2 += dizi1[j];
            }
            carpan1 = (k-1)/Math.Pow(k-1,2);
            varyans = carpan1 * carpan2;
            S_sapma = Math.Sqrt(varyans);
            k++;
            return S_sapma;           
        }        
    }
}
//H.TNG
