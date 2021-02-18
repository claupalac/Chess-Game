namespace Chess
{
    public class MoveForwardRight : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            IPosition newPosition = new Position();
            newPosition.PositionY = originalPosition.PositionY + 1;
            newPosition.PositionX = originalPosition.PositionX + 1;
            return newPosition;
        }
    }
}