using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceVC
{
    public class CustomArray<T>
    {
        private T[] array;
        private int size;
        private int capacity;

        public CustomArray(int capacity = 10)
        {
            this.capacity = capacity;
            array = new T[capacity];
            size = 0;
        }

        //add elements
        public void Add(T element)
        {
            if (size == capacity)
            {
                Resize();
            }
            array[size] = element;
            size++;
        }

        //delete by index
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }

            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[size - 1] = default(T);
            size--;
        }

        //search by value
        public int Search(T element)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1; //if nothing is found
        }

        //output method
        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //get by index
        public T GetAt(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
            return array[index];
        }

        //array size
        public int Size()
        {
            return size;
        }

        //resize aaray
        private void Resize()
        {
            capacity *= 2;
            T[] newArray = new T[capacity];
            Array.Copy(array, newArray, size);
            array = newArray;
        }
    }
}

