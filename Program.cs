namespace Operators_McCarty_Daniel
{
    internal class Program
    {
        private static object console;

        static void Main(string[] args)
        {
            Console.WriteLine("INTIGERS");
            int intmult = 6 * 45;
            int intadd = 55 * 66;
            Console.WriteLine($"the max of {intmult} and {intadd} is {Math.Max(intmult, intadd)}. " +
                $"the min of the two is {Math.Min(intmult, intadd)}");

            bool isintgreater = intmult > intadd;
            Console.WriteLine($"{intmult} is greater than {intadd}, {isintgreater}.\n");

            Console.WriteLine("shorts");
            short shortmult = 6 * 45;
            short shortadd = 55 * 66;
            Console.WriteLine($"the max of {shortmult} and {shortadd} is {Math.Max(shortmult, shortadd)}. " +
                $"the min of the two is {Math.Min(shortmult, shortadd)}");

            bool isshortgreater = shortmult > shortadd;
            Console.WriteLine($"{shortmult} is greater than {shortadd}, {isshortgreater}.\n");

            Console.WriteLine("LONGS");
            long longmult = 6 * 45;
            long longadd = 55 * 66;
            Console.WriteLine($"the max of {longmult} and {longadd} is {Math.Max(longmult, longadd)}. " +
                $"the min of the two is {Math.Min(longmult, longadd)}");

            bool islonggreater = longmult > longadd;
            Console.WriteLine($"{longmult} is greater than {longadd}, {islonggreater}.\n");

            Console.WriteLine("FLOATS");
            float floatmult = 6.5f * 45.24f;
            float floatadd = 55.35f * 66.15f;
            Console.WriteLine($"the max of {floatmult} and {floatadd} is {Math.Max(floatmult, floatadd)}. " +
                $"the min of the two is {Math.Min(floatmult, floatadd)}");

            bool isfloatgreater = floatmult > floatadd;
            Console.WriteLine($"{floatmult} is greater than {floatadd}, {isfloatgreater}.\n");

            Console.WriteLine("DOUBLE");
            double doublemult = 6.69 * 45.58;
            double doubleadd = 55.48 * 66.15;
            Console.WriteLine($"the max of {doublemult} and {doubleadd} is {Math.Max(doublemult, doubleadd)}. " +
                $"the min of the two is {Math.Min(doublemult, doubleadd)}");

            bool isdoublegreater = doublemult > doubleadd;
            Console.WriteLine($"{doublemult} is greater than {doubleadd}, {isdoublegreater}.\n");

            Console.WriteLine("DECIMAL");
            decimal decimalmult = (decimal) (6.25 * 45.15);
            decimal decimaladd = (decimal) (55.66 * 66.55);
            Console.WriteLine($"the max of {decimalmult} and {decimaladd} is {Math.Max(decimalmult, decimaladd)}. " +
                $"the min of the two is {Math.Min(decimalmult, decimaladd)}");

            bool isdecimalgreater = decimalmult > decimaladd;
            Console.WriteLine($"{decimalmult} is greater than {decimaladd}, {isdecimalgreater}.\n");
        }
    }
}