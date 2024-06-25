// Chess piece classes
public class King : IChessPiece
{
    public List<(int, int)> GetMoves(int row, int col)
    {
        return new List<(int, int)>
        {
            (row - 1, col - 1), (row - 1, col), (row - 1, col + 1),
            (row, col - 1), (row, col + 1),
            (row + 1, col - 1), (row + 1, col), (row + 1, col + 1)
        };
    }
}

public class Queen : IChessPiece
{
    public List<(int, int)> GetMoves(int row, int col)
    {
        var moves = new List<(int, int)>();
        moves.AddRange(new Rook().GetMoves(row, col));
        moves.AddRange(new Bishop().GetMoves(row, col));
        return moves;
    }
}

public class Rook : IChessPiece
{
    public List<(int, int)> GetMoves(int row, int col)
    {
        var moves = new List<(int, int)>();
        for (int i = 1; i < 4; i++)
        {
            moves.Add((row + i, col));
            moves.Add((row - i, col));
            moves.Add((row, col + i));
            moves.Add((row, col - i));
        }
        return moves;
    }
}

public class Bishop : IChessPiece
{
    public List<(int, int)> GetMoves(int row, int col)
    {
        var moves = new List<(int, int)>();
        for (int i = 1; i < 4; i++)
        {
            moves.Add((row + i, col + i));
            moves.Add((row - i, col - i));
            moves.Add((row + i, col - i));
            moves.Add((row - i, col + i));
        }
        return moves;
    }
}

public class Knight : IChessPiece
{
    public List<(int, int)> GetMoves(int row, int col)
    {
        return new List<(int, int)>
        {
            (row - 2, col - 1), (row - 2, col + 1),
            (row - 1, col - 2), (row - 1, col + 2),
            (row + 1, col - 2), (row + 1, col + 2),
            (row + 2, col - 1), (row + 2, col + 1)
        };
    }
}

public class Pawn : IChessPiece
{
    public List<(int, int)> GetMoves(int row, int col)
    {
        return new List<(int, int)>
        {
            (row - 1, col) // Moving upwards
        };
    }
}