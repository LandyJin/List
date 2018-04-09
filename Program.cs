using System;
using System.Collections.Generic;
public class Program
{
    private static List<double> _values = new List<double>();
    public enum UserOption
    {
        NewValue,
        Sum,
        Print,
        Quit
    }
    public static void Main(string[] args)
    {
        UserOption userOption;
        do
        {
            userOption = ReadUserOption();
            switch(userOption)
            {
                case UserOption.NewValue:
                    AddValueToList();
                    break;
                case UserOption.Sum:
                    Sum();
                    break;
                case UserOption.Print:
                    Print();
                    break;
                case UserOption.Quit:
                    break;
            }
        }while(userOption != UserOption.Quit);
    }

    public static int ReadInteger(string prompt)
    {

        Console.Write(prompt);

        while(true)
        {

            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Please enter a valid integer");
            }
        }
    }
    public static double ReadDouble(string prompt)
    {

        Console.Write(prompt);

        while(true)
        {

            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Please enter a valid value in double");
            }
        }
    }

    public static void AddValueToList()
    {
        double value = ReadDouble($"Enter a value: ");
        _values.Add(value);
    }

    public static void Print()
    {

        for(int i = 0; i<_values.Count;i++)
        {
            Console.WriteLine(_values[i]);
        }
    }

    public static void Sum()
    {

        double sum = 0.0;
        foreach(double value in _values)
        {

            sum+= value;
        }
        Console.WriteLine("The sum of list items is: " + sum);
    }

    public static UserOption ReadUserOption() 
    {
        Console.WriteLine("Enter 0 to add a value");
        Console.WriteLine("Enter 1 to add a sum all values");
        Console.WriteLine("Enter 2 to print all values"); 
        Console.WriteLine("Enter 3 to quit");
        int option = 3; 
        Int32.TryParse(Console.ReadLine(), out option);
        return (UserOption)option; 
    }
}
