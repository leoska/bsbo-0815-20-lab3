using System;
using System.Collections.Generic;
using System.Text;

namespace bsbo_0815_20_lab3
{
    class Tree
    {
        private Node Head;

        public void Add(int value)
        {
            if (Head==null)
            {
                Head = new Node(value);

            }
        }
    }
}
