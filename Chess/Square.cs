using System;

namespace Chess
{
    public class Square
    {
        public Chessman MyChessman { get; set; }

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Square(int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
            MyChessman = null;
        }
        
        public void ShowPosition()
        {
            Console.WriteLine("{0},{1}", PositionX, PositionY);
        }

        public bool IsEmpty()
        {
            return MyChessman == null;
        }
    }
}