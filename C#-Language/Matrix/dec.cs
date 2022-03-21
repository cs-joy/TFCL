// C# program to find the total
// number of elements in the
// multidimensional Arrays
using System;
namespace geeksforgeeks {

class GFG {

	// Main Method
	public static void Main()
	{

		// Two-dimensional array
		int[, ] intarray = new int[, ] {{1, 2},
										{3, 4},
										{5, 6},
										{7, 8}};

		// The same array with dimensions
		// specified 4 row and 2 column.
		int[, ] intarray_d = new int[4, 2] {{ 1, 2},
											{3, 4},
											{5, 6},
											{7, 8}};

		// Three-dimensional array.
		int[,, ] intarray3D = new int[,, ] {{{ 1, 2, 3},
											{ 4, 5, 6}},
											{{ 7, 8, 9},
										{10, 11, 12}}};

		// The same array with dimensions
		// specified 2, 2 and 3.
		int[,, ] intarray3Dd = new int[2, 2, 3] {{{1, 2, 3},
												{4, 5, 6}},
												{{ 7, 8, 9},
											{10, 11, 12}}};

		Console.Write("Total Number of Elements in intarray: ");

		// using Length property
		Console.Write(intarray.Length);

		Console.Write("\nTotal Number of Elements in intarray_d: ");

		// using Length property
		Console.Write(intarray_d.Length);

		Console.Write("\nTotal Number of Elements in intarray3D: ");

		// using Length property
		Console.Write(intarray3D.Length);

		Console.Write("\nTotal Number of Elements in intarray3Dd: ");

		// using Length property
		Console.Write(intarray3Dd.Length);
        Console.Write("\n");
	}
}
}
