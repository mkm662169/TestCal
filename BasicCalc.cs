using System;
using Operations;
namespace NewCalculator
{
    public class BasicCalc
    {
        public int solution;
        public int Add(int a, int b)
        {
            solution = Addition.Add(a, b);
            return solution;
        }

        public int Divide(int a, int b)
        {
            solution = Division.Divide(a, b);
            return solution;
        }
    }
}
