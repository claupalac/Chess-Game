namespace Chess.Factory
{
    public class SquareCreator
    {
        public ISquare FactoryMethod()
        {
            return new Square();
        }
        
    }
}