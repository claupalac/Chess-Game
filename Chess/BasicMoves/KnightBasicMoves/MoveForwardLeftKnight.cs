namespace Chess
{
    public class MoveForwardLeftKnight : BasicMove
    {
        public override void SetChange()
        {
            _nextPositionY = _nextPositionY + 2;
            _nextPositionX = _nextPositionX - 1;
        }
    }
}