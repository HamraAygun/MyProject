// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
public class Program

{
    public static void Main(string[] args)

    {
        //Bir ders için yapılan iki ara sınav ve bir genel sınav sonucu değerlendirilerek geçme notları hesaplanacaktır. Bu dersin geçme notu 1. ara sınav notunun %20’si, 2. ara sınav notunun %30’u ve genel sınav notunun %50’si toplanarak hesaplanmaktadır. Geçme notunu hesaplayan ve sonucu ekrana yazdıran programı yazın.

        int a, b, c;

        Console.WriteLine("İlk ara sınav notunuzu giriniz: " + "\n");

        a = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("ikinci ara sınav notunuzu giriniz: " + "\n");

        b = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Genel sınav notunuzu giriniz: " + "\n");

        c = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        int toplam = ((a * 20) / 100) + ((b * 30) / 100) + ((c * 50) / 100);

        Console.WriteLine("Geçme notunuz: " + toplam);

        Console.ReadKey();
    }
}
