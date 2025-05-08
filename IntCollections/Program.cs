using System;
using System.Collections.Generic;
using System.Text;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // List<T>, Stack<T>, Queue<T> e HashSet<T>
            List<int> list = new List<int>() { 5, 10, 20, 50, -10 };
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(100);
            hashSet.Add(5);
            hashSet.Add(20);

            PrintCollection(list);
            PrintCollection(stack);
            PrintCollection(queue);
            PrintCollection(hashSet);
        }
        
        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            string fullName = collection.GetType().Name;
            int backtickIndex = fullName.IndexOf('`');
            if (backtickIndex > 0) fullName = fullName.Substring(0, backtickIndex);
            StringBuilder stringBuilder = new StringBuilder($"{fullName}: ");
            int count = 0;
            foreach (var item in collection)
            {
                stringBuilder.Append(item + ", ");
                count++;
            }

            if (count == 0) stringBuilder.Append("None  ");
            Console.WriteLine(stringBuilder.ToString().Substring(0, stringBuilder.Length - 2));
        }
    }
}
