using System;
using System.Collections.Generic;
using System.Linq;

namespace Sinav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen kelimeyi tersine çevirip yazdırma");
            string kelime = "Can";
            Quiz1Issue(kelime);

            Console.WriteLine("Palindrome mu ?");
            string palindrome = "ece";
            Quiz2Issue(palindrome);

            Console.WriteLine("0'dan 10'a kadar sayıları ekrana yazdıralım");
            Quiz3Issue(10);

            Console.WriteLine("Girilen bütün sayıları toplayalım");
            int[] sayi1 = { 1, 10, 20, 30, 40, 4000, 50, 60, 70, 1 };
            Console.WriteLine(Quiz4Issue(sayi1));

            Console.WriteLine("Girilen 3 sayıdan en Büyüğünü bulalım");
            int[] sayi2 = { 1000, 900, 5000 };
            Console.WriteLine(Quiz5Issue(sayi2));

            Console.WriteLine("Girilen 3 sayıdan en Küçüğünü bulalım");
            int[] sayi3 = { 1000, 900, 5000 };
            Console.WriteLine(Quiz6Issue(sayi3));

            Console.WriteLine("Girilen 5 sayıdan Enbüyük ve enküçük bulalım");
            int[] sayi4 = { 1000, 900, 5000, 10, 50001 };
            Quiz7Issue(sayi4);

            Console.WriteLine("Girilen 10 sayıdan ortalamasına en yakın olanı bulalım");
            double[] sayi5 = { 1, 10, 20, 30, 40, 4000, 50, 60, 70, 1 };
            Quiz8Issue(sayi5);

            Console.WriteLine("İsim ve Soyisminiz N kadar yazdırın");
            Quiz9Issue(5);

            Console.WriteLine("Girilen 10 sayının negatif/pozitif olduğunu yazdırma.");
            int[] sayi6 = { 1, -10, 20, -30, 40, 4000, -50, 60, 70, -1 };
            Quiz10Issue(sayi6);

            Console.ReadLine();
        }

        // 1) Girilen kelimeyi tersine çevirip yazdırma
        static void Quiz1Issue(string input)
        {
            string kelime = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                kelime += (input[input.Length - i - 1]);
            }
            Console.WriteLine(kelime);
        }

        // 2) Palindrome
        static void Quiz2Issue(string input)
        {
            bool pol = true;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[input.Length - i - 1] == input[i])
                {
                    pol = true;
                }
                else
                {
                    pol = false;                    
                }
            }

            if (pol)
            {
                Console.WriteLine("Polindromdur.");
            }
            else
            {
                Console.WriteLine("Polindrom değildir.");
            }
        }

        // 3) 0'dan 10'a kadar sayıları ekrana yazdıralım
        static void Quiz3Issue(int input)
        {
            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 4) Girilen bütün sayıları toplayalım
        static int Quiz4Issue(int [] input)
        {            
            int toplam = 0;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                toplam += input[i];
            }
            return (toplam);
        }

        // 5) Girilen 3 sayıdan en Büyüğünü bulalım
        static int Quiz5Issue(int[] input)
        {
            int enBuyuk = 0;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] > enBuyuk)
                {
                    enBuyuk = input[i];
                }
            }
            return(enBuyuk);
        }

        // 6) Girilen 3 sayıdan en Küçüğünü bulalım
        static int Quiz6Issue(int[] input)
        {
           int enKucuk = input[0];
           foreach(int value in input)
            {
                if (value < enKucuk) enKucuk = value;
            }
            return enKucuk;
        }

        // 7) Girilen 5 sayıdan Enbüyük ve enküçük bulalım
        static void Quiz7Issue(int[] input)
        {
            int enBuyuk = 0;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] > enBuyuk)
                {
                    enBuyuk = input[i];
                }
            }
            int enKucuk = input[0];
            foreach (int value in input)
            {
                if (value < enKucuk) enKucuk = value;
            }
            Console.WriteLine("EnBüyük = " + enBuyuk + " EnKüçük = " + enKucuk);
        }

        // 8) Girilen 10 sayıdan ortalamasına en yakın olanı bulalım
        static void Quiz8Issue(double [] input)
        {
            double enKucuk = Double.MaxValue;
            int yeri = 0;
            List<double> fark = new List<double>();

            double ortalama = input.Average();

            for (int i = 0; i <= input.Length - 1; i++)
            {
                fark.Add(Math.Abs(ortalama - input[i]));
            }
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (fark[i] < enKucuk)
                {
                    enKucuk = fark[i];
                    yeri = i;
                }
            }
            Console.WriteLine(input[yeri]);
        }

        // 9) İsim ve Soyisminiz N kadar yazdırın
        static void Quiz9Issue(int input)
        {
            string[] isim = { "Mehmet Can Onur YARALI" };
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(isim[0]);
            }
        }

        // 10) Girilen 10 sayının negatif/pozitif olduğunu yazdırma.
        static void Quiz10Issue(int [] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < 0)
                {
                    Console.WriteLine(input[i] + " Negatif");
                }
                else
                {
                    Console.WriteLine(input[i] + " Pozitif");
                }
            }
        }
    }
}
