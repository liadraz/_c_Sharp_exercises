using System;
using System.Collections.Generic;

namespace ws1
{
    /*
     * Implementation of a Singly Linked List
     *
     * Nodes are pushed to the end of the linked list.
     * Nodes are popped from the end of the list.
     * The last node is a dummy node, always pointing to null, and is hidden from the user.
     * Users can iterate through the list using a "for each" construct.
     *
     */
    public class MyLinkedList
    {
        private class Node
        {
            public Node? next;
            public object data;

            public Node(object value)
            {
                next = null;
                data = value;
            }
        }

        private Node? head;
        private Node? tail;
        private Node? iterator;

        private int counter;

        public MyLinkedList()
        {
            // List will be constructed as follows
            //  ITERATOR
            //    V
            //  HEAD ---> TAIL ---> NULL

            head = new Node(0);
            tail = new Node(0);
            iterator = new Node(0);

            head.next = tail;
            iterator = head;
        }

        public void Push(Object value)
        {
            Node toAdd = new Node(value);

            if (iterator == null)
            {
                return;
            }

            toAdd.next = iterator.next;
            iterator.next = toAdd;
            iterator = toAdd;

            counter++;
        }

        //public void Pop()
        //{  
        //    if (IsEmpty())
        //    {
        //        Console.WriteLine("Failed: List is empty");
        //        return;
        //    }

        //    counter--;
        //}

        public object Peek()
        {
            if (iterator is not null)
            {
                return iterator.data;
            }

            return "NULL";
        }

        public bool IsEmpty()
        {
            return (counter == 0);
        }

        public int Count()
        {
            return counter;
        }

        //Clear();
        //foreach - look how to iterate each element
    }
}
