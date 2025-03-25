//class Programm
//{
//    static void Main()
//    {
//        ICoffee coffee = new SimpleCoffee();
//        coffee = new CoffeeDecorator(coffee, "молоко", 50);

//        Console.WriteLine($"Описание: {coffee.GetDescription()}");
//        Console.WriteLine($"Стоимость: {coffee.GetCost()} руб.");
//    }
//}
//// Интерфейс компонента
//public interface ICoffee
//{
//    string GetDescription();
//    double GetCost();
//}

//// Базовый компонент
//public class SimpleCoffee : ICoffee
//{
//    public string GetDescription()
//    {
//        return "Простой кофе";
//    }

//    public double GetCost()
//    {
//        return 100;
//    }
//}

//// Универсальный декоратор
//public class CoffeeDecorator : ICoffee
//{
//    protected ICoffee _coffee;
//    private string _ingredient;
//    private double _ingredientCost;

//    public CoffeeDecorator(ICoffee coffee, string ingredient, double ingredientCost)
//    {
//        _coffee = coffee;
//        _ingredient = ingredient;
//        _ingredientCost = ingredientCost;
//    }

//    public string GetDescription()
//    {
//        return $"{_coffee.GetDescription()}, {_ingredient}";
//    }

//    public double GetCost()
//    {
//        return _coffee.GetCost() + _ingredientCost;
//    }
//}
