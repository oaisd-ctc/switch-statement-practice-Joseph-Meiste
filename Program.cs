using System;

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Your Number is one");
                break;
            case 2:
                Console.WriteLine("Your Number is two" );
                break;
            case 3:
                Console.WriteLine("Your Number is three" );
                break;
            case 4:
                Console.WriteLine("Your Number is four" );
                break;
            case 5:
                Console.WriteLine("Your Number is five" );
                break;
            case 6:
                Console.WriteLine("Your Number is six" );
                break;
            case 7:
                Console.WriteLine("Your Number is seven" );
                break;
            case 8:
                Console.WriteLine("Your Number is eight" );
                break;
            case 9:
                Console.WriteLine("Your Number is nine" );
                break;
            case 10:
                Console.WriteLine("Your Number is ten" );
                break;
            default:
                Console.WriteLine("Your program should account for numbers 0-10. For any other numbers, simply output “That number is not in range");
                break;
        }
    }
}