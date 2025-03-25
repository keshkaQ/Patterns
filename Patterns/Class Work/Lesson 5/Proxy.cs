//internal class Programm
//{
//    static void Main()
//    {
//        // Создаем экземпляр прокси-класса
//        var myProxy = new MyProxy();

//        // Вызываем метод действия через прокси
//        myProxy.SomeAction();
//    }
//}

//// Абстрактный класс субъекта с абстрактным методом действия
//public abstract class Subject
//{
//    // Абстрактный метод для выполнения действия
//    public abstract void SomeAction();
//}

//// Реальный субъект, который наследует от абстрактного класса Subject
//public class RealSubject : Subject
//{
//    // Переопределение метода действия
//    public override void SomeAction()
//    {
//        // Логика выполнения действия
//        Console.WriteLine("Выполняется действие реального субъекта.");
//    }
//}

//// Прокси-класс, который наследует от абстрактного класса Subject
//public class MyProxy : Subject
//{
//    // Приватное поле для хранения экземпляра реального субъекта
//    private RealSubject realSubject;

//    // Конструктор для инициализации реального субъекта
//    public MyProxy()
//    {
//        realSubject = new RealSubject();
//    }

//    // Переопределение метода действия
//    public override void SomeAction()
//    {
//        // Логирование или дополнительная логика перед вызовом метода реального субъекта
//        Console.WriteLine("Логирование или дополнительная логика в прокси.");

//        // Вызов метода действия реального субъекта
//        realSubject.SomeAction();
//    }
//}



