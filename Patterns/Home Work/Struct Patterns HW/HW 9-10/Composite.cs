//class Program
//{
//    static void Main(string[] args)
//    {
//        // Создаем простые фигуры
//        var circle1 = new Circle("Круг 1");
//        var circle2 = new Circle("Круг 2");
//        var square1 = new Square("Квадрат 1");
//        var square2 = new Square("Квадрат 2");

//        // Создаем составные фигуры (группы)
//        var group1 = new CompositeGraphic("Группа 1");
//        var group2 = new CompositeGraphic("Группа 2");
//        var allGraphics = new CompositeGraphic("Все фигуры");

//        // Добавляем простые фигуры в группы
//        group1.Add(circle1);
//        group1.Add(square1);

//        group2.Add(circle2);
//        group2.Add(square2);

//        // Добавляем группы в общую группу
//        allGraphics.Add(group1);
//        allGraphics.Add(group2);

//        // Рисуем все фигуры
//        allGraphics.Draw();

//    }
//}
//// Абстрактный компонент - базовая часть компоновщика
//abstract class Graphic
//{
//    protected string name;

//    public Graphic(string name)
//    {
//        this.name = name;
//    }

//    public abstract void Draw();
//    public abstract void Add(Graphic g);
//    public abstract void Remove(Graphic g);
//    public abstract Graphic GetChild(int index);
//}

//// Листовой компонент - не имеет потомков
//class Circle : Graphic
//{
//    public Circle(string name) : base(name) { }

//    public override void Draw()
//    {
//        Console.WriteLine($"Рисуем круг: {name}");
//    }

//    public override void Add(Graphic g)
//    {
//        throw new NotImplementedException();
//    }

//    public override void Remove(Graphic g)
//    {
//        throw new NotImplementedException();
//    }

//    public override Graphic GetChild(int index)
//    {
//        throw new NotImplementedException();
//    }
//}

//// Листовой компонент - не имеет потомков
//class Square : Graphic
//{
//    public Square(string name) : base(name) { }

//    public override void Draw()
//    {
//        Console.WriteLine($"Рисуем квадрат: {name}");
//    }

//    public override void Add(Graphic g)
//    {
//        throw new NotImplementedException();
//    }

//    public override void Remove(Graphic g)
//    {
//        throw new NotImplementedException();
//    }

//    public override Graphic GetChild(int index)
//    {
//        throw new NotImplementedException();
//    }
//}

//// Составной компонент - может содержать другие компоненты
//class CompositeGraphic : Graphic
//{
//    private List<Graphic> children = new List<Graphic>();

//    public CompositeGraphic(string name) : base(name) { }

//    public override void Draw()
//    {
//        Console.WriteLine($"Начинаем рисовать группу: {name}");
//        foreach (var child in children)
//        {
//            child.Draw();
//        }
//        Console.WriteLine($"Заканчиваем рисовать группу: {name}");
//    }

//    public override void Add(Graphic g)
//    {
//        children.Add(g);
//    }

//    public override void Remove(Graphic g)
//    {
//        children.Remove(g);
//    }

//    public override Graphic GetChild(int index)
//    {
//        return children[index];
//    }
//}
