namespace Chess
{
    public class King : IChessman
    {
        public IChessmanMovement MyPlays()
        {
            return new KingMovement();
        }
    }
}