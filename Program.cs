using System.Linq;

double[] numbers = { 5, 10, 15, 20 };

double average = numbers.Average();
double max = numbers.Max();
double min = numbers.Min();

Console.WriteLine($"Average value: {average}");
Console.WriteLine($"Maximum value: {max}");
Console.WriteLine($"Minimum value: {min}");
