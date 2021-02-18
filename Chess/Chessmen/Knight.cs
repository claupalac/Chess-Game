namespace Chess
{
    public class Knight : IChessman
    {
        public IChessmanMovement Play()
        {
            return new KnightMovement();
        }
    }
}