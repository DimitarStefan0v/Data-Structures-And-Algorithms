namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            var tree = new Tree<string>("root",
                           new Tree<string>("a",
                                new Tree<string>("aa"),
                                new Tree<string>("ab"),
                                new Tree<string>("ac")
                                ),
                           new Tree<string>("b",
                                new Tree<string>("ba"),
                                new Tree<string>("bb"),
                                new Tree<string>("bc")
                                ),
                           new Tree<string>("c",
                                new Tree<string>("ca"),
                                new Tree<string>("cb",
                                    new Tree<string>("cba"),
                                    new Tree<string>("cbb"),
                                    new Tree<string>("cbc")
                                    ),
                                new Tree<string>("cc")
                                )
                           );

            Console.WriteLine("Breadth-First-Search");
            Console.WriteLine(string.Join(Environment.NewLine, tree.OrderBfs()));
            Console.WriteLine("Depth-First-Search");
            Console.WriteLine(string.Join(Environment.NewLine, tree.OrderDfs()));
        }
    }
}
