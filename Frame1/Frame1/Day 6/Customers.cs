using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frame1.Day_6
{
    public class Customers
    {
        
    }
    class Customer<T>
    {
        List<T> myList = new List<T>();
        public void FillList(T data)
        {
            myList.Add(data);
        }
        public List<T> GetList()
        {
            return myList;
        }
    }
}