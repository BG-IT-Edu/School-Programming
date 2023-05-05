using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
   public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public Stack<string> AddRange(Stack<string> range)
        {
            while (range.Count > 0)
            {
                this.Push(range.Pop());
            }
            return this;
        }
    }
}
