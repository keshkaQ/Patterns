//class Programm
//{
//    static void Main()
//    {
//        // Создаем прокси для сайта, передавая реальный объект сайта
//        ISite mySite = new SiteProxy(new Site());

//        // Первый запрос страниц (будут загружены с сайта)
//        Console.WriteLine(mySite.GetPage(1)); // Загрузит страницу 1
//        Console.WriteLine(mySite.GetPage(2)); // Загрузит страницу 2
//        Console.WriteLine(mySite.GetPage(3)); // Загрузит страницу 3

//        // Повторный запрос страницы 2 (будет взят из кэша)
//        Console.WriteLine(mySite.GetPage(2)); // Возьмет из кэша
//    }
//}

//// Интерфейс сайта
//interface ISite
//{
//    string GetPage(int num); // Метод получения страницы по номеру
//}

//// Реальный класс сайта
//class Site : ISite
//{
//    public string GetPage(int num)
//    {
//        // Имитация загрузки страницы с сервера
//        return "Это страница " + num;
//    }
//}

//// Прокси-класс для сайта с кэшированием
//class SiteProxy : ISite
//{
//    private ISite site; // Ссылка на реальный объект сайта
//    private Dictionary<int, string> cashe; // Кэш страниц

//    public SiteProxy(ISite site)
//    {
//        this.site = site;
//        cashe = new Dictionary<int, string>(); // Инициализация кэша
//    }

//    public string GetPage(int num)
//    {
//        string page;

//        // Проверяем, есть ли страница в кэше
//        if (cashe.ContainsKey(num))
//        {
//            // Берем страницу из кэша и добавляем пометку
//            page = cashe[num];
//            page = "из кэша: " + page;
//        }
//        else
//        {
//            // Если нет в кэше - загружаем с реального сайта
//            page = site.GetPage(num);
//            // Сохраняем в кэш для будущих запросов
//            cashe.Add(num, page);
//        }

//        return page;
//    }
//}