using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// DS: Linked List
//  Reader: M
//  Writer: M
//  Sync Objects: 1 Monitor

namespace ProducerConsumerMonitor
{
    class ThreadSafeLinkedList<T>
    {
        private readonly LinkedList<T> _list = new();
        private readonly object _lock = new();

        public void Add(T value)
        {
            lock (_lock)
            {
                _list.AddLast(value);
            }
        }

        public bool Contains(T value)
        {
            lock (_lock)
            {
                return _list.Contains(value);
            }
        }

        public bool Remove(T value)
        {
            lock (_lock)
            {
                return _list.Remove(value);
            }
        }

        public void Print()
        {
            lock (_lock)
            {
                foreach (var item in _list)
                {
                    Console.WriteLine($"{item} -> ");
                }

                Console.WriteLine("null");
            }
        }
    }

}
