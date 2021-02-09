namespace Chess
{
    public class Pawn : Chessman
    {
        public Pawn()
        {
            myMoves = new PawnMovement();
        }
    }
}