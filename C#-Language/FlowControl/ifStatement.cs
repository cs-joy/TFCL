using System;

namespace Conditional {
    class IfStatement {
        public static void Main(string[] args) {
            int number = 2;
            if (number < 5) {
                Console.WriteLine("{0} is less than 5", number);
            }

            Console.WriteLine("This statement is always executed.");
        }
    }
}
