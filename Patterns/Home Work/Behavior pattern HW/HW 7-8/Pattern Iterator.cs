//class Program
//{
//    static void Main()
//    {
//        // Выводим заголовок меню
//        Console.WriteLine("Меню кафе:");

//        // Создаем объект меню кафе
//        IMenu menu = new CafeMenu();

//        // Получаем итератор для перебора блюд в меню
//        IIterator iterator = menu.CreateIterator();

//        // Перебираем и выводим блюда с помощью итератора
//        while (iterator.HasNext())
//        {
//            Console.WriteLine("- " + iterator.Next());
//        }
//    }
//}

//// Интерфейс итератора, который определяет методы для перебора элементов
//interface IIterator
//{
//    // Метод для проверки наличия следующего элемента
//    bool HasNext();

//    // Метод для получения следующего элемента
//    string Next();
//}

//// Интерфейс меню, который определяет метод для создания итератора
//interface IMenu
//{
//    // Метод для создания итератора
//    IIterator CreateIterator();
//}

//// Класс CafeMenu реализует интерфейс IMenu и представляет меню кафе
//class CafeMenu : IMenu
//{
//    // Список блюд в меню
//    private List<string> _dishes = new List<string>();

//    // Конструктор для инициализации списка блюд
//    public CafeMenu()
//    {
//        _dishes.Add("Борщ");
//        _dishes.Add("Пельмени");
//        _dishes.Add("Котлета с пюре");
//        _dishes.Add("Компот");
//    }

//    // Реализация метода для создания итератора
//    public IIterator CreateIterator()
//    {
//        // Возвращает новый объект итератора для списка блюд
//        return new CafeMenuIterator(_dishes);
//    }
//}

//// Класс CafeMenuIterator реализует интерфейс IIterator и представляет итератор для меню кафе
//class CafeMenuIterator : IIterator
//{
//    // Список блюд, по которому будет осуществляться итерация
//    private List<string> _dishes;

//    // Текущая позиция итератора
//    private int _position = 0;

//    // Конструктор для инициализации итератора списком блюд
//    public CafeMenuIterator(List<string> dishes)
//    {
//        _dishes = dishes;
//    }

//    // Реализация метода для проверки наличия следующего элемента
//    public bool HasNext()
//    {
//        // Возвращает true, если есть следующий элемент в списке
//        return _position < _dishes.Count;
//    }

//    // Реализация метода для получения следующего элемента
//    public string Next()
//    {
//        // Возвращает текущий элемент и перемещает позицию на следующий элемент
//        string dish = _dishes[_position];
//        _position++;
//        return dish;
//    }
//}


