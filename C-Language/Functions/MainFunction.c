/*
Reference of notes :: https://en.cppreference.com/w/c/language/main_function

# Every C program coded to run in a hosted execution environment contains the definition (not the prototype) of a function 
  called main, which is the designated start of the program.
  ----------------------------
    1. int main(void) {body}
        2. int main(int argc, char *argv[]) {body}
            3. another implementation-defined signature (since C99)	

*/

#include <stdio.h>

int main(int argc, char *argv[]) {
    printf("argc = %d\n", argc);
    for(int ndx = 0; ndx != argc; ++ndx)
        printf("argv[%d]  --> %s\n", ndx, argv[ndx]);
    printf("argv[argc] = %p\n", (void*)argv[argc]);
}