
//partial class Program
//{
//    static void Main()
//    {
//        // Создаем экземпляр конкретного агрегата для хранения целых чисел
//        var concreteAggragate = new ConcreteAggragate<int>();

//        // Добавляем элементы в агрегат
//        concreteAggragate.AddItem(1);
//        concreteAggragate.AddItem(2);
//        concreteAggragate.AddItem(3);
//        concreteAggragate.AddItem(4);

//        // Создаем итератор для обхода элементов агрегата
//        var iterator = concreteAggragate.CreateIterator();

//        // Используем итератор для обхода элементов и вывода их на консоль
//        while (iterator.hasNext())
//        {
//            var item = iterator.Next();
//            Console.WriteLine(item);
//        }
//    }
//}

//// Обобщенный интерфейс итератора
//public interface IIterator<T>
//{
//    // Метод для проверки наличия следующего элемента
//    bool hasNext();

//    // Метод для получения следующего элемента
//    T Next();
//}

//// Интерфейс агрегата, который создает итератор
//public interface IAggregate<T>
//{
//    // Метод для создания итератора
//    IIterator<T> CreateIterator();
//}

//// Конкретная реализация итератора
//public class ConcreteIterator<T> : IIterator<T>
//{
//    private List<T> _collection; // Коллекция элементов
//    private int CurrentIndex = 0; // Индекс для перебора элементов

//    // Конструктор, принимающий коллекцию элементов
//    public ConcreteIterator(List<T> collection)
//    {
//        _collection = collection;
//    }

//    // Проверка наличия следующего элемента в коллекции
//    public bool hasNext()
//    {
//        return CurrentIndex < _collection.Count;
//    }

//    // Получение следующего элемента из коллекции
//    public T Next()
//    {
//        // Если есть следующий элемент, возвращаем его
//        if (hasNext())
//        {
//            return _collection[CurrentIndex++];
//        }
//        // Если нет, выбрасываем исключение
//        throw new Exception("No more elements in the collection.");
//    }
//}

//// Конкретный класс агрегата, который может добавлять элементы и возвращать созданный итератор
//public class ConcreteAggragate<T> : IAggregate<T>
//{
//    private List<T> _list; // Внутренняя коллекция для хранения элементов

//    // Конструктор, инициализирующий внутреннюю коллекцию
//    public ConcreteAggragate()
//    {
//        _list = new List<T>();
//    }

//    // Метод для добавления элемента в коллекцию
//    public void AddItem(T item)
//    {
//        _list.Add(item);
//    }

//    // Метод для создания итератора на основе внутренней коллекции
//    public IIterator<T> CreateIterator()
//    {
//        return new ConcreteIterator<T>(_list);
//    }
//}

