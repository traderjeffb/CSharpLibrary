using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_Single_Dimention_Arrays_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //            u can declare a single-dimensional array of five integers as shown in the following example:

            //     int[] array = new int[5];
            //This array contains the elements from array[0] to array[4]. The new operator is used to create the array 
            //                and initialize the array elements to their default values. In this example, all the 
            //                array elements are initialized to zero.


            //initialized with 5 elements all are initialized to zero
            //        int[] array = new int[5];


            int[] PhoneNumbers = new int[8];

            int[] Age = new int[50];

            int[] SoccerNum = new int[12];

            //String Init 
            string[] WoodTypes = new string[100];
            string[] Cars = new string[300];

            //declaring an array where rank specifier isn't needed bc it's already specified by number of elements 
            //in list
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };



            int[] Ages = new int[]{19, 22, 25, 32};

            int[] IDNumbers = new int[]{344,987,455,303};

            int[] JerseyNumbers = new int[] { 45, 12, 22, 98 };

            string[] Names = new string[] { "joe", "john", "jay" };

            string[] myList = new string[] { "goats", "hens", "lambs" };

            //declair without intitializing but must use new when initializing
            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };

            int[] ages;
            ages = new int[] { 44, 54, 33, 43 };

            string[] shoes;
            shoes = new string[] { "tennis", "flats", "heels" };

            //declaring multidemetional arrays
            int[,] array = new int[4, 2];

            int[,] lockNumbers = new int[4, 3];

            int[,,] threeD = new int[4,3,5];






        }
    }
}
