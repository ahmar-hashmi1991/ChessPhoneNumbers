// Keypad class
public class Keypad
{
    private readonly int[][] layout;

    public Keypad()
    {
        layout = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
            new int[] { -1, 0, -1 } // -1 for * and #
        };
    }

    public int GetValue(int row, int col)
    {
        if (IsValidPosition(row, col))
        {
            return layout[row][col];
        }
        return -1;
    }

    public bool IsValidPosition(int row, int col)
    {
        return row >= 0 && row < 4 && col >= 0 && col < 3 && layout[row][col] != -1;
    }
}