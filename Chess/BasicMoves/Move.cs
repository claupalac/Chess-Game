namespace Chess
{
    public abstract class Move : IMove
    {
        protected const int PositionX = 0;
        protected const int PositionY = 0;

        public abstract int[] GetMove(int[] originalPosition);
    }
}