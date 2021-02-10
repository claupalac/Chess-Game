namespace Chess
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ChessTable chessTable = new ChessTable(8,8);
            King king = new King();
            king.MySquare = chessTable.PutChessman(king,1,1);
            Player player1 = new Player();
            player1.ShowMovesFromChessman(king,chessTable);
        }
    }
}