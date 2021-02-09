namespace Chess
{
    public class MoveRightForwardKnight : BasicMove
    {
        public override void SetChange()
        {
            _nextPositionY = _nextPositionY + 1;
            _nextPositionX = _nextPositionX + 2;
        }
    }
}