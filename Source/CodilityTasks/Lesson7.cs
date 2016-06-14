using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTasks
{
    public static class Lesson7
    {
        /// <summary>
        /// You are given a zero-indexed array A consisting of n integers: a[0], a[1], ... , a[n−1].
        /// Array A represents a scenario in a grocery store, and contains only 0s and/or 1s:
        ///• 0 represents the action of a new person joining the line in the grocery store,
        ///• 1 represents the action of the person at the front of the queue being served and leaving
        /// the line.
        /// The goal is to count the minimum number of people who should have been in the line before
        /// the above scenario, so that the scenario is possible (it is not possible to serve a person if the
        /// line is empty).
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GroceryStore(byte[] array)
        {
            int n = array.Length;
            int size = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    size++;
                }
                else
                {
                    size--;
                    result = Math.Max(result, -size);
                }
            }
            return result;
        }

        /// <summary>
        /// Determine whether a given string of parentheses is properly nested.
        /// given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.
        /// </summary>
        /// <param name="s">N is an integer within the range [0..200,000];
        /// string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")"</param>
        /// <returns></returns>
        public static int Brackets(string S)
        {
            int n = S.Length;
            char[] chars = S.ToCharArray();
            var stack = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string c = chars[i].ToString();
                if (c == "{" || c == "[" || c == "(")
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }
                    string left = stack.Pop();
                    var pair = left.Insert(1, c);
                    if (pair != "{}" && pair != "[]" && pair != "()")
                    {
                        return 0;
                    }
                }
            }
            return stack.Count == 0 ? 1 : 0;
        }
    }
}