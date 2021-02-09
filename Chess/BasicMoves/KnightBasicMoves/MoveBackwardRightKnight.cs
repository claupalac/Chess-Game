namespace Chess
{
    public class MoveBackwardRightKnight : BasicMove
    {
        
        public override void SetChange()
        {
            _nextPositionY = _nextPositionY - 2;
            _nextPositionX = _nextPositionX + 1;
        }   
    }
}