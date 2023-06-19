public class Circle : Shape{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public double GetRadius(){
        return _radius;
    }
    public void SetRadius(int radius){
        _radius = radius;
    }
    public override double GetArea()
    {
        double circlearea = Math.PI * _radius * _radius;
        return circlearea;
    }
}