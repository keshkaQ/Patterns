//partial class Program
//{
//    static void Main()
//    {
//        // Создаем экземпляр медиатора
//        var myMainMediator = new MyMainMediator();

//        // Создаем коллег и передаем им медиатор
//        var colleague1 = new Colleague1(myMainMediator);
//        var colleague2 = new Colleague2(myMainMediator);

//        // Устанавливаем коллег в медиаторе
//        myMainMediator.Colleague1 = colleague1;
//        myMainMediator.Colleague2 = colleague2;

//        // Коллеги отправляют сообщения через медиатор
//        colleague1.Send("Привет");
//        colleague2.Send("Пока");
//    }
//}

//// Абстрактный класс медиатора
//public abstract class MyMediator
//{
//    // Абстрактный метод для отправки сообщения
//    public abstract void Send(string message, Colleague colleague);
//}

//// Абстрактный класс коллеги
//public abstract class Colleague
//{
//    // Ссылка на медиатор
//    protected MyMediator _myMediator;

//    // Конструктор, принимающий медиатор
//    public Colleague(MyMediator myMediator)
//    {
//        _myMediator = myMediator;
//    }
//}

//// Конкретный класс медиатора
//public class MyMainMediator : MyMediator
//{
//    // Хранение ссылок на коллег
//    public Colleague1 Colleague1 { get; set; }
//    public Colleague2 Colleague2 { get; set; }

//    // Переопределение метода для отправки сообщения
//    public override void Send(string message, Colleague colleague)
//    {
//        // Логика взаимодействия между коллегами
//        if (colleague == Colleague1)
//        {
//            Colleague2.Notify(message);
//        }
//        else if (colleague == Colleague2)
//        {
//            Colleague1.Notify(message);
//        }
//    }
//}

//// Конкретный класс первого коллеги
//public class Colleague1 : Colleague
//{
//    // Конструктор, передающий медиатор базовому классу
//    public Colleague1(MyMediator myMediator) : base(myMediator)
//    {
//    }

//    // Метод для отправки сообщения через медиатор
//    public void Send(string message)
//    {
//        _myMediator.Send(message, this);
//    }

//    // Метод для получения уведомлений
//    public void Notify(string message)
//    {
//        // Логика обработки уведомления
//        Console.WriteLine("Colleague1 получил сообщение: " + message);
//    }
//}

//// Конкретный класс второго коллеги
//public class Colleague2 : Colleague
//{
//    // Конструктор, передающий медиатор базовому классу
//    public Colleague2(MyMediator myMediator) : base(myMediator)
//    {
//    }

//    // Метод для отправки сообщения через медиатор
//    public void Send(string message)
//    {
//        _myMediator.Send(message, this);
//    }

//    // Метод для получения уведомлений
//    public void Notify(string message)
//    {
//        // Логика обработки уведомления
//        Console.WriteLine("Colleague2 получил сообщение: " + message);
//    }
//}
