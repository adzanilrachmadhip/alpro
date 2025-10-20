using System;


class nested_looping
{

    public static void Main()
    {
        int outerLimit, innerLimit;

        Console.Write("Inputkan perulangan Outer yang anda inginkan ?? = ");
        while (!int.TryParse(Console.ReadLine(), out outerLimit))
        {
            Console.WriteLine("Ini bukan angka kocyaaak! -____- Masukkan bilangan bulat ya...");
            Console.Write("Coba lagi, berapa perulangan Outer? = ");
        }

        Console.Write("Inputkan perulangan Inner yang anda inginkan ?? = ");
        while (!int.TryParse(Console.ReadLine(), out innerLimit))
        {
            Console.WriteLine("Ini bukan angka kocyaaak! Masukkan bilangan bulat ya...");
            Console.Write("Coba lagi, berapa perulangan Inner? = ");
        }

        int x = 1;
        int outerNumber = 1;
        do{
            Console.WriteLine($"{outerNumber}. Outer Loop Yang ke {x} ");
            int y = 1;
            do{
                Console.WriteLine("   => Inner Loop yang ke {0} ", y);
                y++;
            } while (y <= innerLimit);
        x++;
        outerNumber++;
        }while (x <= outerLimit);
    }
}    