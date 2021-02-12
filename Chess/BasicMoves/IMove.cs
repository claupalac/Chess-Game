namespace Chess
{
    public interface IMove
    {
        int[] GetMove(int[] originalPosition);
    }
}