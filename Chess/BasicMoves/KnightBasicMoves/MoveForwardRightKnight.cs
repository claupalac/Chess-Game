namespace Chess
{
    public class MoveForwardRightKnight : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            IPosition newPosition = new Position();
            newPosition.PositionY = originalPosition.PositionY + 2;
            newPosition.PositionX = originalPosition.PositionX + 1;
            return newPosition;
        }
    }
}