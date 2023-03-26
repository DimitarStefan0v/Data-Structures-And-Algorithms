namespace Problem04.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : IAbstractLinkedList<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }

            public Node(T element, Node next)
            {
                this.Element = element;
                this.Next = next;
            }

            public Node(T element)
            {
                this.Element = element;
            }
        }

        private Node head;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var node = new Node(item, this.head);
            this.head = node;
            this.Count++;
        }

        public void AddLast(T item)
        {
            var newNode = new Node(item);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                var currentNode = this.head;
                while (currentNode.Next != null) 
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }

            this.Count++;
        }

        public T GetFirst()
        {
            this.CheckIfCollectionIsEmpty();

            return this.head.Element;
        }

        public T GetLast()
        {
            this.CheckIfCollectionIsEmpty();

            var node = this.head;
            while(node.Next != null)
            {
                node = node.Next;
            }

            return node.Element;
        }

        public T RemoveFirst()
        {
            this.CheckIfCollectionIsEmpty();

            var oldHead = this.head;
            this.head = oldHead.Next;
            this.Count--;

            return oldHead.Element;
        }

        public T RemoveLast()
        {
            this.CheckIfCollectionIsEmpty();

            Node curretnNode = this.head;
            Node lastNode = null;

            if (curretnNode.Next == null)
            {
                lastNode = this.head;
                this.head = null;
            }
            else
            {
                while (curretnNode != null)
                {
                    if (curretnNode.Next.Next == null)
                    {
                        lastNode = curretnNode.Next;
                        curretnNode.Next = null;
                        break;
                    }

                    curretnNode = curretnNode.Next;
                }
            }

            this.Count--;

            return lastNode.Element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.head;
            while(node != null)
            {
                yield return node.Element;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void CheckIfCollectionIsEmpty()
        {
            if (this.head == null)
            {
                throw new InvalidOperationException();
            }
        }
    }
}