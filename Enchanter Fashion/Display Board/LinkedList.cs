using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enchanter_Fashion.Display_Board
{
    class LinkedList : IEnumerable<Node>
    {
        private Node head;
        public Node first
        {
            get { return head; }
        }

        private Node tail;
        public Node Last
        {
            get { return tail; }
        }

        public int length { get; private set; }
        int i=0;

        public IEnumerator<Node> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable GetenumeratorReverse()
        {
            Node current = tail;
            while (current!=null)
            {
                yield return current;
                current = current.Previous;
            }
        }

        //aka addlist
        public void Add(string data)
        {
            Node newnode = new Node(data);
            if (tail == null)
            {
                head = newnode;
            }
            else
            {
                newnode.Previous = tail;
                tail.Next = newnode;
            }
            tail = newnode;
            length++;
        }

        public void AddFirst(string data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                tail = newnode;
            }
            else
            {
                head.Previous = newnode;
            }
            head = newnode;
            length++;
        }

        /*
        IEnumerator<Node> myEnumerator = null; // we are not enumerating yet.

        string GetNextItemToDisplay()
        {    // returns null if there are no more items to display

            // if we haven't started yet, get the enumerator:
            if (this.myEnumerator == null) this.myEnumerator = this.GetEnumerator();

            // get the next element (or if we haven't fetched anything yet: get the first element
            // for this we use MoveNext. This returns false if there is no next element
            while (this.myEnumerator.MoveNext())
            {
                // There is a next string. It is in Current:
                string nextString = enumerator.Current();
                return nextString;
            }

            // if here: no strings left. return null:
            return null;
        }
        */
    }
}
