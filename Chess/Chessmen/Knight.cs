namespace Chess
{
    public class Knight : IChessman
    {
        public IChessmanMovement MyPlays()
        {
            return new KnightMovement();
        }
    }
}