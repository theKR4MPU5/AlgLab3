using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab3.Structures.Stack
{
    public static class StackExtensions
    {
        public static T Top<T>(this System.Collections.Generic.Stack<T> stack)
        {
            if (stack.Count > 0)
            {
                return stack.Peek();
            }

            return default; 
        }

        public static bool IsEmpty<T>(this System.Collections.Generic.Stack<T> stack)
        {
            return stack.Count == 0;
        }
    }

}
