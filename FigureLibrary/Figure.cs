namespace FigureLibrary
{
    public abstract class Figure
    {
        public string FigureType { get; protected set; }
        public Figure(string figureType)
        {
            FigureType = figureType;
        }
        public abstract double Square();
        public virtual double Square(Figure figure)
        {
            return figure.Square();
        }
        public override string ToString()
        {
            return FigureType;
        }
    }
}