using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hanoi_Kuleleri
{
    internal class Hanoi
    {
        static void Main(string[] args)
        {
            Islem islem = new Islem();
            Console.WriteLine("Disk sayısını giriniz:");
            int disc_size=int.Parse(Console.ReadLine());
            Console.WriteLine("Hangi direkteler:A=1/B=2/C=3 ");
            int konum=int.Parse(Console.ReadLine());
            Console.WriteLine("Hangi dereğe taşınacak");
            int hedef=int.Parse(Console.ReadLine());
            Console.WriteLine("Disk Sayısı ={0}\n Hamle Sayısı = {1}",disc_size,(Math.Pow(2,disc_size)-1));

            if (konum == 1 && hedef == 3)
            {
                islem.Adim(disc_size, (int)Cubuklar.A, (int)Cubuklar.C, (int)Cubuklar.B);
            }           
            else if (konum == 2 && hedef == 3)
            {
                islem.Adim(disc_size, (int)Cubuklar.B, (int)Cubuklar.C, (int)Cubuklar.A);
            }
            else if(konum == 3 &&hedef==2)
            {
                islem.Adim(disc_size, (int)Cubuklar.C, (int)Cubuklar.B, (int)Cubuklar.A);
            }
            else if(konum==1 && hedef == 2)
            {
                islem.Adim(disc_size, (int)Cubuklar.A, (int)Cubuklar.B, (int)Cubuklar.C);
            }
            else if(konum==2 && hedef==1)
            {
                islem.Adim(disc_size, (int)Cubuklar.B, (int)Cubuklar.A, (int)Cubuklar.C);
            }
            else 
            {
                islem.Adim(disc_size, (int)Cubuklar.C, (int)Cubuklar.A, (int)Cubuklar.B);
            }
            Console.ReadKey();
        }
    }
    //İşlem Sınıfı
    #region
    class Islem
    {
        public void Adim(int boyut, int hangi_direkten, int hangi_direğe, int hangi_Direk_Uzerinden)
        {
            if (boyut == 1) 
            {
                Console.WriteLine("{0} -> {1}",(Cubuklar)hangi_direkten,(Cubuklar)hangi_direğe);
            }
       
            else
            {
               Adim(boyut - 1, hangi_direkten, hangi_Direk_Uzerinden, hangi_direğe);
               Adim(1, hangi_direkten, hangi_direğe, hangi_Direk_Uzerinden);
               Adim(boyut - 1, hangi_Direk_Uzerinden, hangi_direğe, hangi_direkten);
            }
            Thread.Sleep(200);
            return;
          
        }
    }
    #endregion 

    enum Cubuklar
    {
        A=1,
        B=2,
        C=3
    }
    //H.TNG
    
}
