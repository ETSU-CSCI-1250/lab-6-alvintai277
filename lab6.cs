using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("INDEX for index counter, RETAIL for retail price, TEMP for temperature table, PRIME for prime number");
        string input = Console.ReadLine();

        Console.Clear();

        switch (input.Trim().ToUpper())
        {
            case "INDEX":
                ShowCharacter();
                break;
            case "RETAIL":
                CalculateRetail();
                break;
            case "TEMP":
                Celsius();
                break;
            case "PRIME":
                IsPrime();
            
                break;
            default:
                Console.WriteLine("invalid response please try again");
                break;


        }


    }
    static void ShowCharacter()
    {
        string input;
        int i;

        Console.WriteLine("Please Enter a Line of Text");
        input = Console.ReadLine();

        Console.WriteLine("Please Enter an Index Position");
        i = Int32.Parse(Console.ReadLine());



        Console.WriteLine($" The character in this position is {input[i]}");
    }
    static void CalculateRetail()
    {
        double input;
        double i;
        Console.Write("What is the retail price of your product?: $ ");
        input = Int32.Parse(Console.ReadLine());

        Console.Write("What is the markup percentage of the product?: % ");
        i = Int32.Parse(Console.ReadLine());

        double price = input * i / 100;
        double prices = price + input;

        Console.WriteLine($"The mark up price is ${prices}");

    }
    static void Celsius()
    {
        for (int f = 80; f <= 100; f++)
        {
            double conversion = (f - 32) * 5.0 / 9.0;
            Console.WriteLine($"Farenheit: {f} degrees Celcius: {Math.Round(conversion, 2)} degrees \n");
        }
    }
    static void IsPrime()
    {

            Console.WriteLine("What is the number you want to check?: ");

        int number = Int32.Parse(Console.ReadLine()); 
    
        if (number % 2 == 0 && number != 2)
        {
            Console.WriteLine("This is not a prime number");
        }
        
        else if (!((number % 2 == 0 && number != 2)))
        {
            for (int divisor = 3; divisor < Math.Sqrt(number); divisor += 2)
            {
                if (number % divisor == 0 && number != divisor)
                {
                    Console.WriteLine("This is not a prime number");
                }
            }
        }
        else
        {
            Console.WriteLine("This is a prime number"); 
        }
      
        
    }
    
}


