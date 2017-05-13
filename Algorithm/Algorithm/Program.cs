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
            //LinkQueue queue1 = new LinkQueue();
            //queue1.EnQueue(1); queue1.EnQueue(2); queue1.EnQueue(3); queue1.EnQueue(4);
            //queue1.DeQueue(); queue1.DeQueue();
            //LinkQueue queue2 = new LinkQueue(10);
            //queue2.EnQueue(20); queue2.EnQueue(40); queue2.EnQueue(50); queue2.EnQueue(60);
            //queue2.DeQueue(); queue2.DeQueue();
            //LinkQueue queue3 = new LinkQueue();
            //queue3.EnQueue(new object[] { 11, 22, 33, 44, 55, 66, });
            //queue3.DeQueue(3);
            //queue3.ClearQueue();
            //queue1.Print(); Console.WriteLine($" {queue1.Front}----{queue1.Rear}---{queue1.Length}-{queue1.IsEmpty()}");
            //queue2.Print(); Console.WriteLine($"{queue2.Front}----{queue2.Rear}---{queue2.Length}-{queue2.IsEmpty()}");
            //queue3.Print(); Console.WriteLine($"{queue3.Front}----{queue3.Rear}---{queue3.Length}-{queue3.IsEmpty()}");
            #endregion

            #region LinkList

            //LinkList l1 = new LinkList();
            //l1.AddAfter("oh"); l1.AddAfter("my"); l1.AddAfter("God");
            //l1.AddAfter(new object[] { 11, 22, 33, 44, 55 });
            //l1.InsertAt(20, "hahaha");
            //l1.InsertAt(5, "ohohoh");
            //l1.DeleteAt(4);
            //object result=null;
            //l1.GetElementAt(7, ref result);
            //Console.WriteLine($"----------{result}----------");

            //LinkList l2 = new LinkList(100);
            //l2.AddAfter("I"); l2.AddAfter("IOVE"); l2.AddAfter("FEIFEI");
            //l2.InsertAt(20, new object[] { 10, 20, 30, 40, 50 });
            //l2.InsertAt(5, new object[] { "aa","bb","cc","dd" });
            //l2.DeleteAt(8);
            //LinkList l3 = new LinkList(new object[] { 1, 2, 3, 4, 5 });
            //l3.AddAfter("100"); l3.AddAfter("101"); l3.AddAfter("102");
            //l1.Print(); Console.WriteLine($"{l1.Count}--{l1.FirstNode}--{l1.LastNode}");
            //l2.Print(); Console.WriteLine($"{l2.Count}--{l2.FirstNode}--{l2.LastNode}");
            //l3.Print(); Console.WriteLine($"{l3.Count}--{l3.FirstNode}--{l3.LastNode}");
            //LinkList l4 = new LinkList();
            //l4.Print(); Console.WriteLine($"{l4.Count}--{l4.FirstNode}--{l4.LastNode}");
            #endregion
        }
    }
}
