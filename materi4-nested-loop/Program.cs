using System;


class nested_looping
{

    public static void Main()
    {
        Console.WriteLine("Inputkan perulangan Outer yang anda inginkan ?? = ");
        int outerLimit = Convert.ToInt32(Console.ReadLine());
        int outerNumber = 1;
        Console.WriteLine("Inputkan perulangan Outer yang anda inginkan ?? = ");
        int innerLimit = Convert.ToInt32(Console.ReadLine());
        int x = 1;
        do{
            Console.WriteLine($"{outerNumber}. Outer Loop Yang ke {0} ", x);
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