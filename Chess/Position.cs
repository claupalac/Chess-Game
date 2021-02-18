namespace Chess
{
    public class Position : IPosition
    {
        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public Position(int posX, int posY)
        {
            PositionX = posX;
            PositionY = posY;
        }

        public Position()
        {
            
        }
        public override string ToString()
        {
            string position = $"{PositionX},{PositionY}";
            return position;
        }
    }
}