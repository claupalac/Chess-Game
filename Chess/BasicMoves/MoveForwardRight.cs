namespace Chess
{
    public class MoveForwardRight : BasicMove
    {
        public MoveForwardRight() : base()
        {
            
        }

        public override void SetChange()
        {
            _nextPositionX++;
            _nextPositionY++;
        }
    }
}