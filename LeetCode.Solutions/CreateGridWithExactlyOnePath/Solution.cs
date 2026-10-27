namespace LeetCode.Solutions.CreateGridWithExactlyOnePath;

public class Solution
{
    public string[] ConstructGrid(int m, int n)
    {
        var grid = new string[m];
        grid[0] = new string('.', n);          // top row fully open
        for (int i = 1; i < m; i++)
            grid[i] = new string('#', n - 1) + "."; // only the last column open
        return grid;
    }
}
