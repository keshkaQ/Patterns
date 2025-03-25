//partial class Program
//{
//    static void Main()
//    {
//        // Создаем обработчики поддержки для каждого уровня
//        var basicSupportHandler = new BasicSupportHandler();
//        var advancedSupportHandler = new AdvancedSupportHandler();
//        var expertSupportHandler = new ExpertSupportHandler();

//        // Устанавливаем цепочку обработчиков
//        basicSupportHandler
//            .SetNextHandler(advancedSupportHandler) // Базовая поддержка передает запрос расширенной поддержке
//            .SetNextHandler(expertSupportHandler);   // Расширенная поддержка передает запрос экспертной поддержке

//        // Создаем запрос поддержки с уровнем сложности 7
//        var supportRequest = new SupportRequest(7);

//        // Начинаем обработку запроса с базовой поддержки
//        basicSupportHandler.HandlerRequest(supportRequest);
//    }
//}
//// Класс запроса поддержки, содержащий уровень сложности
//public class SupportRequest
//{
//    // Уровень сложности запроса
//    public int Complexity { get; set; }

//    // Конструктор для инициализации уровня сложности
//    public SupportRequest(int complexity)
//    {
//        Complexity = complexity;
//    }
//}

//// Интерфейс обработчика поддержки
//public interface ISupportHandler
//{
//    // Метод для обработки запроса
//    void HandlerRequest(SupportRequest supportRequest);

//    // Метод для установки следующего обработчика в цепочке
//    ISupportHandler SetNextHandler(ISupportHandler nextHandler);
//}

//// Абстрактный класс обработчика поддержки, реализующий интерфейс ISupportHandler
//public abstract class SupportHandler : ISupportHandler
//{
//    // Следующий элемент в цепочке обработчиков
//    protected ISupportHandler _nextHandler;

//    // Абстрактный метод для обработки запроса
//    public abstract void HandlerRequest(SupportRequest supportRequest);

//    // Метод для установки следующего обработчика в цепочке
//    public ISupportHandler SetNextHandler(ISupportHandler nextHandler)
//    {
//        _nextHandler = nextHandler;
//        return nextHandler;
//    }
//}

//// Реализация обработчика поддержки первой линии
//public class BasicSupportHandler : SupportHandler
//{
//    public override void HandlerRequest(SupportRequest supportRequest)
//    {
//        // Если уровень сложности <= 1, обрабатываем запрос
//        if (supportRequest.Complexity <= 1)
//        {
//            Console.WriteLine("Базовая поддержка: Можем обработать");
//        }
//        else
//        {
//            // Иначе передаем запрос следующему обработчику
//            _nextHandler.HandlerRequest(supportRequest);
//        }
//    }
//}

//// Реализация обработчика поддержки второй линии
//public class AdvancedSupportHandler : SupportHandler
//{
//    public override void HandlerRequest(SupportRequest supportRequest)
//    {
//        // Если уровень сложности <= 4, обрабатываем запрос
//        if (supportRequest.Complexity <= 4)
//        {
//            Console.WriteLine("Расширенная поддержка: Можем обработать");
//        }
//        else
//        {
//            // Иначе передаем запрос следующему обработчику
//            _nextHandler.HandlerRequest(supportRequest);
//        }
//    }
//}

//// Реализация обработчика поддержки третьей линии
//public class ExpertSupportHandler : SupportHandler
//{
//    public override void HandlerRequest(SupportRequest supportRequest)
//    {
//        // Если уровень сложности <= 6, обрабатываем запрос
//        if (supportRequest.Complexity <= 6)
//        {
//            Console.WriteLine("Экспертная поддержка: Можем обработать");
//        }
//        else
//        {
//            // Иначе сообщаем, что не можем обработать запрос
//            Console.WriteLine("Экспертная поддержка: Не можем обработать");
//        }
//    }
//}

