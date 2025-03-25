/////*Создайте класс Shape с методом clone(), который будет использовать паттерн Prototype 
////для создания копий объектов (например, круг, квадрат). */

//class Program
//{
//    static void Main()
//    {
//        // Создаем прямоугольник с красным цветом
//        Shape rectangle = new Rectangle("red");
//        // Клонируем прямоугольник
//        Shape rectangleCopy = rectangle.Clone();
//        // Выводим цвет оригинального прямоугольника и клона
//        Console.WriteLine("The color of the original rectangle: " + rectangle.Color);
//        Console.WriteLine("The color of the clone rectangle: " + rectangleCopy.Color);


//        // Создаем квадрат с синим цветом
//        Shape square = new Square("blue");
//        // Клонируем квадрат
//        Shape squareCopy = square.Clone();
//        // Выводим цвет оригинального квадрата и клона
//        Console.WriteLine("The color of the original square: " + square.Color);
//        Console.WriteLine("The color of the clone square: " + squareCopy.Color);
//    }
//}

//// Абстрактный класс для фигур
//abstract class Shape
//{
//    // Свойство для хранения цвета фигуры
//    public string Color { get; }

//    // Конструктор, инициализирующий цвет фигуры
//    public Shape(string color)
//    {
//        this.Color = color; // Установка цвета
//    }

//    // Абстрактный метод для клонирования фигуры
//    public abstract Shape Clone();
//}

//// Класс для квадратов, наследующий от Shape
//class Square : Shape
//{
//    // Конструктор, передающий цвет в базовый класс
//    public Square(string color) : base(color) { }

//    // Реализация метода клонирования для квадрата
//    public override Shape Clone()
//    {
//        return new Square(Color); // Возвращаем новый экземпляр квадрата с тем же цветом
//    }
//}

//// Класс для прямоугольников, наследующий от Shape
//class Rectangle : Shape
//{
//    // Конструктор, передающий цвет в базовый класс
//    public Rectangle(string color) : base(color) { }

//    // Реализация метода клонирования для прямоугольника
//    public override Shape Clone()
//    {
//        return new Rectangle(Color); // Возвращаем новый экземпляр прямоугольника с тем же цветом
//    }
//}

