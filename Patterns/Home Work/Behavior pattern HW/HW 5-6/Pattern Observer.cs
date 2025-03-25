
//class Program
//{
//    static void Main()
//    {
//        // Создаем метеостанцию с начальной температурой 15°
//        MeteoStation meteo = new MeteoStation(15);

//        // Создаем наблюдателей (автоматически подписываются)
//        Weatherman weatherman = new Weatherman(meteo);
//        Forecaster forecaster = new Forecaster(meteo);

//        // Изменяем температуру (вызовет уведомления)
//        meteo.ChangeTemperature(9);   // Сработает Weatherman
//        meteo.ChangeTemperature(-3);  // Сработает Forecaster
//    }
//}
//interface IObserver
//{
//    // Метод, вызываемый при изменении состояния наблюдаемого объекта
//    void Update(double temp);
//}

//// Интерфейс наблюдаемого объекта (издателя)
//interface IObservable
//{
//    // Добавить наблюдателя
//    void AddObserver(IObserver iobserver);
//    // Удалить наблюдателя
//    void RemoveObserver(IObserver iobserver);
//    // Уведомить всех наблюдателей об изменениях
//    void Notify();
//}

//// Класс метеостанции - наблюдаемый объект
//class MeteoStation : IObservable
//{
//    private List<IObserver> observers;  // Список наблюдателей
//    private double _temperature;       // Текущая температура

//    // Конструктор метеостанции
//    public MeteoStation(double temperature)
//    {
//        _temperature = temperature;
//        observers = new List<IObserver>();
//    }

//    // Метод для изменения температуры
//    public void ChangeTemperature(double temperature)
//    {
//        _temperature = temperature;
//        Notify();  // Уведомляем всех наблюдателей об изменении
//    }

//    // Реализация методов интерфейса IObservable

//    // Добавление наблюдателя
//    public void AddObserver(IObserver iobserver)
//    {
//        observers.Add(iobserver);
//    }

//    // Удаление наблюдателя
//    public void RemoveObserver(IObserver iobserver)
//    {
//        observers.Remove(iobserver);
//    }

//    // Уведомление всех наблюдателей
//    public void Notify()
//    {
//        for (int i = 0; i < observers.Count; i++)
//        {
//            observers[i].Update(_temperature);
//        }
//    }
//}

//// Класс наблюдателя - метеоролог
//class Weatherman : IObserver
//{
//    private IObservable meteoStation;  // Ссылка на наблюдаемый объект

//    // Конструктор метеоролога
//    public Weatherman(MeteoStation meteoStation)
//    {
//        this.meteoStation = meteoStation;
//        meteoStation.AddObserver(this);  // Автоматическая подписка при создании
//    }

//    // Метод, вызываемый при изменении температуры
//    public void Update(double temperature)
//    {
//        if (temperature < 10)
//        {
//            Console.WriteLine("Weatherman: Temperature is below 10 degrees. Current temperature: " + temperature);
//            meteoStation.RemoveObserver(this);  // Отписываемся после реакции
//        }
//    }
//}

//// Класс наблюдателя - прогнозист
//class Forecaster : IObserver
//{
//    private IObservable meteoStation;  // Ссылка на наблюдаемый объект

//    // Конструктор прогнозиста
//    public Forecaster(MeteoStation meteoStation)
//    {
//        this.meteoStation = meteoStation;
//        meteoStation.AddObserver(this);  // Автоматическая подписка при создании
//    }

//    // Метод, вызываемый при изменении температуры
//    public void Update(double temperature)
//    {
//        if (temperature < 5)
//        {
//            Console.WriteLine("Forecaster: Temperature is below 5 degrees. Current temperature: " + temperature);
//            meteoStation.RemoveObserver(this);  // Отписываемся после реакции
//        }
//    }
//}