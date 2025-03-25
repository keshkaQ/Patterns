//class Program
//{
//    // Метод для выполнения команды через цепочку работников
//    public static void GiveCommand(IWorker worker, string command)
//    {
//        // Выполнение команды и получение результата
//        string result = worker.Execute(command);

//        // Проверка результата выполнения команды
//        if (result == string.Empty)
//        {
//            // Если команда не может быть выполнена, выводим сообщение
//            Console.WriteLine(command + " не может быть выполнена");
//        }
//        else
//        {
//            // Если команда выполнена, выводим результат
//            Console.WriteLine(result);
//        }
//    }

//    static void Main()
//    {
//        // Создание экземпляров работников
//        var designer = new Designer();
//        var builder = new Builder();
//        var finishingWorker = new FinishingWorker();

//        // Установка цепочки работников
//        designer
//            .SetNextWorker(builder)           // Проектировщик передает команду строителю
//            .SetNextWorker(finishingWorker);  // Строитель передает команду отделочнику

//        // Происходит перебор цепочки для выбора того, кто сможет обработать запрос

//        // Выполнение команд через цепочку
//        GiveCommand(designer, "спроектировать дом");
//        GiveCommand(designer, "класть кирпич");
//        GiveCommand(designer, "клеить обои");

//        // Команда, которую никто не может выполнить
//        GiveCommand(designer, "провести проводку");
//    }
//}

//// Интерфейс работника, определяющий методы для установки следующего работника и выполнения команды
//interface IWorker
//{
//    IWorker SetNextWorker(IWorker worker);
//    string Execute(string command);
//}

//// Абстрактный класс работника, реализующий интерфейс IWorker
//abstract class Worker : IWorker
//{
//    protected IWorker nextWorker;  // Следующий работник в цепочке

//    protected Worker()
//    {
//        nextWorker = null;  // Изначально следующего работника нет
//    }

//    // Установка следующего работника в цепочке
//    public IWorker SetNextWorker(IWorker worker)
//    {
//        nextWorker = worker;
//        return worker;
//    }

//    // Виртуальный метод выполнения команды
//    public virtual string Execute(string command)
//    {
//        // Если есть следующий работник, передаем команду ему
//        if (nextWorker != null)
//        {
//            return nextWorker.Execute(command);
//        }
//        // Если следующего работника нет, возвращаем пустую строку
//        return string.Empty;
//    }
//}

//// Класс проектировщика, который может выполнять команду "спроектировать дом"
//class Designer : Worker
//{
//    public override string Execute(string command)
//    {
//        if (command == "спроектировать дом")
//        {
//            return "Проектировщик выполнил команду: " + command;
//        }
//        else
//        {
//            // Если команда не может быть выполнена, передаем ее следующему работнику
//            return nextWorker.Execute(command);
//        }
//    }
//}

//// Класс строителя, который может выполнять команду "класть кирпич"
//class Builder : Worker
//{
//    public override string Execute(string command)
//    {
//        if (command == "класть кирпич")
//        {
//            return "Строитель выполнил команду: " + command;
//        }
//        else
//        {
//            // Если команда не может быть выполнена, передаем ее следующему работнику
//            return nextWorker.Execute(command);
//        }
//    }
//}

//// Класс отделочника, который может выполнять команду "клеить обои"
//class FinishingWorker : Worker
//{
//    public override string Execute(string command)
//    {
//        if (command == "клеить обои")
//        {
//            return "Рабочий внутренней отделки выполнил команду: " + command;
//        }
//        else
//        {
//            // Если команда не может быть выполнена, передаем ее следующему работнику
//            try
//            {
//                return nextWorker.Execute(command);
//            }
//            catch(Exception exp)
//            {
//                return string.Empty;
//            }
//        }
//    }
//}

