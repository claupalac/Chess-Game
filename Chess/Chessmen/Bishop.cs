namespace Chess
{
    public class Bishop : Chessman
    {
        public Bishop()
        {
            myMoves = new BishopMovement();
        }
    }
}