namespace Chess
{
    public class Queen : Chessman
    {
        public Queen()
        {
            myMoves = new QueenMovement();
        }
    }
}