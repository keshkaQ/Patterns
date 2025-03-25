//class Program
//{
//    static void Main()
//    {
//        // Создаем экземпляр квест-игры и запускаем её
//        var questGame = new QuestGame();
//        questGame.Play();

//        Console.WriteLine();

//        // Создаем экземпляр шутера и запускаем его
//        var shooterGame = new ShooterGame();
//        shooterGame.Play();
//    }
//}

//// Абстрактный класс для игры
//abstract class Game
//{
//    // Метод для игры, который включает в себя все этапы
//    public void Play()
//    {
//        Download();        // Скачивание игры
//        Installation();    // Установка игры
//        BeforeStart();     // Хук перед началом игры
//        StartGame();       // Запуск игры
//        EndGame();         // Завершение игры
//        DeleteGame();      // Удаление игры
//        AfterDelete();     // Хук после удаления игры
//    }

//    // Методы, которые должны быть реализованы в подклассах
//    protected abstract void Download();      // Скачивание игры
//    protected abstract void Installation();   // Установка игры
//    protected abstract void StartGame();      // Запуск игры
//    protected abstract void EndGame();        // Завершение игры
//    protected abstract void DeleteGame();     // Удаление игры

//    // Хуки с реализацией по умолчанию, могут быть переопределены в подклассах
//    protected virtual void BeforeStart() { } // Хук перед началом игры
//    protected virtual void AfterDelete() { } // Хук после удаления игры
//}

//// Класс для квест-игры, наследующий от Game
//class QuestGame : Game
//{
//    protected override void Download()
//    {
//        Console.WriteLine("Скачивание квест-игры");
//    }

//    protected override void Installation()
//    {
//        Console.WriteLine("Установка квест-игры");
//    }

//    protected override void StartGame()
//    {
//        Console.WriteLine("Запуск квест-игры");
//    }

//    protected override void EndGame()
//    {
//        Console.WriteLine("Конец квест-игры");
//    }

//    protected override void DeleteGame()
//    {
//        Console.WriteLine("Удаление квест-игры");
//    }

//    // Пример использования хука для подготовки к запуску игры
//    protected override void BeforeStart()
//    {
//        Console.WriteLine("Подготовка к запуску квест-игры");
//    }
//}

//// Класс для шутера, наследующий от Game
//class ShooterGame : Game
//{
//    protected override void Download()
//    {
//        Console.WriteLine("Скачивание шутера");
//    }

//    protected override void Installation()
//    {
//        Console.WriteLine("Установка шутера");
//    }

//    protected override void StartGame()
//    {
//        Console.WriteLine("Запуск шутера");
//    }

//    protected override void EndGame()
//    {
//        Console.WriteLine("Конец шутера");
//    }

//    protected override void DeleteGame()
//    {
//        Console.WriteLine("Удаление шутера");
//    }

//    // Пример использования хука для очистки после удаления игры
//    protected override void AfterDelete()
//    {
//        Console.WriteLine("Очистка после удаления шутера");
//    }
//}
