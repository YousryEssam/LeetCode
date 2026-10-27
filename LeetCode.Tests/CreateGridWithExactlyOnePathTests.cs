using LeetCode.Solutions.CreateGridWithExactlyOnePath;
using Xunit.Abstractions;

public class CreateGridWithExactlyOnePathTests
{
    private readonly ITestOutputHelper _out;
    public CreateGridWithExactlyOnePathTests(ITestOutputHelper output) => _out = output;

    // The three examples from the problem: prints the grid so you can see it
    [Theory]
    [InlineData(2, 3)]
    [InlineData(3, 3)]
    [InlineData(1, 4)]
    public void Examples_HaveExactlyOnePath(int m, int n)
    {
        var grid = new Solution().ConstructGrid(m, n);
        _out.WriteLine(string.Join(Environment.NewLine, grid));
        Assert.Equal(1, CountPaths(grid, m, n));
    }

    // Every size allowed by the constraints: 1 <= m, n <= 25
    [Fact]
    public void AllSizes_HaveExactlyOnePath()
    {
        var sol = new Solution();
        for (int m = 1; m <= 25; m++)
            for (int n = 1; n <= 25; n++)
            {
                var grid = sol.ConstructGrid(m, n);
                Assert.True(CountPaths(grid, m, n) == 1, $"Failed for m={m}, n={n}");
            }
    }

    // Validates the grid shape, then counts right/down paths (capped at 2)
    private static long CountPaths(string[] grid, int m, int n)
    {
        Assert.Equal(m, grid.Length);
        foreach (var row in grid)
        {
            Assert.Equal(n, row.Length);
            Assert.All(row, c => Assert.True(c == '.' || c == '#'));
        }

        if (grid[0][0] == '#') return 0;

        var dp = new long[m, n];
        dp[0, 0] = 1;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                if ((i == 0 && j == 0) || grid[i][j] == '#') continue;
                long up = i > 0 ? dp[i - 1, j] : 0;
                long left = j > 0 ? dp[i, j - 1] : 0;
                dp[i, j] = Math.Min(up + left, 2); // cap so the count never overflows
            }
        return dp[m - 1, n - 1];
    }
}
