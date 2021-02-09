namespace Chess
{
    public class MoveLeft : BasicMove
    {
        public MoveLeft()
        {
            
        }

        public override void SetChange()
        {
            _nextPositionX--;
        }
    }
}