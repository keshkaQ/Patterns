//class Program
//{
//    static void Main(string[] args)
//    {
//        // Создаем свет и устанавливаем начальное состояние
//        Light light = new Light();

//        // Включаем свет
//        light.Click();

//        // Выключаем свет
//        light.Click();
//    }
//}

//// Интерфейс состояния света
//interface ILightState
//{
//    void PressSwitch(Light light);
//}
//// Класс света, который использует паттерн Состояние
//class Light
//{
//    // Текущее состояние света
//    public ILightState State { get; set; }

//    public Light()
//    {
//        // Начальное состояние: свет выключен
//        State = new StateLightOff();
//    }

//    // Метод для нажатия выключателя 
//    public void Click()
//    {
//        State.PressSwitch(this);
//    }
//}

//// Конкретное состояние: свет выключен
//class StateLightOff : ILightState
//{
//    public void PressSwitch(Light light)
//    {
//        Console.WriteLine("Turning on the light");
//        light.State = new StateLightOn();
//    }
//}

//// Конкретное состояние: свет включен
//class StateLightOn : ILightState
//{
//    public void PressSwitch(Light light)
//    {
//        Console.WriteLine("Turning off the light");
//        light.State = new StateLightOff();
//    }
//}

