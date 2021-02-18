namespace Chess
{
    public class Rook : IChessman
    {
        public IChessmanMovement MyPlays()
        {
            return new RookMovement();
        }
    }
}