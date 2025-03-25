///*Реализуйте паттерн Builder для создания сложного объекта "Пицца". Пользователь 
//должен иметь возможность выбирать различные ингредиенты (например, тесто, соус, начинки).*/

//class Program
//{
//    static void Main()
//    {
//        // Создаем строителя для обычной пиццы (шеф-повар)
//        IPizzaBuilder chefBuilder = new ChefPizzaBuilder();
//        // Создаем директора, который будет управлять процессом создания пиццы
//        Director director = new Director(chefBuilder);
//        // Конструируем обычную пиццу
//        Pizza pizza = director.ConstructPizza();
//        // Выводим описание пиццы
//        Console.WriteLine("Pizza: " + pizza);

//        // Создаем строителя для веганской пиццы (су-шеф)
//        IPizzaBuilder souchefBuilder = new SouchefPizzaBuilder();
//        // Устанавливаем нового строителя в директоре
//        director.SetPizzaBuilder(souchefBuilder);
//        // Конструируем веганскую пиццу
//        Pizza veganPizza = director.ConstructVeganPizza();
//        // Выводим описание веганской пиццы
//        Console.WriteLine("Vegan Pizza: " + veganPizza);
//    }
//}
//// Класс для представления пиццы
//class Pizza
//{
//    private string description;

//    // Конструктор, инициализирующий описание пиццы
//    public Pizza()
//    {
//        description = "Pizza ingredients: "; // Начальное описание
//    }

//    // Метод для добавления ингредиента в пиццу
//    public void AddPart(string part)
//    {
//        description += part + "; "; // Добавляем ингредиент к описанию
//    }

//    // Переопределение метода ToString для вывода описания пиццы
//    public override string ToString()
//    {
//        return description;
//    }
//}

//// Интерфейс для строителя пиццы
//interface IPizzaBuilder
//{
//    void AddSausages(); // Метод для добавления колбасы
//    void AddCheese();   // Метод для добавления сыра
//    void AddTomatoes(); // Метод для добавления помидоров
//    Pizza GetPizza();   // Метод для получения готовой пиццы
//}

//// Класс строителя пиццы для шеф-повара
//class ChefPizzaBuilder : IPizzaBuilder
//{
//    private Pizza pizza; // Экземпляр пиццы

//    // Конструктор, инициализирующий новую пиццу
//    public ChefPizzaBuilder()
//    {
//        pizza = new Pizza();
//    }

//    // Реализация метода добавления колбасы
//    public void AddSausages()
//    {
//        pizza.AddPart("Sausages");
//    }

//    // Реализация метода добавления сыра
//    public void AddCheese()
//    {
//        pizza.AddPart("Cheese");
//    }

//    // Реализация метода добавления помидоров
//    public void AddTomatoes()
//    {
//        pizza.AddPart("Tomatoes");
//    }

//    // Возврат готовой пиццы
//    public Pizza GetPizza()
//    {
//        return pizza;
//    }
//}

//// Класс строителя пиццы для су-шефа
//class SouchefPizzaBuilder : IPizzaBuilder
//{
//    private Pizza pizza; // Экземпляр пиццы

//    // Конструктор, инициализирующий новую пиццу
//    public SouchefPizzaBuilder()
//    {
//        pizza = new Pizza();
//    }

//    // Реализация метода добавления колбасы (пепперони)
//    public void AddSausages()
//    {
//        pizza.AddPart("pepperoni");
//    }

//    // Реализация метода добавления сыра (сливочный сыр)
//    public void AddCheese()
//    {
//        pizza.AddPart("cream cheese");
//    }

//    // Реализация метода добавления помидоров (черри)
//    public void AddTomatoes()
//    {
//        pizza.AddPart("cherry tomatoes");
//    }

//    // Возврат готовой пиццы
//    public Pizza GetPizza()
//    {
//        return pizza;
//    }
//}

//// Класс-директор, управляющий процессом создания пиццы
//class Director
//{
//    private IPizzaBuilder pizzaBuilder; // Строитель пиццы

//    // Конструктор, инициализирующий строителя
//    public Director(IPizzaBuilder pizzaBuilder)
//    {
//        this.pizzaBuilder = pizzaBuilder;
//    }

//    // Метод для установки нового строителя
//    public void SetPizzaBuilder(IPizzaBuilder pizzaBuilder)
//    {
//        this.pizzaBuilder = pizzaBuilder; // Установка нового строителя
//    }

//    // Метод для конструирования веганской пиццы
//    public Pizza ConstructVeganPizza()
//    {
//        pizzaBuilder.AddCheese();    // Добавление сыра
//        pizzaBuilder.AddTomatoes();   // Добавление помидоров
//        return pizzaBuilder.GetPizza(); // Возврат готовой пиццы
//    }

//    // Метод для конструирования обычной пиццы
//    public Pizza ConstructPizza()
//    {
//        pizzaBuilder.AddCheese();
//        pizzaBuilder.AddTomatoes();
//        pizzaBuilder.AddSausages();
//        return pizzaBuilder.GetPizza();
//    }
//}


