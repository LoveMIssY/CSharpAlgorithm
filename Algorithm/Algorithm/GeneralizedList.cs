using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    /// <summary>
    /// 广义表的存储结构
    /// </summary>
    public class GeneralizedListNode
    {
        public int tag;
        public object atom;
        public GeneralizedListNode sublist;
        public GeneralizedListNode next;
    }

    /// <summary>
    /// 广义表类型
    /// </summary>
    public class GeneralizedList
    {
        # region 属性和字段
        GeneralizedListNode head = new GeneralizedListNode();
        GeneralizedListNode tail = new GeneralizedListNode();
        private string stringGL = string.Empty;  //用来存储广义表字符串的私有字段
        public int Length
        {
            get { return GetLength(); }
        }
        public int Depth
        {
            get { return GetDepth(head.next); }
        }
        #endregion

        #region 操作方法
        /// <summary>
        /// 构造函数
        /// </summary>
        public GeneralizedList()
        {
            head.next = null;
            tail = head;
        }

        /// <summary>
        /// 打印广义表的私有方法
        /// </summary>
        /// <param name="g">传入链式存储的第一个节点</param>
        /// <returns></returns>
        private string Dislpay(GeneralizedListNode g)
        {      
            if(g!=null)
            {
                if (g.tag == 0)
                {
                    if (g.atom == null)
                        stringGL += "*";
                    else
                        stringGL += g.atom.ToString();
                }
                else 
                {
                    stringGL += "(";
                    if (g.sublist == null)
                        stringGL += "#";
                    else
                        Dislpay(g.sublist);   //先递归一个子表
                    stringGL += ")";
                }
                if (g.next != null)
                {
                    stringGL += ",";
                    Dislpay(g.next);     //再递归下一个元素
                }
            }
            return stringGL;
        }

        /// <summary>
        /// 打印广义表的共有方法
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            string print = string.Empty;
            print=Dislpay(head.next);
            return print;
        }

        /// <summary>
        /// 通过字符串创建广义表
        /// </summary>
        /// <param name="source">字符串的形式为"a,(b,c,d),(#)"这样的形式</param>
        /// <param name="i"></param>
        /// <returns></returns>
        private GeneralizedListNode CreateGeneralizedList(string source,ref int i)
        {
            GeneralizedListNode h;
            char ch = source[i];
            i++;
            if (i < source.Length)
            {
                h = new GeneralizedListNode();
                if (ch == '(')
                {
                    h.tag = 1;
                    h.sublist = CreateGeneralizedList(source, ref i);
                }
                else if (ch == ')')
                {
                    h = null;
                }
                else if (ch == '#')
                {
                    h = null;
                }
                else
                {
                    h.tag = 0;
                    h.atom = ch;
                }
            }
            else
            {
                h = null;
            }
            if (i < source.Length)
            {
                ch = source[i];
                i++;
                if(h!=null)
                {
                    if (ch == ',')
                        h.next = CreateGeneralizedList(source, ref i);
                    else
                        h.next = null;
                }
            }
            return h;
        }
       
        /// <summary>
        /// 通过公有方法去掉用私有方法进行创建
        /// </summary>
        /// <param name="source"></param>
        public void CreateGL(string source)
        {
            int i = 0;
            head.next = CreateGeneralizedList(source, ref i);
        }

        /// <summary>
        /// 获取广义表的长度的私有方法
        /// </summary>
        /// <returns></returns>
        private int GetLength()
        {
            int n = 0;
            GeneralizedListNode g = head.next;
            while (g != null)
            {
                n++;
                g = g.next;
            }
            return n;
        }

        /// <summary>
        /// 获取广义表的深度的私有方法
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private int GetDepth(GeneralizedListNode g)
        {
            int max = 0, dep=0;         
            while (g != null)
            {
                if (g.tag == 0)
                    max = 0;
                else
                {
                    dep=GetDepth(g.sublist);  //递归调用
                }
                g = g.next;
                GetDepth(g);
            }
            if (dep > max)
                max = dep;
            return (max + 1);
        }

        /// <summary>
        /// 向广义表中添加原子
        /// </summary>
        /// <param name="atom"></param>
        public void Add(object atom)
        {
            GeneralizedListNode current = new GeneralizedListNode();
            current.tag = 0;
            current.atom = atom;
            tail.next = current;
            tail = current;
        }

        /// <summary>
        /// 向广义表中添加嵌套的节点
        /// </summary>
        /// <param name="node"></param>
        public void Add(GeneralizedListNode node)
        {
            GeneralizedListNode current = new GeneralizedListNode();
            if (node.tag == 1)
            {
                current.tag = 1;
                current.sublist = node;
                tail.next = current;
                tail = current;
            }
            else if (node.tag == 0)
            {
                current.tag = 0;
                current.atom = node.atom;
                tail.next = current;
                tail = current;
            }
        }

        #endregion
    }
}
