
using ws1;

public class Test_Linked_List
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Test Stack {Test_Stack()}");
    }

    public static bool Test_Stack()
    {
        bool ret = false;
        const int STACK_SIZE = 3;
        Stack stack = new Stack(STACK_SIZE);

        Console.WriteLine("\t~ Test Stack ~ ");

        Console.WriteLine($"""
        PUSH
            Is Stack Empty  {stack.IsEmpty()}
        """);
        for (int i = 0; i < STACK_SIZE; i++)
        {
            stack.Push(10 * i);

            Console.WriteLine($"""
                Peek {stack.Peek()}
                Size {stack.Size()}
            """);
        }

        Console.WriteLine("");

        Console.WriteLine($"""
        POP
            Is Stack Empty  {stack.IsEmpty()}
        """);
        for (int i = 0; i < STACK_SIZE; i++)
        {
            stack.Pop();

            Console.WriteLine($"""
                Peek {stack.Peek()}
                Size {stack.Size()}
            """);
        }

        stack.Push(10);
        stack.Push(10);
        stack.Push(10);
        stack.Clear();

        Console.WriteLine($"""
            Is Clear
                Is Stack Empty {stack.Peek()}
            """);

        if (stack.IsEmpty())
        {
            ret = true;
        }

        return ret;
    }
}
