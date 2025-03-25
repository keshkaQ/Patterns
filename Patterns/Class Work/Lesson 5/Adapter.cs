//internal class Programm
//{
//    static void Main()
//    {
//        // Создаем экземпляр цели
//        var target = new Target();

//        // Создаем экземпляр клиента
//        var client = new Client();

//        // Создаем экземпляр адаптера
//        var adapter = new Adapter();

//        // Клиент отправляет запрос цели
//        client.Request(target);

//        // Клиент отправляет запрос адаптеру
//        client.Request(adapter);
//    }
//}

//// Класс цели с виртуальным методом запроса
//public class Target
//{
//    // Виртуальный метод для обработки запроса
//    public virtual void Request()
//    {
//        // Логика обработки запроса
//        Console.WriteLine("Запрос к цели.");
//    }
//}

//// Класс клиента, который отправляет запросы
//public class Client
//{
//    // Метод для отправки запроса цели
//    public void Request(Target target)
//    {
//        // Вызов метода запроса у цели
//        target.Request();
//    }
//}

//// Класс специфического API с методом запроса
//public class SpecificApi
//{
//    // Метод для выполнения специфического запроса
//    public void SpecificRequest()
//    {
//        // Логика выполнения специфического запроса
//        Console.WriteLine("Специфический запрос выполнен.");
//    }
//}

//// Класс адаптера, который наследует класс Target и использует SpecificApi
//public class Adapter : Target
//{
//    // Приватное поле для хранения экземпляра SpecificApi
//    private SpecificApi specificApi;

//    // Конструктор для инициализации экземпляра SpecificApi
//    public Adapter()
//    {
//        specificApi = new SpecificApi();
//    }

//    // Переопределение метода запроса для вызова специфического запроса
//    public override void Request()
//    {
//        // Вызов специфического запроса через SpecificApi
//        specificApi.SpecificRequest();
//    }
//}