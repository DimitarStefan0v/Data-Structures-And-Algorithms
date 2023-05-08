namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var searchNum = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(numbers, searchNum));
        }

        private static int BinarySearch(int[] numbers, int searchNum)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while (left <= right) 
            {
                var mid = (left + right) / 2;

                if (numbers[mid] == searchNum)
                {
                    return mid;
                }

                if (searchNum > numbers[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}