
//internal class Programm
//{
//    static void Main()
//    {
//        // Создаем экземпляр героя с 3 жизнями и 10 патронами
//        var hero = new Hero(3, 10);
//        // Создаем экземпляр истории игры
//        var gameHistory = new GameHistory();

//        Console.WriteLine("Стреляем");
//        // Герой стреляет несколько раз
//        hero.Shoot();
//        hero.Shoot();
//        hero.Shoot();
//        hero.Shoot();

//        // Сохраняем текущее состояние героя
//        var history = hero.SaveState();
//        // Добавляем состояние в историю игры
//        gameHistory.Add(history);
//        Console.WriteLine("Сохраняем состояние");

//        Console.WriteLine("Стреляем");
//        // Герой стреляет еще несколько раз
//        hero.Shoot();
//        hero.Shoot();
//        hero.Shoot();

//        // Восстанавливаем сохраненное состояние героя
//        history = gameHistory.Pop();
//        hero.RestoreState(history);
//        Console.WriteLine("Восстанавливаем состояние");

//        // Герой стреляет еще несколько раз
//        hero.Shoot();
//        hero.Shoot();
//        hero.Shoot();
//    }
//}

//public class Hero
//{
//    // Приватные поля для хранения количества жизней и патронов
//    private int _lives;
//    private int _ammunition;

//    // Конструктор для инициализации героя
//    public Hero(int lives, int ammunition)
//    {
//        _lives = lives;
//        _ammunition = ammunition;
//    }

//    // Метод для стрельбы, уменьшает количество патронов
//    public void Shoot()
//    {
//        if (_ammunition > 0)
//        {
//            _ammunition--;
//            Console.WriteLine($"Количество патронов: {_ammunition}");
//        }
//        else
//        {
//            Console.WriteLine("Патроны закончились!");
//        }
//    }

//    // Метод для сохранения текущего состояния героя
//    public HeroMemento SaveState()
//    {
//        return new HeroMemento(_lives, _ammunition);
//    }

//    // Метод для восстановления состояния героя из сохраненного
//    public void RestoreState(HeroMemento heroMemento)
//    {
//        _lives = heroMemento.Lives;
//        _ammunition = heroMemento.Ammunition;
//    }
//}

//public class HeroMemento
//{
//    // Свойства для хранения состояния героя
//    public int Lives { get; set; }
//    public int Ammunition { get; set; }

//    // Конструктор для инициализации состояния героя
//    public HeroMemento(int lives, int ammunition)
//    {
//        Lives = lives;
//        Ammunition = ammunition;
//    }
//}

//public class GameHistory
//{
//    // Приватное поле для хранения истории состояний героя
//    private Stack<HeroMemento> History { get; set; }

//    // Конструктор для инициализации стека истории
//    public GameHistory()
//    {
//        History = new Stack<HeroMemento>();
//    }

//    // Метод для добавления состояния в историю
//    public void Add(HeroMemento heroMemento)
//    {
//        History.Push(heroMemento);
//    }

//    // Метод для извлечения последнего состояния из истории
//    public HeroMemento Pop()
//    {
//        if (History.Count > 0)
//        {
//            return History.Pop();
//        }
//        else
//        {
//            Console.WriteLine("История пуста!");
//            return null;
//        }
//    }
//}
