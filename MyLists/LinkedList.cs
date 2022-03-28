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
            _root = null;
            _tail = null;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = new Node(value);
        }
        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }
            set
            {

            }
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
        } //1

        public void AddToBegin(int value)
        {
            Node crnt = new Node(value);
            crnt.Next = _root;
            _root = crnt;
            Length++;
        } //2

        public void AddByIndex(int value, int index)
        {
            Node tmp = _root;
            for (int i = 0; i < index - 1; i++)
            {
                tmp = tmp.Next;
            }
            Node crnt = new Node(value);
            crnt.Next = tmp.Next;
            tmp.Next = crnt;

        } //3

        public void DeleteEnd()
        {
            Node current = _root;
            Node previous = null;
            while (current != null)
            {
                previous = current.Next;
                if (previous != null)
                {
                    _tail = previous;
                }

            }

        }

        public void PrintList()
        {
            Node node = _root;
            while (node != null)
            {
                Console.Write($" { node.Value}");
                node = node.Next;
            }
        }





    }



}

