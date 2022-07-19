﻿namespace FigureLibrary
{
    public abstract class Figure
    {
        public string FigureType { get; protected set; }
        public Figure(string figureType)
        {
            FigureType = figureType;
        }
        public abstract float Square();
        public override string ToString()
        {
            return FigureType;
        }
    }
}