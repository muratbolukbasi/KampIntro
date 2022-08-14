using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()                      //ctor yazdık ve 2xTAB yaparak yazdık. 
        {                                           //constructor
            items = new T[0];
        }
        public void Add (T item)
        { 
            T[] tempArray = items;              //tempArray yeni item eklemeden halini hafızada tutsun.
            items = new T[items.Length + 1];    //bu komutta itemslere yeni item eklesin.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;         
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }


    }
}
