using Problem01.List;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customList = new CustomList<int>(5);
            customList.Add(3);
            customList.Add(15);
            customList.Add(259);
            customList.Add(13);
            customList.Add(9);
            customList.Add(20);


            foreach (var item in customList)
            {
                Console.WriteLine(item);
            }
        }
    }
}