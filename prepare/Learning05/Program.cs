using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq1 = new Square("Pink", 4);
        // Console.WriteLine(sq1.GetArea());
        // Console.WriteLine(sq1.GetColor());
        Rectangle rec1 = new Rectangle("Blue", 5, 3);
        Circle cir1 = new Circle("Teal", 2);

        List<Shape> shapesList = new List<Shape>{};
        shapesList.Add(sq1);
        shapesList.Add(rec1);
        shapesList.Add(cir1);

        foreach (Shape shape in shapesList){
            double shapeArea = shape.GetArea();
            string shapeColor = shape.GetColor();
            Console.WriteLine($"Shape Color: {shapeColor} Area: {shapeArea}. ");
        }


    }
}