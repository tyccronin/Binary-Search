/* 
This program completes an iterative Binary Search
*/

using System;

class GUtil {
    // Returns an index of x if it is present in arr[], else return -1
    static int binarySearch(int[] arr, int x){
        
        int i = 0;
        int arrayLength = arr.Length - 1; 
       
        while (i <= arrayLength){
            
            int m = i + ((arrayLength)-i)/2;
    
            if(arr[m] == x){
                return m; // Check if x is present at mid
            }
            if(arr[m] < x){
                i = m + 1; // If x is greater, ignore left half
            } else {
                arrayLength = m-1;  // If x is smaller, ignore right half
            }
        }
        // If we get here, then the element was not present!
        return -1;
    }

    // Driver Code
    public static void Main(string[] args){
        int[] arr = {2, 3, 4, 10, 40};
        int n = arr.Length;
        int x = 10;
        int result = binarySearch(arr, x);
        if (result == -1){
            Console.WriteLine("Element not present!");
        } else {
            Console.WriteLine("Element found at " + "index " + result);
        }
    }
}

