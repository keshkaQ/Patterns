/////* Реализуйте класс Logger, который будет использовать паттерн Singleton для ведения 
////логов в приложении. Убедитесь, что только один экземпляр класса может существовать в любой 
////момент времени.*/

//class Program
//{
//    static void Main()
//    {
//        // Получаем единственный экземпляр логгера
//        Logger logger1 = Logger.GetInstance();
//        // Выводим хэш-код первого логгера
//        Console.WriteLine("Get HashCode for logger1: " + logger1.GetHashCode());

//        // Получаем тот же единственный экземпляр логгера
//        Logger logger2 = Logger.GetInstance();
//        // Выводим хэш-код второго логгера
//        Console.WriteLine("Get HashCode for logger2: " + logger2.GetHashCode());
//    }
//}

//// Класс логгера
//public class Logger
//{
//    private static Logger logger; // Статическая переменная для хранения единственного экземпляра логгера

//    // Приватный конструктор, чтобы предотвратить создание экземпляров класса извне
//    private Logger() { }

//    // Метод для получения единственного экземпляра логгера
//    public static Logger GetInstance()
//    {
//        // Если экземпляр еще не создан, создаем его
//        if (logger == null)
//            logger = new Logger();
//        // Возвращаем существующий или только что созданный экземпляр
//        return logger;
//    }
//}


