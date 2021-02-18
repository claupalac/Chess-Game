namespace Chess
{
    public class King : IChessman
    {
        public IChessmanMovement Play()
        {
            return new KingMovement();
        }
    }
}