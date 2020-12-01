using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class GenericStack
    {
        
        public void AddElement(Stack<String> str, string s)
        {
            str.Push(s);
        }
        public void getelement(Stack<String> str)
        {
            Console.WriteLine(str.Pop());
        }
        public void sortStack(Stack<String> stk)
        {
            
            string[] st1 = stk.ToArray();
            Array.Sort(st1);
            foreach(string s1 in st1)
            {
                Console.WriteLine(s1); ;
            }
        }
        public void reverse(Stack<String> str)
        {
            str.Reverse();
        }
        public void searchelement(Stack<String> str, string s)
        {
            if(str.Contains(s) == true)
            {
                Console.WriteLine("Element Found.");
            }
        }
        public void Displayelement(Stack<String> str)
        {
            foreach (String item in str)
            {
                Console.WriteLine(item);
            }
        }
    }
}
