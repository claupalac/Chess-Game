namespace Chess
{
    public interface ISquare
    {
        Chessman MyChessman { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
        string ShowPosition();
        bool IsEmpty();
        
    }
}