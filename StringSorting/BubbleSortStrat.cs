using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorting
{
    //Here I'm performing the logic of the bubble sort that I will use and also accessing the interface
    public class BubbleSortStrat : SortingStratInterface
    {
        public string Sort(string input)
        {
            //Converting the string input to array making it so that it can be sorted
            char[] chars = input.ToCharArray();

            //Iterating to count the number of characters inputted by the user
            //First Char Counter
            for (int i = 0; i < chars.Length; i++) 
            {
                //Second Char Counter to compare each char to the next
                for (int j = 0; j < chars.Length - i - 1; j++) 
                {
                    //Checking if current character is greater than the next character
                    if (chars[j] > chars[j + 1]) 
                    {
                        //Save current character/iteration of the 2nd counter
                        char temp = chars[j];

                        //Swap position logic
                        chars[j] = chars[j + 1];
                        chars[j + 1] = temp;
                    }
                }
            }
            //Converting the array to string again
            return new string(chars);
        }
    }
}
