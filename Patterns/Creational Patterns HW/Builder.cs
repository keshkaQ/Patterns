/*Реализуйте паттерн Builder для создания сложного объекта "Пицца". Пользователь 
должен иметь возможность выбирать различные ингредиенты (например, тесто, соус, начинки).*/

//class Pizza
//{
//    private string description;

//    public Pizza()
//    {
//        description = "pizza ingredients: ";
//    }

//    public void AddPart(string part)
//    {
//        description += part + "; ";
//    }

//    public override string ToString()
//    {
//        return description;
//    }
//}

//interface IPizzaBuilder
//{
//    void AddSausages();
//    void AddCheese();
//    void AddTomatoes();
//    Pizza GetPizza();
//}

//class ChefPizzaBuilder : IPizzaBuilder
//{
//    private Pizza pizza;

//    public ChefPizzaBuilder()
//    {
//        pizza = new Pizza();
//    }

//    public void AddSausages()
//    {
//        pizza.AddPart("Sausages");
//    }

//    public void AddCheese()
//    {
//        pizza.AddPart("Cheese");
//    }

//    public void AddTomatoes()
//    {
//        pizza.AddPart("Tomatoes");
//    }

//    public Pizza GetPizza()
//    {
//        return pizza;
//    }
//}

//class SouchefPizzaBuilder : IPizzaBuilder
//{
//    private Pizza pizza;

//    public SouchefPizzaBuilder()
//    {
//        pizza = new Pizza();
//    }

//    public void AddSausages()
//    {
//        pizza.AddPart("pepperoni");
//    }

//    public void AddCheese()
//    {
//        pizza.AddPart("cream cheese");
//    }

//    public void AddTomatoes()
//    {
//        pizza.AddPart("cherry tomatoes");
//    }

//    public Pizza GetPizza()
//    {
//        return pizza;
//    }
//}

//class Director
//{
//    private IPizzaBuilder pizzaBuilder;

//    public Director(IPizzaBuilder pizzaBuilder)
//    {
//        this.pizzaBuilder = pizzaBuilder;
//    }

//    public void SetPizzaBuilder(IPizzaBuilder pizzaBuilder)
//    {
//        this.pizzaBuilder = pizzaBuilder;
//    }

//    public Pizza ConstructVeganPizza()
//    {
//        pizzaBuilder.AddCheese();
//        pizzaBuilder.AddTomatoes();
//        return pizzaBuilder.GetPizza();
//    }

//    public Pizza ConstructPizza()
//    {
//        pizzaBuilder.AddCheese();
//        pizzaBuilder.AddTomatoes();
//        pizzaBuilder.AddSausages();
//        return pizzaBuilder.GetPizza();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        IPizzaBuilder chefBuilder = new ChefPizzaBuilder();
//        Director director = new Director(chefBuilder);
//        Pizza pizza = director.ConstructPizza();
//        Console.WriteLine("Pizza: " + pizza);

//        IPizzaBuilder souchefBuilder = new SouchefPizzaBuilder();
//        director.SetPizzaBuilder(souchefBuilder);
//        Pizza veganPizza = director.ConstructVeganPizza();
//        Console.WriteLine("Vegan Pizza: " + veganPizza);
//    }
//}

