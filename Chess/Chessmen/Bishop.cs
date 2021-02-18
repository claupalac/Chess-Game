namespace Chess
{
    public class Bishop : IChessman
    {
        public IChessmanMovement Play()
        {
            return new BishopMovement();
        }
    }
}