namespace Chess
{
    public interface IMove
    {
        IPosition GetMove(IPosition originalPosition);
    }
}