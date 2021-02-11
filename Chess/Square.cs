using System;

namespace Chess
{
    public class Square : ISquare
    {
        private int _positionX;
        private int _positionY;
        public IChessman MyChessman { get; set; }

        public int PositionX
        {
            get => _positionX;
            set
            {
                if (value < 0) throw new ArgumentException("Invalid Value");
                _positionX = value;
            }
        }

        public int PositionY
        {
            get => _positionY;
            set  {
                if (value < 0) throw new ArgumentException("Invalid Value");
                _positionY = value;
            }
        }

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