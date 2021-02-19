namespace Chess
{
    public class Pawn : IChessman
    {
        public IChessmanMovement Play()
        {
            return new PawnMovement();
        }
    }
}