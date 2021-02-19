namespace Chess
{
    public class Rook : IChessman
    {
        public IChessmanMovement Play()
        {
            return new RookMovement();
        }
    }
}