using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    interface IListDS<T>
    {
        int GetLength(); //求长度
        void Clear(); //清空操作
        bool IsEmpty(); //判断线性表是否为空
        void Add(T item); //附加操作
        void Insert(T item, int index); //插入操作
        T Delete(int index); //删除操作
        T GetEle(int index); //取表元
        T this[int index] { get; }//定义一个索引器 获取元素
        int Locate(T value); //按值查找
    }
}
