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
    class LinkQueue
    {
        LinkQueueNode head = new LinkQueueNode(); //对头
        LinkQueueNode tail = new LinkQueueNode(); //对尾

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

        public void Print()
        {
            LinkQueueNode current = tail.next;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void EnQueue(object obj)
        {
            LinkQueueNode current = new LinkQueueNode();         
            current.data = obj;
            //  current.next = tail.next;
            tail.next = current;
            tail = current;
        }

        public void DeQueue()
        {
            LinkQueueNode current = head.next;
            head.next = current.next;
            current = null;
        }

        #endregion
    }
}
