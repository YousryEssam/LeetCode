using LeetCode.Solutions.CreateGridWithExactlyOnePath;

namespace LeetCode.Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            foreach (var (m, n) in new[] { (2, 3), (3, 3), (1, 4) })
            {
                Console.WriteLine($"m = {m}, n = {n}");
                Console.WriteLine(string.Join(Environment.NewLine, sol.ConstructGrid(m, n)));
                Console.WriteLine();
            }
        }
    }
}
