using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyKilo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boyunuzu giriniz metre olarak: ");
            double boy = double.Parse(Console.ReadLine());
            Console.Write("Kilonuz Giriniz: "); 
            double kilo = double.Parse(Console.ReadLine());
            double index = kilo / (boy * boy);
            if (index <= 18.5)
            {
                Console.WriteLine("Zayıfsınız : " + index);
            }
            else if (index <= 24.9)
            {
                Console.WriteLine("Sağlıklısınız : " + index);
            }
            else if (index <= 29.9)
            {
                Console.WriteLine("Fazla kilolusunuz Abi :  " + index);
            }
            else if (index <= 34.9)
            {
                Console.WriteLine("1.Derece Obezsiniz  :  " + index);
            }
            else if (index <= 39.9)
            {
                Console.WriteLine("2.Derece Obezsiniz  :  " + index);
            }
            else {
                Console.WriteLine("3.Derece Obezsiniz(Morbid)  :  " + index);

            }

            Console.Write("Doğum yılınızı giriniz: ");
            int dogum = int.Parse(Console.ReadLine());
            DateTime Tarih = DateTime.Now;
            int yil = Tarih.Year;
            int yass = yil - dogum;
            
            if (yass <18) {
                Console.WriteLine("Reşit Değilsiniz :" + " " + yass);
            }
            else
            {
                Console.WriteLine("Reşitsiniz :" + " " + yass);
            }

            Console.Write("Zeka yaşınızı girin : ");
            double zeka = double.Parse(Console.ReadLine());
            Console.Write("Takvim  yaşınızı girin : ");
            double yas = double.Parse(Console.ReadLine());
            double iq = 100*(zeka / yas);
            Console.WriteLine("IQ nuz : " + iq);

        }
    }
}
