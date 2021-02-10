namespace Chess
{
    public static class Factory
    {
        public static IChessman CreateBishop() => new Bishop();

        public static IChessman CreateQueen() => new Queen();

        public static IChessman CreateRook() => new Rook();

        public static IChessman CreatePawn() => new Pawn();

        public static IChessman CreateKing() => new King();

        public static IChessman CreateKnight() => new Knight();

        public static ISquare CreateSquare() => new Square();

        public static ISquare CreateSquare(int posX, int posY) => new Square(posX, posY);
    }
    
}