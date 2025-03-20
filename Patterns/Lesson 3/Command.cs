
//var addObject = new AddObject("rock", 1, 1, 1);
//var invoker = new Invoker(addObject);
//var changeCoordinateObject = new ChangeCoordinateObject(1, 2, 3);
//invoker.AddCommand(changeCoordinateObject);
//invoker.UndoCommand();
//invoker.UndoCommand();

//public class Invoker
//{
//    private List<Command> commands;
//    public Invoker(Command command)
//    {
//        commands = new List<Command>();
//        commands.Add(command);
//        command.Execute();
//    }

//    public void AddCommand(Command command)
//    {
//        commands.Add(command);
//        command.Execute();
//    }

//    public void UndoCommand()
//    {
//        var command = commands[commands.Count - 1];
//        command.Undo();
//        commands.Remove(command);

//    }
//}

//public abstract class Command
//{
//    public abstract void Execute();
//    public abstract void Undo();
//}

//public class AddObject : Command
//{
//    private int _x;
//    private int _y;
//    private int _z;
//    private string _name;
//    public AddObject(string name, int x, int y, int z)
//    {
//        _name = name;

//        _x = x;
//        _y = y;
//        _z = z;
//    }

//    public override void Execute()
//    {
//        Console.WriteLine("Добавил объект");
//    }

//    public override void Undo()
//    {
//        _x = 0;
//        _y = 0;
//        _z = 0;

//        Console.WriteLine("Удалил объект");
//    }
//}

//public class ChangeCoordinateObject : Command
//{
//    private int _x;
//    private int _y;
//    private int _z;

//    public ChangeCoordinateObject(int x, int y, int z)
//    {
//        _x = x;
//        _y = y;
//        _z = z;
//    }

//    public override void Execute()
//    {
//        //...

//        Console.WriteLine($"Установил координаты {_x} {_y} {_z}");
//    }

//    public override void Undo()
//    {
//        _x = 0;
//        _y = 0;
//        _z = 0;

//        Console.WriteLine($"Отменили команду смены координат {_x} {_y} {_z}");
//    }
//}

