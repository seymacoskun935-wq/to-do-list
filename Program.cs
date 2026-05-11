using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {

        static List<Gorev> islemler = new List<Gorev>();
        static void gorevEkle()
        {
           
           

            Console.WriteLine("Eklemek istediğiniz görevi girin: ");
             string gorev = Console.ReadLine();

            Gorev yenigorev = new Gorev(gorev );
            islemler.Add(yenigorev);

            

           
           
        }
        static void gorevListele()
        {
            for (int i = 0; i < islemler.Count; i++)
            {
                if (islemler[i].Tamamlandi)
                {
                    Console.WriteLine((i+1)+ ". [X] " + islemler[i].Ad + " - tamamlandı");
                }
                else
                {
                    Console.WriteLine((i+1) + ". [ ] "+ islemler[i].Ad);
                }
                Console.WriteLine(islemler[i].Ad + " - " + islemler[i].Tarih);
            }
            
        }

        static void gorevTamamla()
        {
            Console.WriteLine("Tamamladığınız görevin numarasını girin");

            int tg;

            if (!int.TryParse(Console.ReadLine(), out tg))
            {
                Console.WriteLine("Sayı girmeniz lazım!");
                return;
            }


            if (tg <=0 || tg > islemler.Count)
            {
                Console.WriteLine("Geçersiz numara");
                return;
            }

            islemler[tg - 1].Tamamlandi = true;
            Console.WriteLine("Görev tamamlandı");


        }
        static void GorevSil()
        {
            Console.WriteLine("Silmek istediğiniz görevin numarasını giriniz: ");
          

            int sil;

            if (!int.TryParse(Console.ReadLine(), out sil)) 
            {
                Console.WriteLine("Sayı girmeniz lazım!");
                return;
            }


            if (sil <= 0 || sil > islemler.Count)
            {
                Console.WriteLine("Geçersiz numara");
                return;
            }

            
            islemler.RemoveAt(sil - 1);
            

        }
        static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Yapmak istediğiniz işlemin numarasını giriniz: 1- Görev ekle, 2- Görevleri listele, 3- Görev tamamla,  4-Çıkış , 5-Görev sil, 6-Tüm görevleri sıfırla");
                    int islem;
                if (!int.TryParse(Console.ReadLine(), out islem))
                {
                    Console.WriteLine("Sayı girmeniz lazım!");
                    return;
                   
                }


                    switch (islem)
                    {
                        case 1:
                            gorevEkle();
                            break;
                        case 2:
                            gorevListele();
                            break;                      
                        case 3:
                            gorevTamamla();
                            break;
                        case 4:
                            Console.WriteLine("Çıkış yapıldı");
                            return;
                        case 5:
                             GorevSil();
                             break;
                        case 6:
                        Console.WriteLine("Görevler sıfırlandı..");
                            islemler.Clear();
                            break;
                        default:
                            Console.WriteLine("Hatalı işlem");
                           break;

                    }

                }


        }



        
    }
}
