using System;
using IeltsCalculatorService.Services;

class Program
{
    static void Main()
    {
        double listening = GetScore("Listening");
        double reading = GetScore("Reading");
        double writing = GetScore("Writing");
        double speaking = GetScore("Speaking");

        IeltsCalculator calculator = new IeltsCalculator();

        double overall = calculator.CalculateOverall(
            listening, reading, writing, speaking
        );

        string category = calculator.GetCategory(overall);

        Console.WriteLine("\n------------------");
        Console.WriteLine($"Overall Score: {overall}");
        Console.WriteLine($"Category: {category}");
    }

    static double GetScore(string skill)
    {
        Console.Write($"{skill} score: ");
        return double.Parse(Console.ReadLine());
    }
}
