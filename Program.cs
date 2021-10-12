using System;

namespace Modul_1___Bagasw
{
    class Program
    {
        static void Main(string[] args)
        {

            stringDiCsharp.iniString();
            searchStrings.cariStrings();
            NumberInCSharp.NomorPart1();
            NumberInCSharp.NomorPart2();
        }
    }

    class stringDiCsharp
    {
        public static void iniString()
        {
            Console.WriteLine("\nString di C#");
            Console.WriteLine("=================");
            //Cetak string dari variabel
            string aFriend = "Bagasw";
            Console.WriteLine(aFriend);

            //cetak string konstanta dan variabel
            Console.WriteLine("Hello " + aFriend);

            string firstFriend = "Rahel";
            string secondFriend = "Kayla";

            //Teknik interpolasi string
            Console.WriteLine($"My Friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"Hello {aFriend}");

            // Teknik menemukan panjang string dengan length
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");
        }
    }

    class searchStrings
    {
        public static void cariStrings()
        {
            Console.WriteLine("\nMencari Strings");
            Console.WriteLine("=================");
            // Teknik method contains = untuk mencari keberadan suatu strings
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
        }
    }

    class NumberInCSharp
    {
        public static void NomorPart1()
        {
            Console.WriteLine("\nNumber di C# - Operasi Matematika");

            Console.WriteLine("Operasi Part 1 - Operasi Matematika Umum");
            Console.WriteLine("=================");
            int a = 18;
            int b = 6;
            // Penjumlahan
            int c = a + b;
            // Pengurangan
            int d = a - b;
            // Perkalian
            int e = a * b;
            // Pembagian
            int f = a / b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
        }

        public static void NomorPart2()
        {
            Console.WriteLine("\nOperasi Part 2 - Prioritas Operasi Matematika");
            Console.WriteLine("=================");

            Console.WriteLine("\nPrioritas Operasi Matematika Perkalian/Pembagian");
            Console.WriteLine("=================");
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            Console.WriteLine("\nPrioritas Operasi Matematika Dalam Kurung Akan didahulukan");
            Console.WriteLine("=================");
            int e = 5;
            int f = 4;
            int g = 2;
            int h = (e + f) * g;
            Console.WriteLine(h);

            int i = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(i);

            int j = 7;
            int k = 4;
            int l = 3;
            int m = (j + k) / l;
            Console.WriteLine(m);


        }
    }

    // Besok mengerjakan integer precision and limits dst
}
