namespace Chess
{
    public class MoveBackwardLeft : BasicMove
    {
        public MoveBackwardLeft() : base()
        {
            
        }

        public override void SetChange()
        {
            _nextPositionX--;
            _nextPositionY--;
        }
    }
}