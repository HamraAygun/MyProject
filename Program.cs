// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
public class Program

{
    public static void Main(string[] args)

    // Ölçüsü verilen dikdörtgenin alanını ve çevresini hesaplayan kodu yazınız..
    {
        int a, b, c, d;

        Console.WriteLine("Dikdörtgenin bir kenar ölçüsünü giriniz." + "\n");

        a = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine("Dikdörtgenin diğer kenar ölçüsünü giriniz." + "\n");

        b = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        c = a * b;

        Console.WriteLine("Dikdörtgenin alanı :" + c + "\n");

        d = 2 * (a + b);

        Console.WriteLine("Dikdörtgenin Çevresi :" + d + "\n");

        Console.ReadKey();







    }




}
