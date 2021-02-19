namespace Chess
{
    public class Queen : IChessman
    {
        public IChessmanMovement Play()
        {
            return new QueenMovement();
        }
    }
}