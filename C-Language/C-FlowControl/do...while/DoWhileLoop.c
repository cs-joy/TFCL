// Program to add numbers until the user enters zero

#include <stdio.h>

int main() {
    double num, sum = 0;

    //the body of the loops is executed at least once
    do {
        printf("Enter a number: ");
        scanf("%lf", &num);
        sum += num;
    }
    while(num != 0.0);
    printf("Sum = %.2lf\n", sum);

    return 0;
}
