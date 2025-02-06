using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV02
{
    internal class Program
    {
        //Q3
        public static Queue<int> ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        //Q4
        public static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> pairs = new Dictionary<char, char>
                {
                     { ')', '(' },
                     { '}', '{' },
                     { ']', '[' }
                };

            foreach (char chr in str)
            {
                if (chr == '(' || chr == '{' || chr == '[')
                {
                    stack.Push(chr);
                }
                else if (pairs.ContainsKey(chr))
                {
                    if (stack.Count == 0 || stack.Pop() != pairs[chr])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        public static void ReverseFirstKElements(Queue<int> queue, int K)
        {

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < K; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            for (int i = 0; i < queue.Count - K; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        } 

        static void Main(string[] args)
        {
            #region Q1
            //???
            #endregion


            #region Q2

            //Console.Write("Enter the size of the Array : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //ArrayList arr = new ArrayList();

            //Console.WriteLine("Enter the Elements:");
            //for (int i = 0; i < number; i++)
            //{
            //    arr.Add(Convert.ToInt32(Console.ReadLine()));
            //}

            //bool isPalindrome = true;
            //for (int i = 0; i < number / 2; i++)
            //{
            //    if ((int)arr[i] != (int)arr[number - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //    Console.WriteLine("Yes");

            //else
            //    Console.WriteLine("No");

            #endregion

            #region Q3

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine("Before " + string.Join(" ", queue));
            //queue = ReverseQueue(queue);

            //Console.WriteLine("After " + string.Join(" ", queue));

            #endregion


            #region Q4

            //Console.Write("Enter the string : ");
            //string input = Console.ReadLine();


            //if (IsBalanced(input))
            //    Console.WriteLine("Balanced");

            //else
            //    Console.WriteLine("Not Balanced");


            #endregion

            #region Q5

            //int[] arr = { 1, 3, 2, 3, 4, 1, 5, 6, 7,10, };

            //int[] uniqueArray = arr.Distinct().ToArray();

            //Console.WriteLine(string.Join(" "+ uniqueArray));


            #endregion

            #region Q6

            //List<int> numbers = new List<int> { 5, 6, 3, 4, 7 };


            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2 != 0)  
            //    {
            //        numbers.RemoveAt(i);  
            //        i--;  
            //    }
            //}

            //Console.WriteLine(string.Join(" ", numbers));  

            #endregion

            #region Q7
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (Object item in queue)
            //    Console.WriteLine(item);

            #endregion

            #region Q8

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(5);
            //stack.Push(40);
            //stack.Push(12);

            //Console.Write("Enter the target element : ");
            //int target = Convert.ToInt32(Console.ReadLine());

            //int count = 0;
            //bool found = false;

            //for (int i = 0; i < stack.Count; i++)
            //{
            //    int item = stack.Pop(); 
            //    count++;
            //    if (item == target)
            //    {
            //        found = true;
            //        break;
            //    }
            //}

            //if (found)
            //    Console.WriteLine($"Target was found successfully and the count = {count}");

            //else
            //    Console.WriteLine("Target was not found");

            #endregion

            #region Q9
            //??
            #endregion

            #region Q10
            //??
            #endregion

            #region Q11
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            int K = 3;

            ReverseFirstKElements(queue, K);
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            #endregion


        }
    }
}

