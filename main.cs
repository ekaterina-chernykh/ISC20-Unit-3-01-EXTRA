// Created by: Ekaterina
// Created on: Oct 2022
//
// This program calculates area of an ellipse

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        decimal base_a;
        decimal base_b;
        decimal height;
        decimal area;

        Console.WriteLine("This program calculates the area of an trapezoid");
        Console.WriteLine(" ");

        Console.WriteLine("Formula: A = [(a + b) / 2] × h ");
        Console.WriteLine(" ");
        Console.Write("Enter length of base 'a': ");
        base_a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter length of base 'b': ");
        base_b = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter length of height: ");
        height = Convert.ToDecimal(Console.ReadLine());

        area = ((base_a + base_b) / 2) * height;

        Console.WriteLine(" ");
        Console.WriteLine("Your area will be: " + area.ToString("0.00") + " mm²");

        Console.WriteLine("\nDone.");
    }
}