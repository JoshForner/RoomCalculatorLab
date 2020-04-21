using System;
using System.Dynamic;

namespace RoomCalculatorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            double perimeter;
            double height;
            double volume;
            string answer = "Y";

            Console.WriteLine("Welcome to the Grand Circus Room Calculator");

            while (answer == "Y")
            {


            Console.Write("Enter Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Enter Height: ");
            height = double.Parse(Console.ReadLine());

            perimeter = (width * 2) + (length * 2);
            area = width * length;
            volume = length * width * height;

            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Volume: " + volume);
            Console.Write("Do you wish to continue? (Y/N) ");

            answer = Console.ReadLine();
            }

           
        }
    }
}
