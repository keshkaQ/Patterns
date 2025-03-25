
//internal class Programm
//{
//    static void Main()
//    {
//        // Создаем экземпляры компонентов
//        var settingPanel = new SettingPanel();
//        var colorPanel = new ColorPanel();
//        var symbol1 = new Symbol1();
//        var symbolMenu = new SymbolMenu();
//        var topPanel = new TopPanel();

//        // Добавляем панели в верхнюю панель
//        topPanel.Add(settingPanel);
//        topPanel.Add(colorPanel);

//        // Добавляем символ в меню символов
//        symbolMenu.Add(symbol1);

//        // Создаем экземпляр окна и добавляем в него панели
//        var window = new Window();
//        window.Add(topPanel);
//        window.Add(symbolMenu);

//        // Отображаем окно
//        window.Display();
//    }
//}

//// Абстрактный класс компонента с базовыми методами
//public abstract class Component
//{
//    // Абстрактный метод для отображения компонента
//    public abstract void Display();

//    // Абстрактный метод для добавления компонента
//    public abstract void Add(Component component);

//    // Абстрактный метод для удаления компонента
//    public abstract void Remove(Component component);
//}

//// Класс окна, который наследует от компонента
//public class Window : Component
//{
//    // Список компонентов в окне
//    private List<Component> components;

//    // Конструктор для инициализации списка компонентов
//    public Window()
//    {
//        components = new List<Component>();
//    }

//    // Метод для добавления компонента в окно
//    public override void Add(Component component)
//    {
//        components.Add(component);
//    }

//    // Метод для отображения всех компонентов в окне
//    public override void Display()
//    {
//        foreach (var component in components)
//        {
//            component.Display();
//        }
//    }

//    // Метод для удаления компонента из окна
//    public override void Remove(Component component)
//    {
//        components.Remove(component);
//    }
//}

//// Класс меню символов, который наследует от компонента
//public class SymbolMenu : Component
//{
//    // Список компонентов в меню символов
//    private List<Component> components;

//    // Конструктор для инициализации списка компонентов
//    public SymbolMenu()
//    {
//        components = new List<Component>();
//    }

//    // Метод для добавления компонента в меню символов
//    public override void Add(Component component)
//    {
//        components.Add(component);
//    }

//    // Метод для отображения всех компонентов в меню символов
//    public override void Display()
//    {
//        foreach (var component in components)
//        {
//            component.Display();
//        }
//    }

//    // Метод для удаления компонента из меню символов
//    public override void Remove(Component component)
//    {
//        components.Remove(component);
//    }
//}

//// Класс верхней панели, который наследует от компонента
//public class TopPanel : Component
//{
//    // Список компонентов в верхней панели
//    private List<Component> components;

//    // Конструктор для инициализации списка компонентов
//    public TopPanel()
//    {
//        components = new List<Component>();
//    }

//    // Метод для добавления компонента в верхнюю панель
//    public override void Add(Component component)
//    {
//        components.Add(component);
//    }

//    // Метод для отображения всех компонентов в верхней панели
//    public override void Display()
//    {
//        foreach (var component in components)
//        {
//            component.Display();
//        }
//    }

//    // Метод для удаления компонента из верхней панели
//    public override void Remove(Component component)
//    {
//        components.Remove(component);
//    }
//}

//// Класс панели цветов, который наследует от компонента
//public class ColorPanel : Component
//{
//    // Список компонентов в панели цветов
//    private List<Component> components;

//    // Конструктор для инициализации списка компонентов
//    public ColorPanel()
//    {
//        components = new List<Component>();
//    }

//    // Метод для добавления компонента в панель цветов
//    public override void Add(Component component)
//    {
//        components.Add(component);
//    }

//    // Метод для отображения всех компонентов в панели цветов
//    public override void Display()
//    {
//        foreach (var component in components)
//        {
//            component.Display();
//        }
//    }

//    // Метод для удаления компонента из панели цветов
//    public override void Remove(Component component)
//    {
//        components.Remove(component);
//    }
//}

//// Класс панели настроек, который наследует от компонента
//public class SettingPanel : Component
//{
//    // Список компонентов в панели настроек
//    private List<Component> components;

//    // Конструктор для инициализации списка компонентов
//    public SettingPanel()
//    {
//        components = new List<Component>();
//    }

//    // Метод для добавления компонента в панель настроек
//    public override void Add(Component component)
//    {
//        components.Add(component);
//    }

//    // Метод для отображения всех компонентов в панели настроек
//    public override void Display()
//    {
//        foreach (var component in components)
//        {
//            component.Display();
//        }
//    }

//    // Метод для удаления компонента из панели настроек
//    public override void Remove(Component component)
//    {
//        components.Remove(component);
//    }
//}

//// Класс символа, который наследует от компонента
//public class Symbol1 : Component
//{
//    // Список компонентов в символе
//    private List<Component> components;

//    // Конструктор для инициализации списка компонентов
//    public Symbol1()
//    {
//        components = new List<Component>();
//    }

//    // Метод для добавления компонента в символ
//    public override void Add(Component component)
//    {
//        components.Add(component);
//    }

//    // Метод для отображения всех компонентов в символе
//    public override void Display()
//    {
//        foreach (var component in components)
//        {
//            component.Display();
//        }
//    }

//    // Метод для удаления компонента из символа
//    public override void Remove(Component component)
//    {
//        components.Remove(component);
//    }
//}
