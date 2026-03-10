using System.Linq;

double[] numbers = { 3, 6, 9, 12 };

double average = numbers.Average();
double max = numbers.Max();
double min = numbers.Min();

Console.WriteLine($"Average result: {average}");
Console.WriteLine($"Maximum result: {max}");
Console.WriteLine($"Minimum result: {min}");
