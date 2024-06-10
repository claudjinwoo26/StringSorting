using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorting
{

    public class QuickSort : SortingStratInterface
    {
        //Here I'm performing the logic of the Quick sort that I will use and also accessing the interface

        public string Sort(string input)
        {
            //Converting the string input to array making it so that it can be sorted
            char[] chars = input.ToCharArray();
            //Calling method to sort char from start to end
            QuickSortRecursive(chars, 0, chars.Length - 1);
            //Converting char array to string
            return new string(chars);
        }
        //Startpoint is low endpoint is High
        //Created a method which performs recursion for the quick sort
        private void QuickSortRecursive(char[] arr, int startPoint, int endPoint)
        {
            //Checking if the starting point is less than the end point 
            if (startPoint < endPoint)
            {
                //Using partition to divide the chars around the pivot 
                //the pi is the position where pivot is placed
                int pi = Partition(arr, startPoint, endPoint);
                //sorting the letters on the left side of the pivot (from low to pi - 1).
                QuickSortRecursive(arr, startPoint, pi - 1);
                // sorting the letters on the right side of the pivot (from pi + 1 to high).
                QuickSortRecursive(arr, pi + 1, endPoint);
            }
        }
        //creating another private method helper to help with dividing the letters.
        private int Partition(char[] arr, int startPoint, int endPoint)
        {
            char pivot = arr[endPoint];
            int i = (startPoint - 1);
            for (int j = startPoint; j < endPoint; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            char temp1 = arr[i + 1];
            arr[i + 1] = arr[endPoint];
            arr[endPoint] = temp1;
            return i + 1;
        }
      

        
        
       
    }

}
