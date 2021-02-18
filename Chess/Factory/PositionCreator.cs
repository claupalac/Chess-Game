namespace Chess.Factory
{
    public class PositionCreator 
    {
        public  IPosition FactoryMethod()
        {
            return new Position();
        }
    }
}