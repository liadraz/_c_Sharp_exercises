using ProducerConsumerBusyWait;using ProducerConsumerMonitor;
using ProducerConsumerMonitorNSemaphore;
public class RunConcurrency{     public static void Main()
    {
        //Test_BusyWait();
        //Test_OneWriterOneReader();        Test_OneWriterManyReaders();    }    public static void Test_BusyWait()    {        Thread producer = new Thread(GlobalIntBusyWait.Producer);        Thread consumer = new Thread(GlobalIntBusyWait.Consumer);        producer.Start();        consumer.Start();        producer.Join();        consumer.Join();    }    public static void Test_OneWriterOneReader()    {        OneWriterOneReaderLL<int> list = new();        Thread writer1 = new Thread(() => { for (int i = 1; i <= 10; i++) list.Add(i); });        Thread writer2 = new Thread(() => { for (int i = 11; i <= 20; i++) list.Add(i); });        Thread reader1 = new Thread(() => Console.WriteLine($"Contains 5: {list.Contains(5)}"));        Thread reader2 = new Thread(() => Console.WriteLine($"Contains 14: {list.Contains(14)}"));

        writer1.Start();        writer2.Start();        writer1.Join();        writer2.Join();                reader1.Start();        reader2.Start();        reader1.Join();        reader2.Join();        Console.WriteLine("Final List: ");        list.Print();    }    public static void Test_OneWriterManyReaders()
    {
        OneWriterManyReadersLL<int> list = new();

        Thread writer1 = new Thread(() => { for (int i = 1; i <= 10; i++) list.Add(i); });
        Thread writer2 = new Thread(() => { for (int i = 11; i <= 20; i++) list.Add(i); });

        Thread reader1 = new Thread(() => Console.WriteLine($"Contains 5: {list.Contains(5)}"));
        Thread reader2 = new Thread(() => Console.WriteLine($"Contains 14: {list.Contains(14)}"));
        Thread reader3 = new(() => list.Print());

        writer1.Start();
        writer2.Start();
        writer1.Join();
        writer2.Join();

        reader1.Start();
        reader2.Start();
        reader3.Start();
        reader1.Join();
        reader2.Join();
        reader3.Join();

        Console.WriteLine("Final List: ");
        list.Print();
    }}