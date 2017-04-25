using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    /// <summary>
    /// 表示单链表的节点
    /// </summary>
    public class LinkListNode
    {
        public object data;
        public LinkListNode next;
    }

    /// <summary>
    /// 单链表类
    /// </summary>
    public class LinkList
    {
        private LinkListNode head = new LinkListNode();
        private LinkListNode tail = new LinkListNode();

        #region 属性
        /// <summary>
        /// 节点个数属性
        /// </summary>
        public int Count
        {
            get { return GetCount(); }
        }

        /// <summary>
        /// 头结点
        /// </summary>
        public object FirstNode
        {
            get { return head.next.data; }
        }

        /// <summary>
        /// 尾节点
        /// </summary>
        public object LastNode
        {
            get { return tail.data; }
        }

        #endregion

        #region 操作方法

        /// <summary>
        /// 构造函数,构造无参数的构造函数，即一个空链表
        /// </summary>
        public LinkList()
        {
            head.next = null;
            tail = head;  //没有元素的时候，头结点和尾节点是一个
        }

        /// <summary>
        /// 有一个节点的链表
        /// </summary>
        /// <param name="s"></param>
        public LinkList(object s)
        {  
                                                //第一步，创建一个尾节点，并且将头节点赋值给它
                                                //       头结点只包含一个指针，是不包含内容的哦
            LinkListNode newNode = new LinkListNode();          //第二部，创建一个全新的节点
            newNode.data = s;                   //       给新创建的节点赋予内容，
            head.next = newNode;                //       将头结点（尾节点）指针指向新的节点                  
            tail = newNode;                     //第三步，重新给尾节点赋予新的节点值
        }

        /// <summary>
        /// 以一个数组为参数，构造一个链表
        /// </summary>
        /// <param name="source"></param>  
        public LinkList(object[] source)
        {
            LinkListNode current;
            current = head;
            for (int i = 0; i < source.Length; i++)
            {
                LinkListNode newNode = new LinkListNode();
                newNode.data = source[i];
                current.next = newNode;
                current = newNode;
            }
            current.next = null;
            tail = current;
        }

        /// <summary>
        /// 在链表后面添加一个节点
        /// </summary>
        /// <param name="data"></param>
        public void AddAfter(object data)
        {
            LinkListNode current = new LinkListNode();
            current.data = data;
            tail.next = current;
            tail = current;
        }
        #endregion

        #region 与属性相关的方法
        private int GetCount()
        {
            int count = -1;    //之所以等于-1.是因为这里的单链表都是包含“头指针”的，
            LinkListNode p = head;     //而头指针只包含一个指向第一节点的指针，并不包含内容
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

        #region 打印链表
        public void PrintLinkList()
        {
            string info = "";
            LinkListNode p = head.next;
            if (p == null)
            {
                info = "该链表是一个空链表";
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
        #endregion

    }
}
