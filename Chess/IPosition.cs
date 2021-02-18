using Chess.Factory;

namespace Chess
{
    public interface IPosition : IProduct
    {
        int PositionX { get; set; }
        int PositionY { get; set; }
        string ToString();
    }
}