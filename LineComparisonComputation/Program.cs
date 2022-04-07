using System;
namespace LineComparisonComputation
{

    class Program
    {
        static void Main(string[] args)
        {
            LineComparison computation = new LineComparison(35, 74, 82, 100);
            double line1 = computation.CalculateLength();
            LineComparison line = new LineComparison(30, 64, 89, 118);
            double line2 = line.CalculateLength();
            if (line1.Equals(line2))
                Console.WriteLine("Both lines lengths are equal");
            else
                Console.WriteLine(" Both lines are not equal");



        }



    }
}