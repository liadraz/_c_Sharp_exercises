using System;
using System.Threading.Tasks;

// Requirements
//  DS: Global int
//  Reader: 1
//  Writer: 1
//  Sync Objects: Busy Wait


namespace ProducerConsumerBusyWait
{
    static class GlobalIntMonitr
    {
        static volatile int _sharedDate = -1;
        static volatile bool _hasdata = false;

        public static void Producer()
        {
            for ( int i = 0; i < 10; i++)
            {
                while (_hasdata) { /* Busy Wait */ }

                _sharedDate = i;
                Console.WriteLine($"Produced {_sharedDate}");
                _hasdata = true;
            }
        }

        public static void Consumer()
        {
            for (int i = 0; i < 10; i++)
            {
                while (!_hasdata) { /* Busy Wait */ }
                
                Console.WriteLine($"Consumed {_sharedDate}");
                _hasdata = false;
            }
        }
    }
}
