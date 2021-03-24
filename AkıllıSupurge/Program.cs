using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkıllıSupurge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Supurge= { "1.Alan", "2.Alan" };

            Random SupurgeSecilenAlan = new Random();
            int AlanSecim = SupurgeSecilenAlan.Next(0, Supurge.Length);
            Console.WriteLine();
            Console.WriteLine("Süpürgenin seçilen alanı= "+ Supurge[AlanSecim]);

            string[] Alan1 = { "Kirli", "Temiz", "Temiz", "Kirli" };
            Random Alan1Say = new Random();
            int AlanDurum1 = Alan1Say.Next(0,Alan1.Length);
            Console.WriteLine();
            Console.WriteLine("1.Alan= " + Alan1[AlanDurum1]);

            string[] Alan2 = { "Temiz", "Kirli", "Temiz", "Kirli" };
            Random Alan2Say = new Random();
            int AlanDurum2 = Alan2Say.Next(0, Alan2.Length);
            Console.WriteLine();
            Console.WriteLine("2.Alan= " + Alan2[AlanDurum2]);

            string[] Alan1KirlilikDurum = { "Sağdan", "Soldan", "Soldan", "Sağdan" };
            Random AlanKir1Say = new Random();
            int AlanDurum1Kir = Alan1Say.Next(0, Alan1.Length);


            string[] Alan2KirlilikDurum = { "Soldan", "Sağdan", "Soldan", "Sağdan" };
            Random AlanKir2Say = new Random();
            int AlanDurum2Kir = Alan1Say.Next(0, Alan1.Length);


            if (Supurge[AlanSecim] == "1.Alan")
            {
                if (Alan1[AlanDurum1] == "Temiz")
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Alan Zaten Temiz Durumda");
                }

                else if (Alan1[AlanDurum1] == "Kirli")
                {
                    Console.WriteLine("1.Alanı Temizle");
                    if (Alan1KirlilikDurum[AlanDurum1Kir] == "Sağdan")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Süpürge Dikey ve Yatay hareketler ile temizliğe bölgenin sağ tarafından başlayacaktır.  ");
                    }
                    else if (Alan1KirlilikDurum[AlanDurum1Kir] == "Soldan")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Süpürge Dikey ve Yatay hareketler ile temizliğe bölgenin sol tarafından başlayacaktır.  ");
                    }
                }
            }

            if (Supurge[AlanSecim] == "2.Alan")
            {
                if (Alan2[AlanDurum2] == "Temiz")
                {
                    Console.WriteLine();
                    Console.WriteLine("2.Alan Zaten Temiz Durumda");
                }

                else if (Alan2[AlanDurum2] == "Kirli")
                {
                    Console.WriteLine();
                    Console.WriteLine("2.Alanı Temizle");

                   
                    if (Alan2KirlilikDurum[AlanDurum2Kir] == "Sağdan")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Süpürge Dikey ve Yatay hareketler ile temizliğe bölgenin sağ tarafından başlayacaktır.  ");
                    }
                    else if (Alan2KirlilikDurum[AlanDurum2Kir] == "Soldan")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Süpürge Dikey ve Yatay hareketler ile temizliğe bölgenin sol tarafından başlayacaktır.  ");
                    }
                }
            }




            Console.ReadKey();


        }
    }
}
