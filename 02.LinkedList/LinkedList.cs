using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{/*
    internal class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        private int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public LinkedListNode<T> First { get { return head; } }

        public LinkedListNode<T> last { get { return tail; } }

        public int count 

        public LinkedListNode<T> AddFirst(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            InsertNodeBefore(head, newNode);
            return newNode;
        }

        public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            InsertNodeBefore(node, newNode);
            return newNode;
        }

        public LinkedListNode<T> AddLast(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

        }

        private void RemoveNode(LinkedListNode<T> node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            if (head == node)
                head = node.next;
            if (tail == node)
                tail = node.prev;

            if (node.prev != null)
                node.prev.next = node.next;
            if (node.next != null)
                node.next.prev = node.prev;

            count--;
        }

        public void Remove(LinkedListNode<T>node)
        {
            RemoveNode(node);
        }

        public void RemoveFirst()
        {
            RemoveNode(head);
        }

        public void RemoveLast()
        {
            RemoveLast(tail);
        }

        


        private void InsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            newNode.next = node.next;
            newNode.prev = node.prev;

            if (node == head)
            {
                head = newNode;
            }
            else
            {
                node.prev.next = newNode;
            }

            node.prev = newNode;

            /*
            LinkedListNode<T> prevNode = node.prev;

            // 1. newNode의 prev를 node의 prev로
            newNode.prev = prevNode;
            // 2. newNode의 next를 node로
            newNode.next = node;
            // 3. node의 prev의 next를 newNode로
            prevNode.next = newNode;

            // 3. node 앞의 노드의 유무에 따라
            if (node == head )// 3-1. head를 newNode의
            {
                head = newNode;
            }
            else
            {
                node.prev = newNode;   
            }
            // 4. node의 prve를 newNode로
            node.prev = newNode;


            newNode.next = node;
            node.prev = newNode;
            

            count++;
        }

        public void InsertNodeAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            newNode.prev = node;
            newNode.next = node.next;

            if (node == tail)
            {
                tail = newNode;
            }
            else
            {
                node.next.prev = newNode;
            }

            node.next = newNode;

            count++;
        }




    }

    public class LinkedListNode<T>
    {
        private T value;

        public LinkedListNode<T> prev;
        public LinkedListNode<T> next;

        public LinkedListNode(T value, LinkedListNode<T> prev, LinkedListNode<T> next)
        {
            this.value = value;
            this.prev = prev;
            this.next = next;
        }

        public LinkedListNode<T> Prev { get { return prev; } }
        public LinkedListNode<T> next { get { return next; } }
        public LinkedListNode<T> value { }

    }
    */
}
