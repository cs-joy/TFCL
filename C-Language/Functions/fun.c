#include <stdio.h>
#include "func.h"

int main() {
    int n = sum(1, 2);
    int m = sub(3, 2);

    puts("hello\n");
    printf("%d\t%d\n", n, m);

    return 0;
}