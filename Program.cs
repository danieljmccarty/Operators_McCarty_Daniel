namespace Operators_McCarty_Daniel
{
    internal class Program
    {
        private static object console;

        static void Main(string[] args)
        {
            Console.WriteLine("INTIGERS");
            // initializes an integer that multiplies two integers
            int intmult = 6 * 45;
            // initialized an integer that adds to integers
            int intadd = 55 * 66;
            // print the maximum and minimum of the two integer variables
            Console.WriteLine($"the max of {intmult} and {intadd} is {Math.Max(intmult, intadd)}. " +
                $"the min of the two is {Math.Min(intmult, intadd)}");

            // initializes boolean to see if intmult is greater than intadd
            bool isintgreater = intmult > intadd;
            //print if intmult is greater than intadd
            Console.WriteLine($"{intmult} is greater than {intadd}, {isintgreater}.\n");

            Console.WriteLine("shorts");
            // Initializes a short that multipies two shorts
            short shortmult = 6 * 45;
            // Initializes a short that add to shorts
            short shortadd = 55 * 66;
            // Prints the maximum and minimum of the two short variables
            Console.WriteLine($"the max of {shortmult} and {shortadd} is {Math.Max(shortmult, shortadd)}. " +
                $"the min of the two is {Math.Min(shortmult, shortadd)}");

            // Initializes boolean to see if shortMult is greater than shortadd
            bool isshortgreater = shortmult > shortadd;
            // Prints if shortMult is greater than shortadd
            Console.WriteLine($"{shortmult} is greater than {shortadd}, {isshortgreater}.\n");

            Console.WriteLine("LONGS");
            // Initializes a long that multiplies two longs
            long longmult = 6 * 45;
            //Initialized a long that adds to long
            long longadd = 55 * 66;
            // Prints the maximum and minimum of the two long variables
            Console.WriteLine($"the max of {longmult} and {longadd} is {Math.Max(longmult, longadd)}. " +
                $"the min of the two is {Math.Min(longmult, longadd)}");

            // Initializes boolean to see if longMult is greater than longadd
            bool islonggreater = longmult > longadd;
            // Prints if longMult is greater than longAdd
            Console.WriteLine($"{longmult} is greater than {longadd}, {islonggreater}.\n");

            Console.WriteLine("FLOATS");
            // Initializes a float that multipies two float
            float floatmult = 6.5f * 45.24f;
            // Initializes a float that adds to float
            float floatadd = 55.35f * 66.15f;
            // Prints the maximum and minimum of the two float variables
            Console.WriteLine($"the max of {floatmult} and {floatadd} is {Math.Max(floatmult, floatadd)}. " +
                $"the min of the two is {Math.Min(floatmult, floatadd)}");

            // Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatgreater = floatmult > floatadd;
            //print if floatMult is greater than floatadd
            Console.WriteLine($"{floatmult} is greater than {floatadd}, {isfloatgreater}.\n");

            Console.WriteLine("DOUBLE");
            // Initializes a double that multibles two double
            double doublemult = 6.69 * 45.58;
            // Initialized a double that adds to double
            double doubleadd = 55.48 * 66.15;
            // prints the maximum and minimum of the two double variables
            Console.WriteLine($"the max of {doublemult} and {doubleadd} is {Math.Max(doublemult, doubleadd)}. " +
                $"the min of the two is {Math.Min(doublemult, doubleadd)}");

            // Initializes boolean to see if doubleMult is greater than doubleadd
            bool isdoublegreater = doublemult > doubleadd;
            // Prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doublemult} is greater than {doubleadd}, {isdoublegreater}.\n");

            Console.WriteLine("DECIMAL");
            // Initializes a decimal that multiplies two decimal
            decimal decimalmult = (decimal) (6.25 * 45.15);
            // Initialized a decimal that adds to decimal
            decimal decimaladd = (decimal) (55.66 * 66.55);
            // prints the maximum and minimum of the two decimal variables
            Console.WriteLine($"the max of {decimalmult} and {decimaladd} is {Math.Max(decimalmult, decimaladd)}. " +
                $"the min of the two is {Math.Min(decimalmult, decimaladd)}");

            // Initializes boolean to see if decimalMult is greater than decimal add
            bool isdecimalgreater = decimalmult > decimaladd;
            // Prints if decimalMult is greater than decimaladd
            Console.WriteLine($"{decimalmult} is greater than {decimaladd}, {isdecimalgreater}.\n");
        }
    }
}