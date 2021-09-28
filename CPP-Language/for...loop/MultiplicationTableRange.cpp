//Display multiplication table up to a given range

#include <iostream>

using namespace std;

int main() {
  int n, range;

  cout << "Enter a positive integer: ";
  cin >> n;

  cout << "Enter an range: ";
  cin >> range;

  for (int i = 1; i <= range; i++) {
    int m = n * i;

    cout << n << " * " << i << " = " << m << endl;
  }
  return 0;
}
