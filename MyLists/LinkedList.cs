using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists
{
    public class LinkedList
    {
        private Node _root;
        private Node _tail;

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }

                return count;
            }
            private set
            {
            }
        }

        public LinkedList()
        {
             Length = 0;
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
             Length = 1;
            _root = new Node(value);
            _tail = new Node(value);
        }

        public void AddToEnd(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
            Length++;
        }

        public void PrintList()
        {
            Node node = _root;
            while (node != null)
            {
                Console.Write(node.Value);
                node = node.Next;
            }
        }


    }
}
