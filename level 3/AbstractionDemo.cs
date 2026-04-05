using System;

namespace OOPBasics
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Circle");
    }

    class AbstractionDemo
    {
        static void Main()
        {
            Shape s = new Circle();
            s.Draw();
        }
    }
}