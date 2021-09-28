// Program to check whether an integer is positive or negative
// This program considers 0 as a positive number

#include <iostream>

using namespace std;

int main() {
    int num;

    cout << "Enter an integer: ";
    cin >> num;

    if (num >=0 ) {
        cout << "You entered a positive integer: " << num << endl;
    } else {
        cout << "You entered a negative integer: " << num << endl;
    }
    cout << "--------------------------" << endl;
    cout << "This line is always printed." << endl;
    cout << "--------------------------" << endl;

    return 0;
}
