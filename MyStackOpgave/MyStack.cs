using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyStackOpgave
{
    public class MyStack
    {
        private int top = 0;
        private int[] stack = new int[5];

        public void Push(int element)
        {
            if (top > 5)
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                Push(element);
                top++; 
               
            }
        }
        // heheheheheheheheheh
        public int Pop(int element)
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
                top--; Pop(element);
            return element;
        }

        public override string ToString()
        {
            return $"{{Den her er forkert thomas jeg hader dig for at lave den forkert...}}";
        }

        //Lavet ny ToString

    }

    // yoyoyoyo


    
}
// ny text
// Stop nu med at tilføje ting drenge >:(-

