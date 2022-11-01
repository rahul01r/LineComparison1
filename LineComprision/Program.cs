using System;

namespace LineComprision
{
    public class Program
    {
        static void Main(string[] args)
        {
            Comprasion comprasion = new Comprasion(1,2,3,4);
            double line1 = comprasion.CalculateLength();
            Console.WriteLine("Length of first line " + line1);
            Comprasion LineComparisionProblem = new Comprasion(1, 2, 3, 4);
            double line2 = LineComparisionProblem.CalculateLength();
            Console.WriteLine("Length of second line" + line2);
            if (line1 == line2)
            {
                Console.WriteLine("Line 1 and Line 2 are equal");
            }
            else
                Console.WriteLine("Not equal");
        }
    }
}