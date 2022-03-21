//find out equality of matrix
//find out equality of matrix
//find out equality of matrix

using System;

public class EqualMatrix {
    public static void Main() {
        int row1, col1, row2, col2;
        Boolean flag = true;

        //intialize matrix a
        		// Two-dimensional array
		int[, ] a = new int[, ] {{1, 2},
										{3, 4},
										{5, 6},
										{7, 8}};
        		// Two-dimensional array
		int[, ] b = new int[, ] {{1, 2},
										{3, 4},
										{5, 6},
										{7, 8}};
        //calculate the number of rows and columns in the first matrix
        row1 = a.Length(0);
        col1 = a.Length(1);

        //calculates the number of rows and columns the present in the second matrix

        row2 = b.Length(0);
        col2 = b.Length(1);

        //check if dimension of both the matrix are equal
       if(row1 != row2 || col1 != col2) {
            Console.WriteLine("Matrix are not equal!!>>note:: usualy- dimension");
        }
        else {
              Console.WriteLine(row1); 
              Console.WriteLine(col1); 
              Console.WriteLine(row2); 
              Console.WriteLine(col2); 
        }
        /*
        else {
            for(int i = 0; i < row1; i++) {
                for(int j = 0; j < col1; j++) {
                    if(a[i][j] != b[i][j]) {
                        flag = false;
                        break;
                    }
                }
            }
        }
        
        if(flag) {
            Console.WriteLine("Matrices are equal\n");
        }
        else {
            Console.WriteLine("Matrices are not equal\n");
        }
        */
    }

}