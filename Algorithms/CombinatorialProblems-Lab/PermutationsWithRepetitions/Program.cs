﻿namespace PermutationsWithRepetitions
{
    internal class Program
    {
        private static string[] elements;
        static void Main(string[] args)
        {
            elements = new[] { "A", "B", "B", "B", "B", "B" };

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            Permute(index + 1);

            var used = new HashSet<string>() { elements[index] };

            for (int i = index + 1; i < elements.Length; i++)
            {
                if (used.Contains(elements[i]) == false)
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i);

                    used.Add(elements[i]);
                }
            }
        }

        private static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
    }
}