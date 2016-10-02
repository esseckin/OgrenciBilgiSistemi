using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
      static Ogrencii[] ogrenci = new Ogrencii[2];
       
        static void Main(string[] args)
        {
            char secim=' ';

         
            menu:  Console.Clear();
    Console.WriteLine("a.Ogrenci Girişi\n"+"b.Not girişi\n"+"c.Sınıf Listesi\n"+"d.Not Listesi\n"
         + "e.Ogrenci notu sorgulama\n" + "f.Sınıf basarı durumu\n" + "g.Cıkıs\n" +
          "Lütfen islem yapmak istediğiniz secenegi giriniz.: ");
        
              secim=Convert.ToChar(Console.ReadLine());
                tekrar: 
              
              switch (secim)
            {
                case 'a':
                    KisiKayit();
                    
                    break;
                case 'b':
                    notGirisi();

                    break;
                case 'c':
                     sınıfListele();

                    break;
                case 'd':
                    notListele();
                    
                    break;
                case 'e':
                    OgrenciNotuSorgulama();
                    break;
                case 'f':
                    BasarıDurumu();
                    break;
                case 'g':
                    Environment.Exit(1);
                    break;
                default: Console.WriteLine("yanlıs secim ");break; goto tekrar;
                    
            }
                Console.WriteLine("devam etmek icin bir tusa bas");
                Console.ReadKey();
                goto menu;
         
         
        }

        public static void KisiKayit()
        {
            bool durum = false;
            int no = 0;
            for (int i = 0; i < ogrenci.Length; i++)
            {
                ogrenci[i]=new Ogrencii();
            basadon:  Console.WriteLine((i + 1) + ". kisinin ogrenci numarasini giriniz:");
                no = Convert.ToInt32(Console.ReadLine());
               durum = ogrenciKontrol(no,i);
               if (durum)
               {
                   ogrenci[i].ogr_no = no;
               }
               else {
                   Console.WriteLine("kayitli bi numara girdiniz tekrar deneyin");
                   goto basadon;
               }
  
                Console.WriteLine((i+1)+". kisinin adini giriniz:");
                ogrenci[i].ad = Console.ReadLine();
                Console.WriteLine((i + 1) + ". kisinin soyadini giriniz:");
                ogrenci[i].soyad = Console.ReadLine();
                
                Console.WriteLine((i+1)+". kisinin kaydı yapıldı."); 
            }
        }

        static bool ogrenciKontrol(int no, int kayitsayisi)
        {
            if (kayitsayisi != 0)
            {
                for (int i = 0; i < ogrenci.Length; i++)
                {
                    if (ogrenci[i].ogr_no == no)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        static void sınıfListele() {
            for (int i = 0; i < ogrenci.Length; i++)
            {
                Console.WriteLine((i+1)+". ogrencinin bilgileri--> "+ogrenci[i]); 
            }
        }
        static void notListele()
        {
            for (int i = 0; i < ogrenci.Length; i++)
            {
                Console.WriteLine((i + 1) + ". ogrencinin vize notu : " + ogrenci[i].vize + " final notu:" + ogrenci[i].final);
            }
        }
        static void notGirisi() 
        {
            for (int i = 0; i < ogrenci.Length; i++)
            {
                Console.WriteLine((i+1)+". ögrencinin vize notunu giriniz");
                ogrenci[i].vize=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((i + 1) + ". ögrencinin final notunu giriniz");
                ogrenci[i].final = Convert.ToInt32(Console.ReadLine());

                
            }
            Console.WriteLine("notlar basarıyla alındı..");
        
        }
        static void OgrenciNotuSorgulama()
        {
            int girdi=0;
            for (int i = 0; i < ogrenci.Length; i++)
            {
                Console.WriteLine("Hangi ogrencinin notunu sorgulatmak istiyorsun?(1-{0})",ogrenci.Length);
                 girdi = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine(girdi + ". ogrencin vize notu : " + ogrenci[girdi].vize + " final notu :" + ogrenci[girdi].final); 

        }
        static void BasarıDurumu() 
        { 
            for (int i = 0; i < ogrenci.Length; i++)
            {
                ogrenci[i].Ortalamahesap();
                if (ogrenci[i].ortalama >= 70) {
                    ogrenci[i].durum = "GECTINIZ";
                }
                else
                  ogrenci[i].durum="KALDINIZ";


                Console.WriteLine((i+1)+". ogrencinin basarı durumu"+ogrenci[i].durum);
            }
            }
        }

    }
