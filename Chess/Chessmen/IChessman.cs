namespace Chess
{
    public interface IChessman
    {
        Square MySquare { get; set; }
        ChessmanMovement GetMovement();
    }
}