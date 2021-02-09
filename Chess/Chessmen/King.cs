namespace Chess
{
    public class King : Chessman
    {
        public King() => myMoves = new KingMovement();
    }
}