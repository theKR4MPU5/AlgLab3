using System;
using System.Collections.Generic;
using AlgLab3.Structures.LinkedList;

namespace AlgLab3
{

    public class Stack<T>
    {

        private Structures.LinkedList.LinkedList<T> _list = new Structures.LinkedList.LinkedList<T>();

        public bool IsEmpty() =>  _list.Count == 0;

        public int Count  => _list.Count;

        public void Push(T element)
        {
            _list.AddToStart(element);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стэк пуст");
            }
            INode<T> temp = _list.Head;
            _list.RemoveFromStart();
            return temp.Value;
        }

        public T Top()
        {
            if (IsEmpty()) throw new InvalidOperationException("Стэк пуст");
            return _list.Head.Value;
        }

        public void Print()
        {
            foreach (var elem in _list)
            {
                System.Console.WriteLine(elem);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", _list);
        }

        public T Peek()
        {
            return _list.Head.Value;
        }

        
    }
}