
//class Program
//{
//    static void Main()
//    {
//        // Создаем объект получателя, который будет выполнять действия
//        Receiver receiver = new Receiver();

//        // Создаем конкретные команды с сообщениями и получателем
//        Command command1 = new ConcreteCommand(receiver, "TV on");
//        Command command2 = new ConcreteCommand(receiver, "Channel 2");
//        Command command3 = new ConcreteCommand(receiver, "Sound Off");

//        // Создаем объект инициатора, который будет управлять командами
//        Invoker invoker = new Invoker();

//        // Добавляем команды
//        invoker.AddCommand(command1);
//        invoker.AddCommand(command2);
//        invoker.AddCommand(command3);

//        // Выполняем все команды
//        invoker.ExecuteCommands();

//        // Отменяем последние две команды
//        invoker.UndoLastCommand();
//        invoker.UndoLastCommand();
//    }
//}
//// Интерфейс команды с методами для выполнения и отмены команды
//public interface Command
//{
//    void Execute(); // Метод для выполнения команды
//    void Undo();    // Метод для отмены команды
//}

//// Класс получателя, который выполняет конкретные действия
//public class Receiver
//{
//    // Метод для выполнения действия с заданным сообщением
//    public void Action(string message)
//    {
//        Console.WriteLine($"Receiver invoked: {message}");
//    }

//    // Метод для отмены действия с заданным сообщением
//    public void UndoAction(string message)
//    {
//        Console.WriteLine($"Receiver undoing: {message}");
//    }
//}

//// Класс инициатора, который управляет командами
//public class Invoker
//{
//    // Список для хранения команд
//    private readonly List<Command> commands = new List<Command>();

//    // Стек для хранения выполненных команд для возможности их отмены
//    private readonly Stack<Command> _UndoStack = new Stack<Command>();

//    // Метод для добавления команды в список
//    public void AddCommand(Command command)
//    {
//        commands.Add(command);
//    }

//    // Метод для отмены последней выполненной команды
//    public void UndoLastCommand()
//    {
//        if (_UndoStack.Count > 0)
//        {
//            var command = _UndoStack.Pop();
//            command.Undo();
//        }
//    }

//    // Метод для выполнения всех команд в списке
//    public void ExecuteCommands()
//    {
//        foreach (var command in commands)
//        {
//            command.Execute();
//            _UndoStack.Push(command); // Добавляем команду в стек после выполнения
//        }

//        commands.Clear(); // Очищаем список команд после выполнения
//    }
//}

//// Конкретная реализация команды
//public class ConcreteCommand : Command
//{
//    private readonly Receiver _receiver; // Получатель, который будет выполнять действие
//    private readonly string _message;    // Сообщение, связанное с командой

//    // Конструктор для инициализации получателя и сообщения
//    public ConcreteCommand(Receiver receiver, string message)
//    {
//        _receiver = receiver;
//        _message = message;
//    }

//    // Выполнение команды
//    public void Execute()
//    {
//        _receiver.Action(_message);
//    }

//    // Отмена команды
//    public void Undo()
//    {
//        _receiver.UndoAction(_message);
//    }
//}



