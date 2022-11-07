using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        public Person Person;

        private List<Node> children = new List<Node>();
        /*
                public int Number {
                    get
                    {
                        return this.number;
                    }
                }
        */

        public ReadOnlyCollection<Node> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, int age)
        {
            this.Person = new Person(name, age);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void AcceptAge(Visitor visitor)
        {

            visitor.VisitAge(this);

        }

        public void AcceptOldest(Visitor visitor)
        {

            visitor.VisitOldest(this);

        }


        public void AcceptLongestName(Visitor visitor)
        {

            visitor.VisitLongestName(this);

        }

    }
}
