using System;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

class Calculator
{

static void Main()
{
    Console.WriteLine("Enter the first number :");
    double num1 = Convert.ToInt32 (Console.ReadLine());
    Console.Beep(1300,250);

    Console.WriteLine("Enter Tte second number :");
    double num2 = Convert.ToInt32 (Console.ReadLine());
    Console.Beep(1400,250);

    Console.WriteLine("Enter the required process [+] [-] [/] [*] ...");
    string process = Console.ReadLine();
    Console.Beep(1500,250);

    double result = 0;

    if (process == "+")
    {
        result = num1 + num2;
    }
    else if (process == "-")
    {
        result = num1 - num2;
    }
    else if (process == "*")
    {
        result = num1 * num2;
    }
    else if (process == "/")
    {
        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("IS THAT A JOKE ?!"); Console.WriteLine("The number (0) cannot be used in Division");
            return;
        }
    }
    else
    {
        Console.WriteLine("ERORR DONT TRY AGAIN");
        return;
    }

    
    Console.Beep(1700,500);
    Console.WriteLine("Result is : " + result);
    
}


}

