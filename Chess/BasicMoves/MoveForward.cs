using System.Collections.Generic;

namespace Chess
{
    public class MoveForward : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            IPosition newPosition = new Position();
            newPosition.PositionY = originalPosition.PositionY + 1;
            newPosition.PositionX = originalPosition.PositionX;
            return newPosition;
        }
    }
}