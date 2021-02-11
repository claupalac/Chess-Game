using System;

namespace Chess
{
    public class Square : ISquare
    {
        public IChessman MyChessman { get; set; }

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Square(int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
            MyChessman = null;
        }

        public Square()
        {
            
        }
        
        public string ShowPosition()
        {
            return (PositionX.ToString() + "," + PositionY.ToString());
        }

        public bool IsEmpty()
        {
            return MyChessman == null;
        }

        
    }
}