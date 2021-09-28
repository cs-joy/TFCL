// Program to print positive number entered by the user
// If the user enters a negative number, it is skipped

#include <iostream>

using namespace std;

int main() {
    int number;

    cout << "Enter an integer number: ";
    cin >> number;

    //checks if the number is positive
    if (number > 0) {
        cout << "You entered a positive integer: " << number << endl;
    }
    cout << "This statement is always executed." << endl;

    return 0;
}
