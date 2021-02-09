namespace Chess
{
    public class MoveBackwardRight : BasicMove
    {
        public MoveBackwardRight() : base()
        {
          
        }

        public override void SetChange()
        {
            _nextPositionX++;
            _nextPositionY--;
        }
    }
}