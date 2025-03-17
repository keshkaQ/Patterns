/*Создайте класс Shape с методом clone(), который будет использовать паттерн Prototype 
для создания копий объектов (например, круг, квадрат). */


//abstract class Shape
//{
//    public string Color { get; }

//    public Shape(string color)
//    {
//       this.Color = color;
//    }

//    public abstract Shape Clone();
//}

//class Square : Shape
//{
//    public Square(string color) : base(color) {}

//    public override Shape Clone()
//    {
//        return new Square(Color);
//    }
//}

//class Rectangle : Shape
//{
//    public Rectangle(string color) : base(color){}

//    public override Shape Clone()
//    {
//        return new Rectangle(Color);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape rectangle = new Rectangle("red");
//        Shape rectangleCopy = rectangle.Clone();
//        Console.WriteLine("the color of the original rectangle:" + rectangle.Color + " the color of the clone rectangle:" + rectangleCopy.Color);

//        Shape square = new Square("blue");
//        Shape squareCopy = square.Clone();
//        Console.WriteLine("the color of the original square:" + square.Color + " the color of the clone square:" + squareCopy.Color);
//    }
//}