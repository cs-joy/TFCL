using System;
using System.Collections.Generic;
 
public class Example
{
    public static bool checkEquality<T>(T[] first, T[] second)
    {
        if (ReferenceEquals(first, second)) {
            return true;
        }
 
        if (first == null || second == null || (first.Length != second.Length)) {
            return false;
        }
 
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        for (int i = 0; i < first.Length; i++)
        {
            if (!comparer.Equals(first[i], second[i])) {
                return false;
            }
        }
 
        return true;
    }
 
    public static void Main()
    {
        int[] first = { 1, 2, 0, 4, 5 };
        int[] second = { 1, 2, 3, 4, 5 };
 
        if (checkEquality(first, second)) {
            Console.WriteLine("Both arrays are equal");
        }
        else {
            Console.WriteLine("Both arrays are not equal");
        }
    }
}
