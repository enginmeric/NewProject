using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Dortİslem
{
    class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            Console.Write("1. Sayıyı giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            dortislemsec:
            Console.Write("Seçiminizi yapınız?(Toplama:1,Çıkarma:2,Bölme:3,Çarpma:4)");
            char dortislemsec = Convert.ToChar(Console.ReadLine());
            switch (dortislemsec)
            {
                case '1':
                    dortislem toplamaislemi = new dortislem();
                    double toplam = toplamaislemi.topla(sayi1, sayi2);
                    Console.WriteLine("Toplama Sonucu : {0}" ,toplam);
                    break;

                case '2':

                    dortislem cikarmaislemi = new dortislem();
                    double fark = cikarmaislemi.cikar(sayi1, sayi2);
                    Console.WriteLine("Çıkarma Sonucu : {0}", fark);
                    break;

                case '3':

                    dortislem bolmeislemi = new dortislem();
                    double bolum = bolmeislemi.bolme(sayi1, sayi2);
                    Console.WriteLine("Bölme İşlemi Sonucu : {0}", bolum);
                    break;
                
                case '4':

                    dortislem carpmaislemi = new dortislem();
                    double carpma = carpmaislemi.carpma(sayi1, sayi2);
                    Console.WriteLine("Çarpma İşlemi Sonucu : {0}", carpma);
                    break;
                default:
                    Console.Clear();
                    Console.Write("Yanlış Seçim Yaptınız. Tekrar Deneyiniz");
                    goto dortislemsec;
                    
            }
            DEVAMSECİM:
            Console.Write("Yeniden İşlem Yapmak İstermisiniz? (EVET:E  HAYIR:H)");
            char devamsec = Convert.ToChar(Console.ReadLine());
            if (devamsec == 'E' || devamsec == 'e')
            {
                Console.Clear();
                goto BASADON;
            }
            else if (devamsec == 'H' || devamsec == 'h') 
            {
                Console.Write("İYİ GÜNLER...");

            }
            
            else
            {
                Console.Write("Yanlış bir tuşa bastınız . Tekrar deneyiniz..");
                goto DEVAMSECİM;
            }

                

            


        }
        class dortislem
        {
            public double topla(double s1, double s2)
            {
                return (s1 + s2);

            }
            public double cikar(double s1, double s2)
            {
                return (s1 - s2);
            }
            public double bolme (double s1, double s2)
            {
                return (s1 / s2);
            }
            public double carpma (double s1,double s2)
            {
                return (s1 * s2);
            }
            
            


            
            
       
        
        
        
        
        
        }   
        
            

        
        
    }
}
          
