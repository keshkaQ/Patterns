//class Programm
//{
//    static void Main()
//    {
//        // Создаем экземпляры различных рендереров
//        var openGLRenderer = new OpenGLRenderer();
//        var directXRenderer = new DirectXRenderer();
//        var paintRenderer = new PaintRenderer();

//        // Создаем прямоугольник с рендерером Paint и отображаем его
//        var rectangle = new Rectangle(paintRenderer);
//        rectangle.Show();

//        // Создаем квадрат с рендерером DirectX и отображаем его
//        var square = new Square(directXRenderer);
//        square.Show();

//        // Изменяем рендерер квадрата на OpenGL и снова отображаем его
//        square.SetRenderer(openGLRenderer);
//        square.Show();
//    }
//}

//// Абстракция (Abstraction): Базовый класс для всех фигур
//public abstract class Shape
//{
//    // Ссылка на реализатор (Implementor)
//    public IRenderer _renderer { get; set; }

//    // Конструктор принимает реализатор и сохраняет его
//    protected Shape(IRenderer renderer)
//    {
//        _renderer = renderer;
//    }

//    // Абстрактный метод для отображения фигуры
//    public abstract void Show();

//    // Метод для изменения рендерера фигуры
//    public void SetRenderer(IRenderer renderer)
//    {
//        _renderer = renderer;
//    }
//}

//// Уточненная абстракция (Refined Abstraction): Прямоугольник
//public class Rectangle : Shape
//{
//    // Конструктор передает реализатор в базовый класс
//    public Rectangle(IRenderer renderer) : base(renderer) { }

//    // Реализация метода Show для прямоугольника
//    public override void Show()
//    {
//        // Использует реализатор для рендеринга
//        Console.WriteLine($"Рисуем прямоугольник{_renderer.Render()}");
//    }
//}

//// Уточненная абстракция (Refined Abstraction): Квадрат
//public class Square : Shape
//{
//    // Конструктор передает реализатор в базовый класс
//    public Square(IRenderer renderer) : base(renderer) { }

//    // Реализация метода Show для квадрата
//    public override void Show()
//    {
//        // Использует реализатор для рендеринга
//        Console.WriteLine($"Рисуем квадрат{_renderer.Render()}");
//    }
//}

//// Реализатор (Implementor): Интерфейс для всех рендереров
//public interface IRenderer
//{
//    // Метод для рендеринга
//    string Render();
//}

//// Конкретный реализатор (Concrete Implementor): OpenGL рендерер
//public class OpenGLRenderer : IRenderer
//{
//    // Реализация метода Render для OpenGL
//    public string Render()
//    {
//        return " в OpenGL";
//    }
//}

//// Конкретный реализатор (Concrete Implementor): DirectX рендерер
//public class DirectXRenderer : IRenderer
//{
//    // Реализация метода Render для DirectX
//    public string Render()
//    {
//        return " в DirectX";
//    }
//}

//// Конкретный реализатор (Concrete Implementor): Paint рендерер
//public class PaintRenderer : IRenderer
//{
//    // Реализация метода Render для Paint
//    public string Render()
//    {
//        return " в Paint";
//    }
//}