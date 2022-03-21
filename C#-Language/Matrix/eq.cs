//find out equality of matrix

using System;

public class EqualMatrix {
    public static void Main() {
       int row1, col1, row2, col2;
        Boolean flag = true;

        //intialize matrix a
        		// Three-dimensional array
        int[,,] a = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
        //intialize matrix a
              // Three-dimensional array
		int[,,] b = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
        //calculate the number of rows and columns in the first matrix
        row1 = a.GetLength(0);
        col1 = b.GetLength(1);

        //calculates the number of rows and columns the present in the second matrix

        row2 = a.GetLength(0);
        col2 = b.GetLength(1);

        //check if dimension of both the matrix are equal
       if(row1 != row2 || col1 != col2) {
            Console.WriteLine("Matrix are not equal!!>>note:: usualy- dimension");
        }
       
        else {
            for(int i = 0; i < 2; i++) {
                for(int j = 0; j < 2; j++) {
                    for(int k = 0; k < 2; k++) {
                        if(a[i, j, k] != b[i, j, k]) {
                            flag = false;
                            break;
                        }
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
        
    }

}