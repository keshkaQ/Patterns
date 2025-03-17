/*Создайте фабрику для создания различных типов транспортных средств (например,
автомобилей, велосипедов, мотоциклов). Реализуйте классы для каждого типа транспортного 
средства и фабричный метод для их создания*/

//using System;
//abstract class Transport
//{ }

//class Car : Transport
//{
//    public Car()
//    {
//        Console.WriteLine("The car is released ");
//    }
//}

//class Motorbike : Transport
//{
//    public Motorbike()
//    {
//        Console.WriteLine("The Motorbike is released");
//    }
//}
//class Bicycle : Transport
//{
//    public Bicycle()
//    {
//        Console.WriteLine("The Bicycle is released");
//    }
//}
//abstract class Factory
//{
//    abstract public Transport Create();
//}

//class CarFactory : Factory
//{

//    public override Transport Create()
//    {
//        return new Car();
//    }
//}

//class BicycleFactory : Factory
//{
//    public override Transport Create()
//    {
//        return new Bicycle();
//    }
//}
//class MotorbikeFactory : Factory
//{
//    public override Transport Create()
//    {
//        return new Motorbike();
//    }
//}

//partial class Program
//{
//    static void Main()
//    {
//        CarFactory carFactory = new CarFactory();
//        Transport car = carFactory.Create();

//        BicycleFactory bicycleFactory = new BicycleFactory();
//        Transport bicycle = bicycleFactory.Create();

//        MotorbikeFactory motorbikeFactory = new MotorbikeFactory();
//        Transport motorbike = motorbikeFactory.Create();

//        Console.ReadLine();
//    }
//}