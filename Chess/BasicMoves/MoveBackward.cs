namespace Chess
{
    public class MoveBackward : Move
    {
        public override int[] GetMove(int[] originalPosition)
        {
            int[] newPosition = originalPosition;
            newPosition[PositionY] = originalPosition[PositionY]++;
            
            return newPosition;
        }
    }
}