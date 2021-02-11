namespace Chess
{
    public interface IChessman
    {
        ISquare MySquare { get; set; }
        ChessmanMovement GetMovement();
    }
}