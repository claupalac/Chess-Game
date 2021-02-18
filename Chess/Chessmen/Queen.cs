namespace Chess
{
    public class Queen : IChessman
    {
        public IChessmanMovement MyPlays()
        {
            return new QueenMovement();
        }
    }
}