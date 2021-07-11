using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enchanter_Fashion.Display_Board
{
    class Node
    {
        private string _data;
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private Node _next;
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }

        private Node _previous;
        public Node Previous
        {
            get { return _previous; }
            set { _previous = value; }
        }

        public Node()
        {
            
        }

        public Node(string data)
        {
            Data = data;
        }
    }
}
