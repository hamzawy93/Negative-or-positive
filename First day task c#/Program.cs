// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Enter A Number");
int number = int.Parse (Console.ReadLine());
if (number > 0)
    Console.WriteLine("The Number Is positive ");
else if (number < 0)
    Console.WriteLine("The Number is Negative");
else Console.WriteLine("The Number Is Zero");

