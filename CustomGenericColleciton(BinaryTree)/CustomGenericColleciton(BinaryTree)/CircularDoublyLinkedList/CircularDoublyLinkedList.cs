using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericColleciton_BinaryTree_.CircularDoublyLinkedList
{
    public class CircularDoublyLinkedList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
        }

        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public void Add(T value)
        {
            var newNode = new Node { Value = value };

            if (head == null)
            {
                head = newNode;
                tail = newNode;
                newNode.Next = newNode;
                newNode.Previous = newNode;
            }
            else
            {
                newNode.Previous = tail;
                newNode.Next = head;
                tail.Next = newNode;
                head.Previous = newNode;
                tail = newNode;
            }

            Count++;
        }

        public void Remove(T value)
        {
            var currentNode = head;

            while (currentNode != null)
            {
                if(EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                {
                    if (Count == 1)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        currentNode.Previous.Next = currentNode.Next;
                        currentNode.Next.Previous = currentNode.Previous;

                        if(currentNode == head)
                        {
                            head = currentNode.Next;
                        }
                        else if(currentNode == tail)
                        {
                            tail = currentNode.Previous;
                        }
                    }

                    Count--;
                    break;
                }

                currentNode = currentNode.Next;

                if (currentNode == head)
                {
                    break;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if(index < 0 || index >=Count)
                {
                    throw new IndexOutOfRangeException();
                }
                var currentNode = head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = head;
            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.Next;
                
                if(currentNode == head)
                {
                    break;
                }
            }
        }
    }
}
