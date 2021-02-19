namespace Chess
{
    public class MoveRight : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            IPosition newPosition = new Position();
            newPosition.PositionY = originalPosition.PositionY;
            newPosition.PositionX = originalPosition.PositionX + 1;
            return newPosition;
        }
    }
}