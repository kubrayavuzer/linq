using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //rastgele sayı üretimi
        Random random = new Random();
        List<int> numbers = new List<int>();

        //10 adet rastgele sayı üretimi. negatif sayı için -100, 100 arası
        for ( int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-100, 100));
        }

        Console.WriteLine("Oluşturulan liste:");
        foreach ( var number in numbers)
        {
            Console.WriteLine(number + "");
        }

        Console.WriteLine("----------------");

        //pozitif sayılar
        var positiveNumbers = numbers.Where(num => num > 0);

        Console.WriteLine("Pozitif sayılar:");
        foreach( var number in positiveNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("---------------");

        //negatif sayılar

        var negativeNumbers = numbers.Where(num => num < 0);

        Console.WriteLine("Negatif sayılar");
        foreach(var number in negativeNumbers)
        {

        Console.WriteLine(number); }

        Console.WriteLine("---------------");

        //çift sayılar

        var evenNumbers = numbers.Where(num => num % 2 == 0);

        Console.WriteLine("Çift sayılar:");
        foreach(var number in evenNumbers)
        {

        Console.WriteLine(number); 
        }

        Console.WriteLine("----------------");

        //tek sayılar

        var oddNumbers = numbers.Where(num => num % 2 != 0);

        Console.WriteLine("Tek sayılar:");
        foreach(var number in oddNumbers)
        {

        Console.WriteLine(number); 
        
        }

        var rangeNumbers = numbers.Where(num => num > 15 && num < 22);
        Console.WriteLine("15'ten küçük ve 22'den büyük sayılar:");
        foreach(var number in rangeNumbers)
        {
            Console.WriteLine(number);

        }

        Console.WriteLine("--------------");

        //sayıların karesi

        var squaredNumbers = numbers.Select(num => num * num);
        Console.WriteLine("Sayıların karesi:");
        foreach(var number in squaredNumbers)
        {
            Console.WriteLine(number);
        }

    }
}