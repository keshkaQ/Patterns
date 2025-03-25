//class Program
//{
//    static void Main()
//    {
//        // Создаем экземпляр медиатора
//        var mediator = new Mediator();

//        // Создаем коллег (заказчика, тестировщика и программиста)
//        var customer = new Customer(mediator);
//        var tester = new Tester(mediator);
//        var programmer = new Programmer(mediator);

//        // Устанавливаем связи между медиатором и коллегами
//        mediator.Customer = customer;
//        mediator.Tester = tester;
//        mediator.Programmer = programmer;

//        // Отправляем сообщения от заказчика
//        customer.Send("Получили заказ");

//        // Отправляем сообщения от программиста
//        programmer.Send("Нужно сделать программу");

//        // Отправляем сообщения от тестировщика
//        tester.Send("Программа готова, нужно тестировать");

//    }
//}

//// Интерфейс медиатора, определяющий метод отправки сообщений
//interface IMediator
//{
//    void Send(string msg, Colleague colleague);
//}

//// Абстрактный класс для коллег
//abstract class Colleague
//{
//    protected IMediator mediator; // Ссылка на медиатор

//    protected Colleague(IMediator mediator)
//    {
//        this.mediator = mediator; // Инициализация медиатора
//    }

//    // Метод для отправки сообщения через медиатор
//    public void Send(string msg)
//    {
//        mediator.Send(msg, this);
//    }

//    // Абстрактный метод для уведомления
//    public abstract void Notify(string msg);
//}

//// Реализация медиатора
//class Mediator : IMediator
//{
//    public Colleague Customer { get; set; } // Заказчик
//    public Colleague Programmer { get; set; } // Программист
//    public Colleague Tester { get; set; } // Тестировщик

//    // Метод отправки сообщений
//    public void Send(string msg, Colleague colleague)
//    {
//        // Уведомление соответствующего коллеги
//        if (Customer == colleague)
//        {
//            Customer.Notify(msg);
//        }
//        else if (Programmer == colleague)
//        {
//            Programmer.Notify(msg);
//        }
//        else if (Tester == colleague)
//        {
//            Tester.Notify(msg);
//        }
//    }
//}

//// Класс для заказчика
//class Customer : Colleague
//{
//    public Customer(IMediator mediator) : base(mediator)
//    { }

//    // Реализация метода уведомления
//    public override void Notify(string msg)
//    {
//        Console.WriteLine("Сообщение заказчику: " + msg);
//    }
//}

//// Класс для тестировщика
//class Tester : Colleague
//{
//    public Tester(IMediator mediator) : base(mediator)
//    { }

//    // Реализация метода уведомления
//    public override void Notify(string msg)
//    {
//        Console.WriteLine("Сообщение тестировщику: " + msg);
//    }
//}

//// Класс для программиста
//class Programmer : Colleague
//{
//    public Programmer(IMediator mediator) : base(mediator)
//    { }

//    // Реализация метода уведомления
//    public override void Notify(string msg)
//    {
//        Console.WriteLine("Сообщение программисту: " + msg);
//    }
//}