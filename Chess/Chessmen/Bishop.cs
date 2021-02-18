namespace Chess
{
    public class Bishop : IChessman
    {
        public IChessmanMovement MyPlays()
        {
            return new BishopMovement();
        }
    }
}