using System;
namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparison computation = new LineComparison(30, 64, 88, 118);
            double line1 = computation.CalculateLength();
            LineComparison line = new LineComparison(20, 10, 2, 100);
            double line2 = line.CalculateLength();
            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("Both lines lengths are equal");
            }
            if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine(" line1 is greater");
            }
            else
            {
                Console.WriteLine("line2 is greater");
            }
        }
    }
}