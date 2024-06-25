// IChessPiece interface
public interface IChessPiece
{
    List<(int, int)> GetMoves(int row, int col);
}
