///*Создайте фабрику для создания различных типов транспортных средств (например,
//автомобилей, велосипедов, мотоциклов). Реализуйте классы для каждого типа транспортного 
//средства и фабричный метод для их создания*/

//class Program
//{
//    static void Main()
//    {
//        // Создаем фабрику для автомобилей
//        CarFactory carFactory = new CarFactory();
//        // Создаем автомобиль через фабрику
//        Transport car = carFactory.Create();

//        // Создаем фабрику для велосипедов
//        BicycleFactory bicycleFactory = new BicycleFactory();
//        // Создаем велосипед через фабрику
//        Transport bicycle = bicycleFactory.Create();

//        // Создаем фабрику для мотоциклов
//        MotorbikeFactory motorbikeFactory = new MotorbikeFactory();
//        // Создаем мотоцикл через фабрику
//        Transport motorbike = motorbikeFactory.Create();

//        // Ожидаем ввода для завершения программы
//        Console.ReadLine();
//    }
//}

//// Абстрактный класс для всех транспортных средств
//abstract class Transport
//{ }

//// Класс для автомобилей, наследующий от Transport
//class Car : Transport
//{
//    // Конструктор, вызывается при создании автомобиля
//    public Car()
//    {
//        Console.WriteLine("The car is released "); // Выводим сообщение о создании автомобиля
//    }
//}

//// Класс для мотоциклов, наследующий от Transport
//class Motorbike : Transport
//{
//    // Конструктор, вызывается при создании мотоцикла
//    public Motorbike()
//    {
//        Console.WriteLine("The Motorbike is released"); // Выводим сообщение о создании мотоцикла
//    }
//}

//// Класс для велосипедов, наследующий от Transport
//class Bicycle : Transport
//{
//    // Конструктор, вызывается при создании велосипеда
//    public Bicycle()
//    {
//        Console.WriteLine("The Bicycle is released"); // Выводим сообщение о создании велосипеда
//    }
//}

//// Абстрактный класс для фабрик
//abstract class Factory
//{
//    // Абстрактный метод для создания транспортного средства
//    abstract public Transport Create();
//}

//// Фабрика для создания автомобилей
//class CarFactory : Factory
//{
//    // Реализация метода создания автомобиля
//    public override Transport Create()
//    {
//        return new Car(); // Возвращаем новый экземпляр автомобиля
//    }
//}

//// Фабрика для создания велосипедов
//class BicycleFactory : Factory
//{
//    // Реализация метода создания велосипеда
//    public override Transport Create()
//    {
//        return new Bicycle(); // Возвращаем новый экземпляр велосипеда
//    }
//}

//// Фабрика для создания мотоциклов
//class MotorbikeFactory : Factory
//{
//    // Реализация метода создания мотоцикла
//    public override Transport Create()
//    {
//        return new Motorbike(); // Возвращаем новый экземпляр мотоцикла
//    }
//}

