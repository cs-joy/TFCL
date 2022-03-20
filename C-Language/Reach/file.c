// C program to find the size of file
#include <stdio.h>

long int findSize(char file_name[])
{
	// opening the file in read mode
	FILE* fp = fopen(file_name, "r");

	// checking if the file exist or not
	if (fp == NULL) {
		printf("File Not Found!\n");
		return -1;
	}

	fseek(fp, 0L, SEEK_END);

	// calculating the size of the file
	long int res = ftell(fp);

	// closing the file
	fclose(fp);

	return res;
}

// Driver code
int main()
{
	char file_name[] = { "secF.c" };
	long int res = findSize(file_name);
	if (res != -1)
		printf("Size of the file is %ld bytes \n", res);
	return 0;
}
