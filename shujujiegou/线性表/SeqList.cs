﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    class SeqList<T>:IListDS<T>
    {
        private T[] data; //用来存储数据
        private int count = 0;  //表示存了多少个数据

        public SeqList(int size) //size就是最大容量
        {
            data = new T[size];
            count = 0;
        }

        public SeqList():this(10)//默认构造函数 容量是10
        {
        
        }


        //取得数据的个数
        public int GetLength()
        {
            return count;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Add(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("当前的数据表已经存满，不允许再存入");
            }
            else {
                data[count] = item;
                count++;
            }
        }

        public void Insert(T item, int index)
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        public T Delete(int index)
        {
            T temp = data[index];
            for (int i = index + 1; i < count; i++)
            {
                data[i - 1] = data[i];//把数据向前移动
            }
            count--;
            return temp;
        }

        public T GetEle(int index)
        {
            if (index >= 0 && index <= count - 1) //索引存在
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
            
        }

        public T this[int index]
        {
            get { return GetEle(index); }
        }

        public int Locate(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
