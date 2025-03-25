//class Program
//{
//    static void Main()
//    {
//        List<IVehicle> vehicles = new List<IVehicle>()
//        {
//            new Car(),
//            new Bike(),
//            new Truck()
//        };

//        foreach (IVehicle vehicle in vehicles)
//        {
//            VehicleInspector inspector = new VehicleInspector();
//            vehicle.Accept(inspector);
//            Console.WriteLine(inspector.Description);
//        }
//    }
//}

//// Интерфейс посетителя
//interface IVehicleVisitor
//{
//    void Visit(Car car);
//    void Visit(Bike bike);
//    void Visit(Truck truck);
//}

//// Интерфейс транспортного средства
//interface IVehicle
//{
//    void Accept(IVehicleVisitor visitor);
//}

//// Класс легкового автомобиля
//class Car : IVehicle
//{
//    public void Accept(IVehicleVisitor visitor)
//    {
//        visitor.Visit(this);
//    }
//}

//// Класс велосипеда
//class Bike : IVehicle
//{
//    public void Accept(IVehicleVisitor visitor)
//    {
//        visitor.Visit(this);
//    }
//}

//// Класс грузовика
//class Truck : IVehicle
//{
//    public void Accept(IVehicleVisitor visitor)
//    {
//        visitor.Visit(this);
//    }
//}

//// Класс инспектора транспортных средств
//class VehicleInspector : IVehicleVisitor
//{
//    public string Description { get; private set; }

//    public void Visit(Car car)
//    {
//        Description = "Легковой автомобиль: проверка тормозов и масла.";
//    }

//    public void Visit(Bike bike)
//    {
//        Description = "Велосипед: проверка колес и тормозов.";
//    }

//    public void Visit(Truck truck)
//    {
//        Description = "Грузовик: проверка груза и системы тормозов.";
//    }
//}