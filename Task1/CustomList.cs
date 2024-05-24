using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class CustomList<T>
    {
        private T[] array;
        private int count;
        private int capacity;
        public int Capacity { get => capacity; }
        public int Count { get => count; }


        public CustomList()
        {
            array = new T[4];
            capacity = array.Length;
        }

        public void GetAll()
        {
            for (int i = 0; i < capacity; i++) 
            {
                Console.WriteLine(array[i]);
            }
        }

        public void Add(T item) 
        {
            if (count==capacity)
            {
                Array.Resize(ref array, capacity== 0 ? 4: array.Length*2);
                capacity=array.Length;
            }
            array[count] = item;
            count++;
        }

        public void Remove (T item)
        {
            var index=Array.IndexOf(array, item);
            if (index != -1)
            {
                for (int i = index;i<count;i++)
                    array[i] = array[i+1];

                count--;    
            }
        }

        public bool Contains(T item) 
        {
            var index = Array.IndexOf(array, item);
            if (index != -1)
            {
                return true;
            }
            return false;
        }

        public bool Any()
        {
            if (count > 0) return true;
            return false;
        }

        public void Clear()
        {
            for (int i = 0; i < count; i++)
                array[i] = default;

            count = 0;
        }

        public T FirstOrDefault()
        {
            if (count>0)
                return array[0];

            return default;
        }

        public T ElementAtOrDefault(int index)
        {
            if (index>=0 && index < count)
            {
                return array[index];
            }
            return default;
        }

        public T LastOrDefault()
        {
            if (Any())
                return array[count - 1];

                    return default;
        }
    }
}
