using System.Linq;

double[] numbers = { 3, 6, 9, 12 };

double average = numbers.Average();
double max = numbers.Max();
double min = numbers.Min();

Console.WriteLine($"Average value: {average}");
Console.WriteLine($"Maximum value: {max}");
Console.WriteLine($"Minimum value: {min}");
