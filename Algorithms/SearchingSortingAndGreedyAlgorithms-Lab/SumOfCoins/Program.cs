namespace SumOfCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coins = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(x => x));

            var target = int.Parse(Console.ReadLine());
            var selectedCoins = new Dictionary<int, int>();
            var totalCoins = 0;

            while (target > 0 && coins.Count > 0)
            {
                var currentCoint = coins.Dequeue();
                var count = target / currentCoint;

                if (count == 0)
                {
                    continue;
                }

                selectedCoins[currentCoint] = count;
                totalCoins += count;

                target %= currentCoint;
            }

            if (target == 0)
            {
                Console.WriteLine($"Numbers of coins to take: {totalCoins}");
                foreach (var coin in selectedCoins)
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}