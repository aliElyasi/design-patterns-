using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.iterator
{
    public interface Iterator<T>
    {
        public T current();
        public void next();
        public bool hasNext();
    }

    public class ArrayIterator<T> : Iterator<T>
    {
        public int index { get; set; } = 0;

        T[] items;
        public ArrayIterator(T[] items)
        {
            this.items = items;
        }

        public T current()
        {
            return items[index];
        }

        public bool hasNext()
        {
          return  index < items.Length;
        }

        public void next()
        {
            index = index + 1;
        }
    }



    public class ListIterator<T> : Iterator<T>
    {
        public int index { get; set; } = 0;

        IList<T> items;
        public ListIterator(IList<T> items)
        {
            this.items = items;
        }

        public T current()
        {
            return items.Skip(index).Take(1).First();
        }

        public bool hasNext()
        {
            return index < items.Count();
        }

        public void next()
        {
            index = index + 1;
        }
    }



    public class BrowserHistory
    {
        private String[] urls = new String[10];
        private int count = 0;

       public void push(String item)
        {
            urls[count++] = item;
        }

        public String pop()
        {
            return urls[--count];
        }

        public Iterator<string> createIterator()
        {
            return new ArrayIterator<string>(urls);
        }


    }

}
