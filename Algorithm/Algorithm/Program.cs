using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            //LinkStack linkStack = new LinkStack();
            //linkStack.Push(1);
            //linkStack.Push(2);
            //linkStack.Push(3);
            //linkStack.Print();
            //linkStack.Pop();
            //linkStack.Print();
            //linkStack.Pop();
            //linkStack.Print();
            //Console.WriteLine($"元素的个数为{linkStack.Count}");
            //linkStack.Push(100);
            //linkStack.Push(200);
            //linkStack.Push(5000);
            //linkStack.Print();
            //Console.WriteLine($"元素的个数为{linkStack.Count}");
            //Console.WriteLine($"栈顶为{linkStack.TopElement}");
            //Console.WriteLine($"栈底为{linkStack.GetTail()}");
            //linkStack.Push(600);
            //linkStack.Push(700);
            //linkStack.Push(800);
            //linkStack.Push(900);
            //IEnumerable<object> list = linkStack.ToEnumerable();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------");
            //LinkStack newStack = linkStack.Reverse();
            //newStack.Print();
            //Console.WriteLine("\n\n{0}  {1}", newStack.TopElement, newStack.TailElement);
            #endregion

            #region Queue
            LinkQueue queue1 = new LinkQueue();
            queue1.EnQueue(1); queue1.EnQueue(2); queue1.EnQueue(3); queue1.EnQueue(4);
            queue1.Print();
            #endregion
        }
    }
}
