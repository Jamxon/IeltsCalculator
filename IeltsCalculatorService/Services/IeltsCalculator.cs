using System;
using System.Collections.Generic;
using System.Text;

namespace IeltsCalculatorService.Services
{
    public class IeltsCalculator
    {
        public double CalculateOverall(
            double listening,
            double reading,
            double writing,
            double speaking)
        {
            double average = (listening + reading + writing + speaking) / 4.0;

            double floor = Math.Floor(average);
            double diff = average - floor;

            if (diff < 0.25)
                return floor;
            else if (diff < 0.75)
                return floor + 0.5;
            else
                return floor + 1;
        }

        public string GetCategory(double score)
        {
            if (score == 9)
                return "Expert";
            else if (score >= 8)
                return "Very Good";
            else if (score >= 7)
                return "Good";
            else if (score >= 6)
                return "Competent";
            else if (score >= 5)
                return "Modest";
            else
                return "Limited";
        }
    }
}
