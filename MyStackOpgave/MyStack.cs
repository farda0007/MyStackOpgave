﻿using System;
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
            return $"{{Hej med jer, jeg skriver lige her, og efter det her kommer lucas' to string :)}}";
            return $"{{Den her er forkert thomas jeg hader dig for at lave den forkert...}}";
            return $"{{slap liiiiige af broder}}";
        }

        //Lavet ny ToString

    }

    // yoyoyoyo

    //DDHDSA
    
}
// ny text
// Stop nu med at tilføje ting drenge >:(-

