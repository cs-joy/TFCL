using System;

namespace Conditional {
    class IifElseIfStatement {
        public static void Main(string[] args) {
            int number = 10;
            if (number < 5) {
                Console.WriteLine("{0} is less than 5", number);
            } else if (number > 5){
                Console.WriteLine("{0} is greater than 5", number);
            } else {
                Console.WriteLine("{0} is equal to 5");
            }
        }
    }
}
