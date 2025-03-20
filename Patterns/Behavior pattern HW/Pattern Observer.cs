
//interface IObserver
//{
//    void Update(double temp);
//}

//interface IObservable
//{
//    void AddObserver(IObserver iobserver);
//    void RemoveObserver(IObserver iobserver);
//    void Notify();
//}


//class MeteoStation : IObservable
//{
//    private List<IObserver> observers;
//    private double _temperature;
//    public MeteoStation(double temperature)
//    {
//        _temperature = temperature;
//        observers = new List<IObserver>();
//    }
//    public void ChangeTemperature(double temperature)
//    {
//        _temperature = temperature;
//        Notify();
//    }

//    public void AddObserver(IObserver iobserver)
//    {
//        observers.Add(iobserver);
//    }
//    public void RemoveObserver(IObserver iobserver)
//    {
//        observers.Remove(iobserver);
//    }
//    public void Notify()
//    {
//        for (int i = 0; i < observers.Count; i++)
//        {
//            observers[i].Update(_temperature);
//        }
//    }
//}

//class Weatherman : IObserver
//{
//    private IObservable meteoStation;
//    public Weatherman(MeteoStation meteoStation)
//    {
//        this.meteoStation = meteoStation;
//        meteoStation.AddObserver(this);
//    }
//    public void Update(double temperature)
//    {
//        if (temperature < 10)
//        {
//            Console.WriteLine("Weatherman: Temperature is below 10 degrees. Current temperature: " + temperature);
//            meteoStation.RemoveObserver(this);
//        }
//    }
//}
//class Forecaster : IObserver
//{
//    private IObservable meteoStation;
//    public Forecaster(MeteoStation meteoStation)
//    {
//        this.meteoStation = meteoStation;
//        meteoStation.AddObserver(this);
//    }
//    public void Update(double temperature)
//    {
//        if (temperature < 5)
//        {
//            Console.WriteLine("Forecaster: Temperature is below 5 degrees. Current temperature: " + temperature);
//            meteoStation.RemoveObserver(this);
//        }
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        MeteoStation meteo = new MeteoStation(15);
//        Weatherman weatherman = new Weatherman(meteo);
//        Forecaster forecaster = new Forecaster(meteo);

//        meteo.ChangeTemperature(9);
//        meteo.ChangeTemperature(-3);

//    }
//}