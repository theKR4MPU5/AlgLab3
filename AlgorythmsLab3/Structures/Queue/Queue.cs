using System;
using System.Diagnostics.CodeAnalysis;
using AlgLab3.Structures.LinkedList;

namespace AlgLab3
{

    public class Queue<T>
    {

        private readonly LinkedList<T> _list = new LinkedList<T>();

        public bool IsEmpty => _list.Count == 0;

        public int Count => _list.Count;

        public void Enqueue(T element)
        {
            _list.Add(element);
        }

        public object Peek()
        {
            return _list.Head;
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                return default;
            }
            T output = _list.Head.Value;
            _list.RemoveFromStart();
            return output;
        }

        public T First()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Очередь пуста");
            }
            return _list.Head.Value;
        }
        
        public void Print()
        {
            foreach (var elem in _list)
            {
                System.Console.Write($"{elem} ");
            }
        }

        public override string ToString()
        {
            return string.Join(", ", _list);
        }
    }
}