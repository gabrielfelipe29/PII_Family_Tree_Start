
using System;
namespace Library
{

    public class Visitor : IVisitor
    {
        public int ages { get; private set; }

        //para verificar el primer nodo de la edad
        private bool primerAge = true;

        //para verificar el primer nodo del mas viejo

        private bool primerOldest = true;

        public Person Oldest { get; set; }

        //para verificar el primer nodo del nombre mas largo

        private bool primerLongestName = true;

        public Person LongestName { get; set; }

        public void VisitAge(Node node)
        {
            if (primerAge)
            {
                this.ages = this.ages + node.Person.Age;
                primerAge = false;
            }
            //edad de la persona

            // Console.WriteLine($"Nodo : {node.Person.Name},{node.Person.Age}");

            //edad de los hijos

            foreach (Node x in node.Children)
            {
                // Console.WriteLine($"{x.Person.Name},{x.Person.Age}");
                this.ages = this.ages + x.Person.Age;
                x.AcceptAge(this);

            }




        }

        public void VisitOldest(Node node)
        {
            if (primerOldest)
            {
                this.Oldest = node.Person;
                primerOldest = false;
            }

            foreach (Node x in node.Children)
            {
                if (x.Person.Age > this.Oldest.Age)
                {

                    this.Oldest = x.Person;

                }
                x.AcceptOldest(this);

            }



        }

        public void VisitLongestName(Node node)
        {

            if (primerLongestName)
            {
                this.LongestName = node.Person;
                primerLongestName = false;
            }

            foreach (Node x in node.Children)
            {
                if (x.Person.Name.Length > this.LongestName.Name.Length)
                {

                    this.LongestName = x.Person;

                }
                x.AcceptLongestName(this);

            }
        }

    }


}