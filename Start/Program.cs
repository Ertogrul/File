using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Veri Girmek İçin 0'a, Verileri Görüntülemek İçin 1'e Basınız:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {


                FileStream fs1 = new FileStream("D:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw1 = new StreamWriter(fs1);
                string ad, soyad, yas, ogrenimdurumu, meslek, tel, adres;
                Console.Write("Adınız:");
                sw1.WriteLine(Console.ReadLine());
                sw1.Close();
                ad = Console.ReadLine();
                FileStream fs2 = new FileStream("D:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw2 = new StreamWriter(fs2);
                Console.Write("Soyadınız:");
                sw2.WriteLine(Console.ReadLine());
                sw2.Close();
                soyad = Console.ReadLine();
                FileStream fs3 = new FileStream("D:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw3 = new StreamWriter(fs3);
                Console.Write("Yaşınız:");
                sw3.WriteLine(Console.ReadLine());
                sw3.Close();
                yas = Console.ReadLine();
                FileStream fs4 = new FileStream("D:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw4 = new StreamWriter(fs4);
                Console.Write("Öğrenim Durumunuz:");
                sw4.WriteLine(Console.ReadLine());
                sw4.Close();
                ogrenimdurumu = Console.ReadLine();
                FileStream fs5 = new FileStream("D:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw5 = new StreamWriter(fs5);
                Console.Write("Mesleğiniz:");
                sw5.WriteLine(Console.ReadLine());
                sw5.Close();
                meslek = Console.ReadLine();
                FileStream fs6 = new FileStream("D:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw6 = new StreamWriter(fs6);
                Console.Write("Telefon Numaranız:");
                sw6.WriteLine(Console.ReadLine());
                sw6.Close();
                tel = Console.ReadLine();
                FileStream fs7 = new FileStream("D:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw7 = new StreamWriter(fs7);
                Console.Write("Adresiniz:");
                sw7.WriteLine(Console.ReadLine());
                sw7.Close();
                adres = Console.ReadLine();
                FileStream fs8 = new FileStream("D:\\deneme.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw8 = new StreamWriter(fs8);
                Console.Write("**");
                sw8.WriteLine(Console.ReadLine());
                sw8.Close();
                Console.ReadLine();
            }
            else
            {


                StreamReader sr = new StreamReader("D:\\deneme.txt");
                Console.WriteLine(sr.ReadToEnd());

                Console.ReadKey();
            }
        }
        

    }
}
