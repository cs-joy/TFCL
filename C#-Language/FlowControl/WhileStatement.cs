using System;

namespace Loop
{
    class WhileLoop
    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("C# While Loop: Iteration {0}", i);
                i++;
            }
        }
    }
}
