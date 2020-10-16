using System;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Forest f = new Forest("Amazon");
            Console.WriteLine(f.Trees);

            for (var i = 0; f.age < 5; i++)
            { f.Grow(); }

            Console.WriteLine(f.Trees);
            f.Burn();

            Console.WriteLine(f.Trees);
            Console.WriteLine(f.age);
			
			Console.WriteLine();
			Forest.PrintTreeFacts();

           
        }
    }
}