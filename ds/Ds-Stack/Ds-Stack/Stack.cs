using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds_Stack
{
    public class Stack<T>
    {
        private T[] _items; // stack array
        private int top; // top of the stack

        // constructor
        public Stack(int size)
        {
            _items = new T[size];
            top = 0;
        }
       
        // adds item to the top of stack array
        public void push(T item)
        {
            if (isFull())
            {
                resizeStack(top * 2);
            }           
            _items[top] = item;
            top++;
        }

        // deletes top item from the top of stack array
        public T pop()
        {
            if (isEmpty())
            {
                throw new Exception("stack is empty");
            }

            if (_items.Length > (top * 2))
            {
                resizeStack(top*2);
            }
                                   
            top--;
            T item = _items[top];
            return item;
        }

        // iterates stack array 
        // dispalys items from the top to 0 
        public void displayStack()
        {
            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(_items[i]);
            }            
        }
        
        // checks weather stack is empty or not
        private bool isEmpty()
        {
            if (top <= 0)
            {
                return true;
            }
            return false;
        }

        // checks weather stack is full or not 
        private bool isFull()
        {
            if (top >= _items.Length)
            {
                return true;
            }
            return false;
        }

        // resizes the stack array with given size 
        private void resizeStack(int size)
        {
            Array.Resize(ref _items, size);
        }

    }
}
