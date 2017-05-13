using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class LinkQueueNode
    {
        public object data;
        public LinkQueueNode next;
    }
    public class LinkQueue
    {
        LinkQueueNode head = new LinkQueueNode(); //对头
        LinkQueueNode tail = new LinkQueueNode(); //对尾

        #region 属性
        public int Length
        {
            get { return GetLength(); }
        }
        public object Front
        {
            get
            { if (head.next != null)
                      return head.next.data; 
                  else
                    return "空队列";
            }
        }
        public object Rear
        {
            get
            { if (tail != null)
                    return tail.data;
                else
                    return "空队列";
            }
        }
        #endregion

        #region 操作方法

        /// <summary>
        /// 初始化一个链式存储的队列，初始化一个空队列
        /// </summary>
        public LinkQueue()
        {
            head.next = null;
            tail = head;
        }

        /// <summary>
        /// 初始化具有一个节点的对象
        /// </summary>
        /// <param name="obj"></param>
        public LinkQueue(object obj)
        {
            LinkQueueNode current = new LinkQueueNode();
            current.data = obj;
            head.next = current;
            current.next = null;
            tail = current;
        }

        /// <summary>
        /// 打印一个链式队列
        /// </summary>
        public void Print()
        {
            string info = "";
            LinkQueueNode p = head.next;
            if (p == null)
            {
                info = "该队列是一个空队列";
            }
            else
            {
                while (p != null)
                {
                    info += p.data + " ";
                    p = p.next;
                }
            }
            Console.WriteLine(info);
        }

        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="obj"></param>
        public void EnQueue(object obj)
        {
            LinkQueueNode current = new LinkQueueNode();
            current.data = obj;
            tail.next = current;
            tail = current;
        }

        /// <summary>
        /// 一次入队多个元素
        /// </summary>
        /// <param name="array"></param>
        public void EnQueue(object[] array)
        {
            LinkQueueNode current;
            for (int i = 0; i < array.Length; i++)
            {
                current = new LinkQueueNode();
                current.data = array[i];
                tail.next = current;
                tail = current;
            }
        }

        /// <summary>
        /// 出队
        /// </summary>
        public void DeQueue()
        {
            LinkQueueNode current = head.next;
            head.next = current.next;
            current = null;
        }

        /// <summary>
        /// 一次出队多个元素
        /// </summary>
        /// <param name="num"></param>
        public void DeQueue(int num)
        {
            for (int i = 0; i < num; i++)
            {
                LinkQueueNode current = head.next;
                head.next = current.next;
                current = null;
            }
        }

        /// <summary>
        /// 请空队列
        /// </summary>
        public void ClearQueue()
        {
            while (head.next!=tail)
            {
                LinkQueueNode current = head.next;
                head.next = current.next;
                current = null;
            }
            tail = null;
            head.next = null;
        }

        /// <summary>
        /// 判断是否为空队列
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (head.next == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 获得队列元素的个数
        /// </summary>
        /// <returns></returns>
        private int GetLength()
        {
            int count = -1;    //之所以等于-1.是因为这里的单链表都是包含“头指针”的，
            LinkQueueNode p = head;     //而头指针只包含一个指向第一节点的指针，并不包含内容
            if (p == null)
            {
                return 0;
            }
            else
            {
                while (p != null)
                {
                    count++;
                    p = p.next;
                }
                return count;
            }
        }

        #endregion
    }
}
