namespace Chess
{
    public class MoveForwardLeft : BasicMove
    {
        public MoveForwardLeft() : base()
        {
            
        }

        public override void SetChange()
        {
            _nextPositionX--;
            _nextPositionY++;
        }
    }
}