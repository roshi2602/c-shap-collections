﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace c_shap_collections
{
    /*
    //generics
    //it allows us to create classes using angular bracketsfor data types. and at compliation time these angular brackets will get replaced with some data types


    //   T is called type parameter, which can be used as a type of fields,
    //    properties, method parameters, return types in the DataStore class
    //Type is for T
    //generics is for Typesafety*/


    //------------------------------------------------



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
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }


            int a = 0;
            //assigning values to array
            for (int i = 0; i < 5; i++)
            {
                a += 10;
                arr[i] = a;
            }

            //foreach loop for accessing values to array
            foreach (int i in arr)
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
            Array.Copy(ar, ba, 5);     //5 elements we will copy out 0f 15 elements

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
            foreach (int x in aa)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");           //printing it in new line

            //printing values of array using nested loop
            for (int i = 0; i < aa.GetLength(0); i++)
            {
                for (int j = 0; j < aa.GetLength(1); j++)
                {
                    Console.WriteLine(aa[i, j]);
                }
            }

            Console.ReadLine();

            //output --(in form of row and column)
            //      10 20 30 40 50 60 70 80 90
            //      10 20 30 40 50 60 70 80 90 

            //------------------------------------------------


            //ArrayList
            //for dynamic resizing ,adding,deleting elements in middle of collection
            //methods used are- add(), remove(),removeAt(),Insert, Capacity
            //  NOTE- At top import -using System.Collections;

            //creating arraylist
            ArrayList al = new ArrayList();
            Console.WriteLine("initial capacity" + al.Capacity); //capacity -to specify how many elements u can enter in collection


            //now add object to collection using add()
            al.Add(10);
            Console.WriteLine("capacity after adding first item" + al.Capacity);      //capacity after adding first item

            al.Add("hi");
            al.Add("true");
            Console.WriteLine("capacity after adding third item" + al.Capacity);      //capacity after adding third item



            //printing array elements using loop
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);

            }

            Console.WriteLine(); //to print elements

            //now we will remove element from arraylist
            al.Remove("hi");    //remove hi

            //now print array elemnents after removing an element
            foreach (object y in al)
            {
                Console.WriteLine(y);
            }

            Console.WriteLine(); //to print elements
            Console.ReadLine();


            /*output= 5
            
            initial capacity0
            capacity after adding first item4
            capacity after adding third item4
            10
            hi
           true
            10
            true
            */



            //------------------------------------------------

            //HashTable
            //stores key value pairs

            //creating HashTable
            Hashtable ht = new Hashtable();

            //adding elemnets using key value pairs
            ht.Add("eid", 1);  //eid is key and 1 is value
            ht.Add("ename", "roshi");
            ht.Add("edept", "it");
            Console.WriteLine(); //printing it

            //now accesing the elements using foreach
            foreach (Object oo in ht.Keys)        //will work using keys
            {
                Console.WriteLine(ht[oo]);
            }
            Console.WriteLine(); //printing it
            Console.ReadKey();



            //------------------------------------------------

            //stack
            //LIFO
            //item added last will remove first
            //methods- push(),pop(),peek()
            //push()-is used to insert objects on top
            //pop()-is used to remove and return object on top 
            //peek()-is used to return object on top without removing

            //create stack
            Stack st = new Stack();

            //adding item using push
            st.Push(1);
            st.Push(2);
            st.Push(true);
            st.Push("hello");

            //printing stack items
            foreach (object oj in st)
            {
                Console.WriteLine(oj);
            }

            Console.WriteLine(); //printing it

            /*output till here = hello
True
2
1 */

            //remove and return item from stack
            Console.WriteLine(st.Pop());
            Console.WriteLine(); //printing it

            /*output till here = hello*/


            //now using peek()     -to return last item without removing it
            Console.WriteLine(st.Peek());
            Console.WriteLine(); //printing it

            /*output till here= True*/

            //now access the items after using peek()

            foreach (object oj in st)
            {
                Console.WriteLine(oj);
            }

            /*output till here=   
True
2
1*/
            Console.ReadLine();


            //------------------------------------------------

            //queue
            //First in first out items in collection
            //item added first will be removed first
            //methods- Enqueue(), Dequeue(),peek()


            //     create queue
            Queue qu = new Queue();

            //adding items to queue using Enqueue()
            qu.Enqueue(55);
            qu.Enqueue(56);
            qu.Enqueue("all");
            qu.Enqueue(true);

            //printing items 
            foreach (object c in qu)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(); //printing it

            /*output till here= 55
             56
            all
            true*/

            //now removing and returning item from queue
            //using deque()
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(); //printing it

            /*output till here= 55(first element)*/

            //now printing  items after removing first element

            foreach (object c in qu)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(); //printing it

            /*output till here= 56
             all
            true*/


            //now returning first item without removing it
            Console.WriteLine(qu.Peek());
            Console.WriteLine(); //printing it

            /*output till here= 56*/

            //printing after peek

            foreach (object c in qu)
            {
                Console.WriteLine(c);
            }

            /*output= 56
all
True*/

            Console.ReadLine();


            //------------------------------------------------

            //sort list of simple type
            //syntax- List<int> numlist = new List<int>{1,2,3,4}
            //numlist.Sort() --to sort data
            //numlist.Reverse() --to revrse data


            List<int> numlist = new List<int> { 35, 31, 33, 38, 42, 56, 69, 12 };  //list of int type, can also be string
            Console.WriteLine("printing");     //print it

            //print the items
            foreach (int t in numlist)
            {
                Console.WriteLine(t);
            }

            //now apply Sort()
            numlist.Sort();
            Console.WriteLine("printing after sorting");     //print it

            //printint after sorting
            foreach (int t in numlist)
            {
                Console.WriteLine(t);
            }

            //now apply reverse()
            numlist.Reverse();
            Console.WriteLine("printing after reversing");     //print it

            //printint after sorting
            foreach (int t in numlist)
            {
                Console.WriteLine(t);
            }
            Console.ReadLine();

            //------------------------------------------------
            /*
            //generic class list methods
            //TrueForAll()- it returns true or false depending on if every element in list matches the condition

            //AsReadOnly()- it will not add or remove elements

            //TrimExcess()-it sets actual number of capacity in list

            //create Employee class first above (line 40)
            Employee emp1 = new Employee()            //details for employee1
            {
                ID = 100,
                name = "roshi",
                gender = "female"
            };


            Employee emp2 = new Employee()            //details for employee2
            {
                ID = 101,
                name = "sakshi",
                gender = "female"
            };

            //now create list of simple type for Employee class
            List<Employee> emplist = new List<Employee>(100); //of size 100

            //addingt details to list
            emplist.Add(emp1);
            emplist.Add(emp2);

            Console.WriteLine("printing");

            //now applying generic list methods

            //first setup ReadOnlyCollection
            System.Collections.ObjectModel.ReadOnlyCollection<Employee> reademployees = emplist.AsReadOnly();

            /* The ReadOnlyCollection in the System.Collections.ObjectModel namespace functions as a wrapper for any collection that implements IList(T).
             * It does not copy elements. 
             * Instead it adds a level of indirection that reduces possible changes.*/

            //print it now
            // Console.WriteLine("read only employees", );

            //------------------------------------------------

            //dictionary
            //is used to specify key value pairs but we need to tell type of keys and type of values
            //first import using System.Collections.Generic;
            //methods - count(), remove(), clear()


            //dictionary collection class

            //create dictionary having key value pairs
            Dictionary<string, object> d = new Dictionary<string, object>();

            //add keys and values to dictionary
            d.Add("fid", 1);
            d.Add("fname", "payal");
            d.Add("floc", "pune");

            //loop to get values
            foreach (string e in d.Keys)
            {
                Console.WriteLine(e + "-" + d[e]);      //for key + value separated by "-" in output
            }
            Console.WriteLine();//printing it

            //remove one key with value from dictionary

            d.Remove("two");    //remove key "two"

            //now print again
            foreach (string e in d.Keys)
            {
                Console.WriteLine(e + "-" + d[e]);   //for key + value separated by "-" in output
            }
            Console.ReadLine();

            /*output = one
                           three*/

            //------------------------------------------------
            //generic stack

            //works on LIFO
            //to insert an item from top of stack- push()
            //to remove/return that item on top of stack-pop()
            //to check item exists in top of stack -contains()


            //first create class Employ down side
            //create employee object
            Employee e1 = new Employee()
            {
                ID = 10,
                Name = "varun",
                Salary = 5200
            };

            //for second employee

            Employee e2 = new Employee()
            {
                ID = 20,
                Name = "pallav",
                Salary = 8900
            };

            //create generic stack for employee
            Stack<Employee> se = new Stack<Employee>();

            //push method
            se.Push(e1);
            se.Push(e2);
            Console.Write("employees");

            //access after push method()
            foreach(Employee y in se)
            {
                Console.WriteLine( y.ID+y.Name+ y.Salary);
            }
            Console.WriteLine();         //printing it

            //use pop() method

            Employee empp1 = se.Pop();           //pop for employee1
            Console.WriteLine(empp1.ID+ empp1.Name+ empp1.Salary);       //print them


            Employee empp2 = se.Pop();           //pop for employee2
            Console.WriteLine(empp2.ID+ empp2.Name+ empp2.Salary);       //print them



            //now count items left in stack
            Console.WriteLine("items left", se.Count);
            //now there are no items left in stack

            //so push the items again
            se.Push(e1);
            se.Push(e2);
            Console.WriteLine("pushing items again");

            //use peek method now

            Employee ep1 = se.Peek(); //for employee1
            Console.WriteLine(ep1.ID + ep1.Name + ep1.Salary);


            Employee ep2 = se.Peek(); //for employee2
            Console.WriteLine(ep2.ID + ep2.Name + ep2.Salary);

            Console.WriteLine("items left ");

            //to check if item exists or not use contains() method

            if (se.Contains(ep1))
            {
                Console.WriteLine("ep1 in stack");
            }

            Console.ReadLine();

            /*output = employees20pallav8900
10varun5200

20pallav8900
10varun5200
items left
pushing items again
20pallav8900
20pallav8900
items left
ep1 in stack*/



            //------------------------------------------------
            //conversion in dictionary
            //convert array to list- ToList()
            //convert list to array- ToArray()
            //convert list to dictionary- ToDictionary()
            //convert array to dictionary-  ToDictionary()
            //Convert a Dictionary to an array -ToArray()
            //Convert a Dictionary to a List-ToList()


            //first create class Employee down side

            //create object for employe
            /*Employ e1 = new Employ();
            
            {
                Salary = 26000,

            };
            */

            //Create Employee object
            Employee emp1 = new Employee()
            {

                ID = 100,
                Name = "shivani",
                Salary = 2500
            };


            //for next employee
            Employee emp2 = new Employee()
            {

                ID = 100,
                Name = "shivani",
                Salary = 2500
            };


            //create array of employee of size 2
            //and store 2 employees in array
            Employee[] ep = new Employee[2];
            ep[0] = emp1;
            ep[1] = emp2;

            //now convert array to list
            List<Employee> el = ep.ToList();

            //access them now
            foreach(Employee x in el)
            {
                Console.WriteLine("id ={0}, name ={1}, salary =  {2}", x.ID,x.Name, x.Salary);
            }

            Console.WriteLine();  //print them
        

            Console.ReadLine();

        }
    }
    //-------------------------------------------------------
    //conversion in dictionary ,    //generic stack

    //first create class
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }
    
}