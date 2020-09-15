using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne {
    class Program {

        static List<string> theList = new List<string>();
        static Queue iCAQueue = new Queue();
        static bool doLoop = true;

        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main() {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                if (input != '4')
                Console.WriteLine("To add item to the list type  +itemName    to remove item from list  type -itemName");
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        Console.WriteLine("to get a reversed text enter word");
                        Console.WriteLine(ReverseTextMetod());

                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList() {

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            //    bool doLoop = true;
            while (doLoop)
            {

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);


                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine("capacity" + theList.Capacity);
                        Console.WriteLine("elements " + theList.Count);
                        doLoop = false;
                        break;

                    case '-':
                        theList.Remove(value);
                        Console.WriteLine("capacity" + theList.Capacity);
                        Console.WriteLine("elements " + theList.Count);
                        doLoop = false;
                        break;

                    default: Console.WriteLine("Use only + or -  at the begining"); break;
                }
            }
        }



        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue() {


            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */


            while (doLoop)
            {

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);


                TestQueue();
                switch (nav)
                {
                    case '+':


                        iCAQueue.Enqueue(value);
                        PeopleInQueue();
                        doLoop = false;
                        break;


                    case '-':



                        iCAQueue.Dequeue();
                        PeopleInQueue();
                        doLoop = false;
                        break;

                    default: Console.WriteLine("Use only + or -  at the begining"); break;

                }

            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        /// 




        static void ExamineStack() {
            Stack myStack = new Stack();
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */



            while (doLoop)
            {

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);


                switch (nav)
                {
                    case '+':
                        myStack.Push(value);


                        doLoop = false;
                        break;

                    case '-':

                        myStack.Pop();

                        doLoop = false;
                        break;


                    default: Console.WriteLine("Use only + or -  at the begining"); break;
                }



            }

        }


        static void PeopleInQueue() {

            Console.WriteLine("people in queue");
            foreach (var cutomer in iCAQueue)
            {
                Console.WriteLine(cutomer);
            }
        }

        static void TestQueue() {

            iCAQueue.Enqueue("Kalle");
            iCAQueue.Enqueue("Greta");
            iCAQueue.Dequeue();
            iCAQueue.Enqueue("Stina");
            iCAQueue.Dequeue();
            iCAQueue.Enqueue("Ole");



        }


        static string ReverseTextMetod() {
            Stack myStack = new Stack();
            string reversedInput = "";
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                myStack.Push(input[i]);
            }

            foreach (var item in myStack)
            {
                reversedInput += item;
            }

            return reversedInput;



        }
        static void CheckParanthesis() {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            List<char> list_Of_Open_Paranthesis = new List<char>() { '<', '{', '[', '(' };
            List<char> list_Of_Close_Paranthesis = new List<char>() { '>', '}', ']', ')' };
            List<char> myList = new List<char>();
            string input = "(()), {}, [({})],";
            //int listSize = myList.Count;
            char hold =' ';

           
            
          




            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < list_Of_Open_Paranthesis.Count; j++)
                {
                      if (input[i] == list_Of_Open_Paranthesis[j])
                    {
                            hold = input[i];
                      
                        myList.Add(input[i]);
                    }
                        else if (input[i] == list_Of_Close_Paranthesis[j] & hold == list_Of_Open_Paranthesis[j])
                        { 
                      
                        myList.Remove(hold);
                      

                    }
                
        
                    }
                            }

            if (myList.Count == 0)
                Console.WriteLine("correct order");
            else
                Console.WriteLine("not  correct order");
            foreach (var item in myList) Console.WriteLine(item);
            {

            }
        }  
    
    
   
    
    }
}


