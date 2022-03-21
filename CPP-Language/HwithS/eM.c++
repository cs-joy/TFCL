//equality of matrix

#include <iostream>
using namespace std;
   
int main()  
{  
    int row1, col1, row2, col2;  
    bool flag = true;  
      
    //Initialize matrix a  
    int a[][3] = {     
                    {1, 2, 3},  
                    {8, 4, 6},  
                    {4, 5, 7}  
                };  
                
    //Initialize matrix b  
    int b[][3] = {     
                    {1, 2, 3},  
                    {8, 4, 6},  
                    {4, 5, 7}   
                };  
    
      
    //Calculates number of rows and columns present in first matrix  
    row1 = (sizeof(a)/sizeof(a[0]));  
    col1 = (sizeof(a)/sizeof(a[0][0]))/row1;  
      
    //Calculates number of rows and columns present in second matrix  
    row2 = (sizeof(b)/sizeof(b[0]));  
    col2 = (sizeof(b)/sizeof(b[0][0]))/row2;  
      
    //Checks if dimensions of both the matrices are equal  
    if(row1 != row2 || col1 != col2){  
        printf("Matrices are not equal(firsr order != second order)\n");  
    }  
    else{  
        for(int i = 0; i < row1; i++){  
            for(int j = 0; j < col1; j++){  
              if(a[i][j] != b[i][j]){  
                  flag = false;  
                  break;  
              }  
            }  
        }  
          
        if(flag)  
            printf("Matrices are equal\n");  
        else  
            printf("Matrices are not equal(elements are not same)\n");
    }      
    return 0;  
}  