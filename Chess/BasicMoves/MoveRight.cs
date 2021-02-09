namespace Chess
{
    public class MoveRight : BasicMove
    {
        public MoveRight()
        {
            
        }

        public override void SetChange()
        {
            _nextPositionX++;
        }
    }
}