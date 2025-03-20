//partial class Program
//{
//    static void Main()
//    {
//        // Создаем контекст заказа
//        var orderContext = new OrderContext();

//        // Запускаем обработку заказа
//        orderContext.Handle();
//    }
//}

//// Абстрактный класс состояния заказа
//public abstract class IOrderState
//{
//    // Абстрактный метод обработки, который должен быть реализован в каждом состоянии
//    public abstract void Handle(OrderContext orderContext);
//}

//// Контекст заказа, который управляет состоянием и обработкой заказа
//public class OrderContext
//{
//    // Текущее состояние заказа
//    public IOrderState orderState { get; set; }

//    // Конструктор, устанавливающий начальное состояние заказа
//    public OrderContext()
//    {
//        orderState = new CreateOrder();
//    }

//    // Метод для обработки текущего состояния заказа
//    public void Handle()
//    {
//        orderState.Handle(this);
//    }
//}

//// Состояние создания заказа
//public class CreateOrder : IOrderState
//{
//    public override void Handle(OrderContext orderContext)
//    {
//        // Логика создания заказа
//        Console.WriteLine("Заказ создан.");

//        // Переход к состоянию оплаты
//        orderContext.orderState = new PaidState();
//        orderContext.Handle();
//    }
//}

//// Состояние оплаты заказа
//public class PaidState : IOrderState
//{
//    public override void Handle(OrderContext orderContext)
//    {
//        // Логика оплаты заказа
//        Console.WriteLine("Заказ оплачен. Вызываем API банка для оплаты.");

//        // Переход к состоянию доставки
//        orderContext.orderState = new ShippedState();
//        orderContext.Handle();
//    }
//}

//// Состояние доставки заказа
//class ShippedState : IOrderState
//{
//    public override void Handle(OrderContext orderContext)
//    {
//        // Логика доставки заказа
//        Console.WriteLine("Заказ доставляется. Передача в сервис доставки.");

//        // Переход к состоянию завершения
//        orderContext.orderState = new CompleteState();
//        orderContext.Handle();
//    }
//}

//// Состояние завершения заказа
//class CompleteState : IOrderState
//{
//    public override void Handle(OrderContext orderContext)
//    {
//        // Логика завершения заказа
//        Console.WriteLine("Заказ завершен.");
//    }
//}

