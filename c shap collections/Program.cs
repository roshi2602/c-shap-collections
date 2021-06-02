using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_shap_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            //--------------------------------------------------------------
            //1 D array-data in form of rows in sequential order
          
            //creating array
            int[] arr = new int[5];  //array of size 5

            //for loop for accessing values from array and assign values to array
            for (int i=0; i<5; i++) {
                Console.WriteLine(arr[i]);
            }


            int a = 0;
            //assigning values to array
            for (int i = 0; i < 5; i++)
            {
                a +=  10;
                arr[i] = a;
            }

            //foreach loop for accessing values to array
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
                Console.ReadLine();
          

            //--------------------------------------------------------------
            //array values
            //sort, reverse,copy, getLength

            //declaring array
            
            int[] ar = { 1, 23, 4, 5, 67, 7, 89 };
            Console.WriteLine("array elements");         //printing array elemets

            for (int j = 0; j < ar.Length; j++)
            {
                Console.WriteLine(ar[j]);
            }
            Console.WriteLine();
          //sorting in array
           Array.Sort(ar);
          Console.WriteLine("sorted elemets");
            Array.Reverse(ar);
            Console.WriteLine("reverse elemets");



            //foreach for accessing values
            foreach (int j in ar)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine();  //printing it

            //create new array
            int[] ba = new int[15];
            Array.Copy(ar, ba,5);     //5 elements we will copy out 0f 15 elements

            //access it now
            foreach (int j in ba)
            {
                Console.WriteLine(j);
            }
 
           Console.ReadLine();

            //--------------------------------------------------------------

            //2d array -to store elements in rows and columns
            //rectangular array

            //assigning array elements for declaration
            int[,] aa = {{ 10, 20, 30 },                        //int [,]  -syntax for rectangular array
                { 40,50,60},
                { 70,80,90} };

           //access it
           foreach(int x in aa)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");           //printing it in new line

            //printing values of array using nested loop
            for (int i = 0; i < aa.GetLength(0);i++)
            {
                for (int j=0; j <aa.GetLength(1); j++)
                {
                    Console.WriteLine(aa[i, j]);
                }
            }

            Console.ReadLine();

            //output --(in form of row and column)
            //      10 20 30 40 50 60 70 80 90
            //      10 20 30 40 50 60 70 80 90 

            //------------------------------------------------
        }
    }
}
