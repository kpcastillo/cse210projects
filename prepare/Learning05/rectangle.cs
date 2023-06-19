public class Rectangle : Shape{
    private double _height;
    private double _width;
    public Rectangle(string color, double height, int width) : base(color){
        _height = height;
        _width = width;
    }
    public void SetHeight(double height){
        _height = height;
    }
    public double GetHeight(){
        return _height;
    }
    public void SetWidth(double width){
        _width = width;
    }
    public double GetWidth(){
        return _width;
    }

    public override double GetArea()
    {
        return _height * _width;
    }

}