using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _20_ValidParentheses
        {
        public bool IsValid(string s)
            {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s.ToCharArray())
                {
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');
                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
                }
            return stack.Count == 0;
            }

        }
    }
