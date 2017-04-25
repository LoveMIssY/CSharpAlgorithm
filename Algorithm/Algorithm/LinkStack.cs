using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    /// <summary>
    /// 自定义一个存储栈的节点类型
    /// </summary>
    public class LinkStackNode
    {
        public object data;
        public LinkStackNode next;
    }
 
    /// <summary>
    /// 自定义一个类，用来表示链式存储的栈，C#原生态的Stack<T>是采用顺序存储的
    /// </summary>
    public class LinkStack
    {
        LinkStackNode head = new LinkStackNode();

        #region 属性跟字段
        private int count;
        /// <summary>
        /// 表示栈中存放的节点的个数，它是只读的
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }
        }

        /// <summary>
        /// 获取栈顶元素的属性
        /// </summary>
        public object TopElement
        {
            get { return GetTop(); }
        }

        /// <summary>
        /// 获取栈底元素的属性
        /// </summary>
        public object TailElement
        {
            get { return GetTail(); }
        }

        #endregion

        #region 操作方法

        /// <summary>
        /// 栈的初始化，头结点一般是不存储数据的
        /// </summary>
        public LinkStack()
        {
            head.next = null;                     
        }

        /// <summary>
        /// 判断是否是空栈
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head.next == null;
        }

        /// <summary>
        /// 栈的遍历
        /// </summary>
        public void Print()
        {
            LinkStackNode current = new LinkStackNode();
            current = head.next;
            while (current != null)
            {              
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        /// <summary>
        /// 入栈操作
        /// </summary>
        /// <param name="data">入栈的数据</param>
        public void Push(object data)
        {
            LinkStackNode current = new LinkStackNode();
            current.data = data;
            current.next = head.next;
            head.next = current;
            count++;  //元素个数加一
        }

        /// <summary>
        /// 出栈操作
        /// </summary>
        public void Pop()
        {
            if (head.next == null)
            {
                throw new Exception("该栈已经是空栈了，不能进行出栈操作！");
            }
            else
            {
                LinkStackNode current = head.next;
                head.next = current.next;
                current = null;
                count--;
            }      
        }

        /// <summary>
        /// 取得栈顶元素
        /// </summary>
        /// <returns>返回值为栈顶节点的值</returns>
        public object GetTop()
        {
            if (head.next == null)
            {
                return "该栈为一个空栈，不存在栈顶元素！";
            }
            else
            {
                LinkStackNode current = head.next;
                return current.data;
            }
        }

        /// <summary>
        /// 获取栈底元素
        /// </summary>
        /// <returns></returns>
        public object GetTail()
        {
            LinkStackNode newHead = head;
            LinkStackNode current = head.next;
            while (current.next != null)
            {
                current = current.next;
            }
            return current.data;
        }

        /// <summary>
        /// 将链栈的元素存入到可枚举的列表中
        /// </summary>
        /// <returns>返回可枚举数据</returns>
        public IEnumerable<object> ToEnumerable()
        {
            List<object> toList=new List<object>();
            LinkStackNode current = head.next;
            while (current != null)
            {
                toList.Add(current.data);
                current = current.next;
            }
            return toList;
        }

        /// <summary>
        /// 将一个链栈进行逆序
        /// </summary>
        /// <returns>返回新的逆序链栈</returns>
        public LinkStack Reverse()
        {
            IEnumerable<object> list = this.ToEnumerable();
            object[] array = list.ToArray();
            LinkStack reverseStack = new LinkStack(); //初始化一个新的逆序栈
            for (int i = 0; i <array.Length; i++)
            {
                reverseStack.Push(array[i]);
            }
            return reverseStack;
        }

        #endregion
    }
}
