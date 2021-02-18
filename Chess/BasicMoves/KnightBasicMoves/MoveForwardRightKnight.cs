namespace Chess
{
    public class MoveForwardRightKnight : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionY = originalPosition.PositionY + 2;
            originalPosition.PositionX = originalPosition.PositionX + 1;
            return originalPosition;
        }
    }
}