using System.Collections.Generic;

namespace Chess
{
    public class MoveForward : BasicMove
    {
        public MoveForward() : base()
        {
            
        }

        public override void SetChange()
        {
            _nextPositionY++;
        }
    }
}