using System;
namespace uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lönen för person 1?");
            string person1 = Console.ReadLine();
            int per1 = int.Parse(person1);
            Console.WriteLine("lönen för person 2?");
            string person2 = Console.ReadLine();
            int per2 = int.Parse(person2);
            Console.WriteLine("lönen för person 3?");
            string person3 = Console.ReadLine();
            int per3 = int.Parse(person3);
            int kostnaden = per1 + per2 + per3;
            Console.WriteLine("kostnaden för alla 3 är " + kostnaden);
            int medellönen = kostnaden / 3;
            Console.WriteLine("medellönen är " + medellönen);
        }
    }
}
           
            