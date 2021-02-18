namespace Chess
{
    public class Pawn : IChessman
    {
        public IChessmanMovement MyPlays()
        {
            return new PawnMovement();
        }
    }
}