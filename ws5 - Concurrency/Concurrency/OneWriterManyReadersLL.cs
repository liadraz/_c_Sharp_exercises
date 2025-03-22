using System;
using System.Threading;

namespace ProducerConsumerMonitorNSemaphore
{
    public class OneWriterManyReadersLL<T>
    {
        private readonly LinkedList<T> _list = new();
        private readonly object _lock = new();
        private readonly Semaphore _semaphore = new(1, 3);

        // Add and Remove are writers
        // Contains and Print are readers

        public void Add(T value)
        {
            lock (_lock)
            {
                _list.AddLast(value);
            }
        }

        public bool Remove(T value)
        {
            lock (_lock)
            {
                return _list.Remove(value);
            }
        }

        public bool Contains(T value)
        {
            _semaphore.WaitOne();
            try
            {
                return _list.Contains(value);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public void Print()
        {
            _semaphore.WaitOne();

            try
            {
                foreach (var item in _list)
                {
                    Console.WriteLine($"{item} -> ");
                }
                Console.WriteLine("null");
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
