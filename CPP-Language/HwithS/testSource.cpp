#include <iostream>

//including header file
#include "testHeader.h"

using namespace std;

int main() {
    //declare varibale
    int x = 1, y = 2;
    float s = 1.1, j = 2.2;

    /*print out first function from the header file*/
    cout << "Sum of two number is: " << sumOfTwoNumbers(x, y) << endl;

    /*print out second function from the header file*/
    cout << "Sum of two float number is: " << someOfFloatNumber(s, j) << endl;

    return 0;
}