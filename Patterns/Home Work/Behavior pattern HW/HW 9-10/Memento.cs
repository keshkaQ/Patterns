//class Programm
//{
//    static void Main()
//    {
//        var random = new Random();
//        // Создаем объект Exchange с начальными значениями долларов и евро
//        Exchange exchange = new Exchange(random.Next(10,50), random.Next(10,50));

//        // Создаем объект Memory для управления историей состояний
//        Memory memory = new Memory(exchange);

//        // Выводим начальное состояние
//        DisplayCurrentState(exchange);

//        // Выполняем операции: продажа долларов и покупка евро
//        PerformOperations(exchange, "Продаем доллары, покупаем евро", exchange.SellDollars, exchange.BuyEuros);

//        // Сохраняем текущее состояние в историю
//        memory.SaveInHistory();
//        Console.WriteLine("Сохранение состояния");

//        // Выполняем еще одну серию операций
//        PerformOperations(exchange, "Продаем доллары, покупаем евро", exchange.SellDollars, exchange.BuyEuros);

//        // Выводим текущее состояние после операций
//        DisplayCurrentState(exchange);

//        // Восстанавливаем предыдущее состояние из истории
//        memory.TakeFromHistory();
//        Console.WriteLine("Восстанавливаем состояние");

//        // Выводим состояние после восстановления
//        DisplayCurrentState(exchange);
//    }

//    // Метод для вывода текущего состояния биржи
//    static void DisplayCurrentState(Exchange exchange)
//    {
//        exchange.GetEuros();
//        exchange.GetDollars();
//    }

//    // Метод для выполнения операций продажи и покупки
//    static void PerformOperations(Exchange exchange, string message, Action sellAction, Action buyAction)
//    {
//        Console.WriteLine(message);
//        sellAction();
//        buyAction();
//    }
//}

//interface IMemento
//{
//    int GetDollars();
//    int GetEuros();
//}

//class ExchangeMemento : IMemento
//{
//    private int dollars;
//    private int euros;

//    public ExchangeMemento(int dollars, int euros)
//    {
//        this.dollars = dollars;
//        this.euros = euros;
//    }

//    public int GetDollars()
//    {
//        return dollars;
//    }

//    public int GetEuros()
//    {
//        return euros;
//    }
//}

//class Exchange
//{
//    private int dollars;
//    private int euros;

//    public Exchange(int dollars, int euros)
//    {
//        this.dollars = dollars;
//        this.euros = euros;
//    }

//    public void GetDollars()
//    {
//        Console.WriteLine($"Количество долларов на бирже: {dollars} $");
//    }

//    public void GetEuros()
//    {
//        Console.WriteLine($"Количество евро на бирже: {euros} E");
//    }

//    public void SellDollars()
//    {
//        if (dollars > 0)
//        {
//            --dollars;
//        }
//        else
//        {
//            Console.WriteLine("Недостаточно долларов для продажи.");
//        }
//    }

//    public void BuyEuros()
//    {
//        ++euros;
//    }

//    public ExchangeMemento SaveState()
//    {
//        return new ExchangeMemento(dollars, euros);
//    }

//    public void RestoreState(ExchangeMemento exchangeMemento)
//    {
//        this.dollars = exchangeMemento.GetDollars();
//        this.euros = exchangeMemento.GetEuros();
//    }
//}

//class Memory
//{
//    private Stack<IMemento> history;
//    Exchange exchange;

//    public Memory(Exchange exchange)
//    {
//        this.exchange = exchange;
//        history = new Stack<IMemento>();
//    }

//    public void SaveInHistory()
//    {
//        history.Push(exchange.SaveState());
//    }

//    public void TakeFromHistory()
//    {
//        if (history.Count == 0)
//        {
//            Console.WriteLine("История пуста. Нет состояния для восстановления.");
//            return;
//        }
//        exchange.RestoreState((ExchangeMemento)history.Pop());
//    }
//}