
//var observer1 = new Observer1("observer1");
//var observer2 = new Observer2("observer2");
//var observer3 = new Observer1("observer3");
//var observer4 = new Observer2("observer4");

//var observable = new Observable();

//observable.AddObserver(observer1);
//observable.AddObserver(observer2);
//observable.AddObserver(observer3);

//observable.Name = "Not Empty";
//observable.NotifyObserver();
//observable.RemoveObserver(observer3);

//observable.Name = "Some Name";

//observable.NotifyObserver();


//interface IObservable
//{
//    void AddObserver(IObserver observer);
//    void RemoveObserver(IObserver observer);
//    void NotifyObserver();
//}
//interface IObserver
//{
//    void Update(string name);
//}

//class Observable : IObservable
//{
//    private List<IObserver> observers;
//    public string Name { get; set; }
//    public Observable()
//    {
//        observers = new List<IObserver>();
//    }
//    public void AddObserver(IObserver observer)
//    {

//        observers.Add(observer);
//    }
//    public void RemoveObserver(IObserver observer)
//    {
//        observers.Remove(observer);
//    }
//    public void NotifyObserver()
//    {
//        for (int i = 0; i < observers.Count; i++)
//        {
//            observers[i].Update(Name);
//        }
//    }
//}


//class Observer1 : IObserver
//{
//    private string _nameObject;
//    public Observer1(string nameObject)
//    {
//        _nameObject = nameObject;
//    }
//    public void Update(string name)
//    {
//        Console.WriteLine(name);
//    }
//}
//class Observer2 : IObserver
//{
//    private string _nameObject;
//    public Observer2(string nameObject)
//    {
//        _nameObject = nameObject;
//    }
//    public void Update(string name)
//    {
//        Console.WriteLine(_nameObject + name);
//    }
//}