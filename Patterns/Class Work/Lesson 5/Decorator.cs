
//internal class Programm
//{
//    static void Main()
//    {
//        // Создаем экземпляр ServerApi
//        var serverApi = new ServerApi();

//        // Создаем экземпляр ValidationRequest с аргументами "ar1" и "arg2"
//        var validationRequest = new ValidationRequest(serverApi, "ar1", "arg2");

//        // Вызываем метод Get для получения данных
//        validationRequest.Get();
//    }
//}

//// Класс для хранения данных
//public class Data
//{
//    // Свойства для хранения значений
//    public int Property1 { get; set; }
//    public int Property2 { get; set; }
//}

//// Интерфейс для серверного API
//public interface IServerApi
//{
//    // Метод для получения данных
//    Data Get();
//}

//// Класс, реализующий интерфейс IServerApi
//public class ServerApi : IServerApi
//{
//    // Метод для получения данных
//    public Data Get()
//    {
//        // Создаем экземпляр Data и устанавливаем значения свойств
//        var data = new Data();
//        data.Property1 = 2;
//        data.Property2 = 2;

//        // Возвращаем заполненный объект Data
//        return data;
//    }
//}

//// Класс для валидации запроса
//public class ValidationRequest : IServerApi
//{
//    // Приватные поля для хранения экземпляра ServerApi и аргументов
//    private IServerApi _serverApi;
//    private string _arg1;
//    private string _arg2;

//    // Конструктор для инициализации полей
//    public ValidationRequest(IServerApi serverApi, string arg1, string arg2)
//    {
//        _serverApi = serverApi;
//        _arg1 = arg1;
//        _arg2 = arg2;
//    }

//    // Метод для получения данных с валидацией аргументов
//    public Data Get()
//    {
//        // Проверяем длину аргументов
//        if (_arg1.Length <= 256 && _arg2.Length <= 256)
//        {
//            // Если длина аргументов допустима, вызываем метод Get у ServerApi
//            return _serverApi.Get();
//        }
//        // Если длина аргументов недопустима, выбрасываем исключение
//        throw new Exception("Длина аргументов превышает допустимый предел.");
//    }
//}
