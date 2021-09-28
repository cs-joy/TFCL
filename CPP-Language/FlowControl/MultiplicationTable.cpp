//Display multiplication table up to 10

#include <iostream>

using namespace std;

int main() {
    int n;

    cout << "Enter a positive integer: ";
    cin >> n;

    for (int i = 1; i <=10; ++i) {
        int m = n * i;
        cout << n << " * " << i << " = " << m << endl;
    }

    return 0;
}
