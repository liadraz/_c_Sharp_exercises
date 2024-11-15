using System;
using System.Collections.Generic;

namespace ws1
{
    /*
     *  Implenetation of a Single Linked List
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
            //          ITERATOR
            //              V
            //  HEAD ---> TAIL ---> NULL

            head = new Node(0);
            tail = new Node(0);

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

            iterator.next = toAdd;
            iterator = toAdd;
            iterator.next = tail;

            counter++;
        }

        //Pop();

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
