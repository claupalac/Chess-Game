namespace Chess
{
    public class MoveBackward : BasicMove
    {
        public MoveBackward() : base()
        {
            
        }

        public override void SetChange()
        {
            _nextPositionY--;
        }
    }
}