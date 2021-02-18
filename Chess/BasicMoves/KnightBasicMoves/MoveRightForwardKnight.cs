namespace Chess
{
    public class MoveRightForwardKnight : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            IPosition newPosition = new Position();
            newPosition.PositionY = originalPosition.PositionY + 1;
            newPosition.PositionX = originalPosition.PositionX + 2;
            return newPosition;
        }
    }
}