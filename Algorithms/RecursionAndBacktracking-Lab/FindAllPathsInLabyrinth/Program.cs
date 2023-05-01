namespace FindAllPathsInLabyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            var lab = new char[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                var colElements = Console.ReadLine();

                for (int c = 0; c < colElements.Length; c++)
                {
                    lab[r, c] = colElements[c];
                }
            }

            FindPaths(lab, 0, 0, new List<string>(), string.Empty);
        }

        private static void FindPaths(char[,] lab, int row, int col, List<string> directions, string direction)
        {
            // Validate row and col
            if (row < 0 || row >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1))
            {
                return;
            }

            // Check for walls or visited cells
            if (lab[row, col] == '*' || lab[row, col] == 'v')
            {
                return;
            }

            directions.Add(direction);

            // Check if end point is reached
            if (lab[row, col] == 'e')
            {
                Console.WriteLine(string.Join(string.Empty, directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            lab[row, col] = 'v';

            FindPaths(lab, row - 1, col, directions, "U"); // UP
            FindPaths(lab, row + 1, col, directions, "D"); // DOWN
            FindPaths(lab, row, col - 1, directions, "L"); // LEFT
            FindPaths(lab, row, col + 1, directions, "R"); // RIGHT

            lab[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);
        }
    }
}