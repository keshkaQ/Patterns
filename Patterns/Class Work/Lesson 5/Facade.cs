//internal class Programm
//{
//    static void Main()
//    {
//        // Создаем экземпляры подсистем
//        var subSystemA = new SubSystemA();
//        var subSystemB = new SubSystemB();
//        var subSystemC = new SubSystemC();

//        // Создаем экземпляр фасада, передавая ему подсистемы
//        var facade = new Facade(subSystemA, subSystemB, subSystemC);

//        // Вызываем операции фасада
//        facade.Operation1();
//        facade.Operation2();
//    }
//}

//// Класс фасада, который предоставляет упрощенный интерфейс для взаимодействия с подсистемами
//public class Facade
//{
//    // Приватные поля для хранения подсистем
//    private SubSystemA _subSystemA;
//    private SubSystemB _subSystemB;
//    private SubSystemC _subSystemC;

//    // Конструктор для инициализации подсистем
//    public Facade(SubSystemA subSystemA, SubSystemB subSystemB, SubSystemC subSystemC)
//    {
//        _subSystemA = subSystemA;
//        _subSystemB = subSystemB;
//        _subSystemC = subSystemC;
//    }

//    // Метод для выполнения операции 1, используя подсистемы
//    public void Operation1()
//    {
//        // Вызываем операции подсистем в определенном порядке
//        _subSystemA.OperationA();
//        _subSystemB.OperationB();
//        _subSystemC.OperationC();
//    }

//    // Метод для выполнения операции 2, используя подсистемы
//    public void Operation2()
//    {
//        // Вызываем операции подсистем в другом порядке
//        _subSystemB.OperationB();
//        _subSystemC.OperationC();
//        _subSystemA.OperationA();
//    }
//}

//// Подсистема A с методом OperationA
//public class SubSystemA
//{
//    // Метод для выполнения операции A
//    public void OperationA()
//    {
//        // Логика выполнения операции A
//        Console.WriteLine("Выполняется операция A.");
//    }
//}

//// Подсистема B с методом OperationB
//public class SubSystemB
//{
//    // Метод для выполнения операции B
//    public void OperationB()
//    {
//        // Логика выполнения операции B
//        Console.WriteLine("Выполняется операция B.");
//    }
//}

//// Подсистема C с методом OperationC
//public class SubSystemC
//{
//    // Метод для выполнения операции C
//    public void OperationC()
//    {
//        // Логика выполнения операции C
//        Console.WriteLine("Выполняется операция C.");
//    }
//}
