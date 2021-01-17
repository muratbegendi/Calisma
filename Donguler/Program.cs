using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //birbirine benzeyen işlemleri tekrar etmek için kullanırız
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamay Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);


            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamay Başlangıç İçin Temel Kurs",
                "Java","Python","C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //foreach dizi temelli yapıları tek tek dönmeye yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
