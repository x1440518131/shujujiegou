﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_队列
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用BCL中的队列
            Queue<int> queue = new Queue<int>();

            //入队(添加数据)
            queue.Enqueue(23);//队首
            queue.Enqueue(45);
            queue.Enqueue(67);
            queue.Enqueue(89);
            Console.WriteLine("添加了23 45 67 89之后的队列的大小为：" + queue.Count);
            //出队  取得队首并删除
            int i = queue.Dequeue();
            Console.WriteLine("取得队首的数据为：" + i);
            Console.WriteLine("出队之后队列的大小为：" + queue.Count);
            int j = queue.Peek();
            Console.WriteLine("Peek得到的结果是：" + j);
            Console.WriteLine("Peek之后队列的大小为：" + queue.Count);
            queue.Clear();

            Console.WriteLine("清空之后队列的大小为："+queue.Count);
            Console.ReadKey();
        }
    }
}
