namespace Chess
{
    public interface IChessman
    {
        ISquare MySquare { get; set; }
        IChessmanMovement GetMovement();
    }
}