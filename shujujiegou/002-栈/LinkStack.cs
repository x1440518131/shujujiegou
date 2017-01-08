using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top;//栈顶元素结点
        private int count = 0;//栈中元素的个数

        //取得栈中元素的个数
        public int Count
        {
            get {return count; }
        }
        //取得栈中元素的个数
        public int GetLength()
        {
            return count;
        }
        //判断栈中是否有数据
        public bool IsEmpty()
        {
            return count == 0;
        }
        //清空栈中所有的数据
        public void Clear()
        {
            count = 0;
            top = null;
        }
        //入栈
        public void Push(T item)
        {
            //把新添加的元素作为头结点(栈顶)
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }
        //出栈 取得栈顶元素 删除
        public T Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }
        //取得栈顶的数据，不删除栈顶
        public T Peek()
        {
            return top.Data;
        }
    }
}
