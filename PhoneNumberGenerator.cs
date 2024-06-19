// PhoneNumberGenerator class
public class PhoneNumberGenerator
{
    private readonly Keypad keypad;

    public PhoneNumberGenerator(Keypad keypad)
    {
        this.keypad = keypad;
    }

    public int CountValidPhoneNumbersForPiece(IChessPiece piece)
    {
        int count = 0;
        for (int r = 0; r < 4; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                int startDigit = keypad.GetValue(r, c);
                if (startDigit != -1 && startDigit != 0 && startDigit != 1)
                {
                    bool[,] visited = new bool[4, 3];
                    count += CountPhoneNumbers(r, c, 1, visited, piece);
                }
            }
        }
        return count;
    }

    private int CountPhoneNumbers(int row, int col, int length, bool[,] visited, IChessPiece piece)
    {
        if (length == 7)
            return 1;

        visited[row, col] = true;
        int count = 0;

        foreach (var move in piece.GetMoves(row, col))
        {
            int newRow = move.Item1;
            int newCol = move.Item2;

            if (keypad.IsValidPosition(newRow, newCol) && !visited[newRow, newCol])
            {
                count += CountPhoneNumbers(newRow, newCol, length + 1, visited, piece);
            }
        }

        visited[row, col] = false;
        return count;
    }
}