//Find Factorial of a given number

#include <iostream>

using namespace std;

int main() {
    int number;
    long double factorial = 1.0;

    //design section
    cout << "-----|-Factorial Solution-|-----" << endl;

    cout << "Enter a positive integer number: ";
    cin >> number;

    if (number < 0) {
        cout << "Error! Factorial of a negative number doesn't exist.";
    } else {
        for (int i = 1; i <= number; ++i) {
            factorial *= i;
        }
        cout << "Factorial of " << number << " = " << factorial << endl;
      }

      return 0;
}
