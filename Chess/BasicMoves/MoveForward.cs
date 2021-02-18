using System.Collections.Generic;

namespace Chess
{
    public class MoveForward : IMove
    {
        public IPosition GetMove(IPosition originalPosition)
        {
            originalPosition.PositionY = originalPosition.PositionY++;
            return originalPosition;
        }
    }
}