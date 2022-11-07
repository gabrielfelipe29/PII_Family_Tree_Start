using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Javier", 1);
            Node n2 = new Node("Macarena", 1);
            Node n3 = new Node("Roberto", 1);
            Node n4 = new Node("Marcelo", 1);
            Node n5 = new Node("Juan", 2);
            Node n6 = new Node("Marcelaria", 2);
            Node n7 = new Node("Carlos", 5);
            Node n8 = new Node("Felipe", 1);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí

            Visitor visitorAge = new Visitor();
            n1.AcceptAge(visitorAge);

            Visitor visitorOldest = new Visitor();
            n1.AcceptOldest(visitorOldest);

            Visitor visitorLongest = new Visitor();
            n1.AcceptLongestName(visitorLongest);

            Console.WriteLine($"Suma de las edades: {visitorAge.ages}");
            Console.WriteLine($"Persona mas vieja: {visitorOldest.Oldest.Name} con {visitorOldest.Oldest.Age} años.");
            Console.WriteLine($"Nombre mas largo: {visitorLongest.LongestName.Name} ");


        }
    }
}
