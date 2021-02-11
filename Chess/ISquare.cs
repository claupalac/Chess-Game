using Chess.Factory;

namespace Chess
{
    public interface ISquare : IProduct
    {
        IChessman MyChessman { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
        string ShowPosition();
        bool IsEmpty();
        
    }
}