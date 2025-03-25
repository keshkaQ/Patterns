///*Создайте абстрактную фабрику для создания семейства объектов графического 
//интерфейса (например, кнопок и текстовых полей) для различных операционных систем 
//(например, Windows, macOS).*/

//class Program
//{
//    static void Main()
//    {
//        // Создаем фабрику для Windows
//        Factory windowsFactory = new WindowsFactory();
//        // Создаем кнопку и текстовое поле для Windows
//        Button windowsButton = windowsFactory.CreateButton();
//        TextField windowsTextField = windowsFactory.CreateTextField();

//        // Вызываем методы для кнопки и текстового поля Windows
//        windowsButton.Click();
//        windowsTextField.SomeText();

//        // Создаем фабрику для macOS
//        Factory macOSFactory = new macOSFactory();
//        // Создаем кнопку и текстовое поле для macOS
//        Button macOSButton = macOSFactory.CreateButton();
//        TextField macOsTextField = macOSFactory.CreateTextField();

//        // Вызываем методы для кнопки и текстового поля macOS
//        macOSButton.Click();
//        macOsTextField.SomeText();
//    }
//}

//// Абстрактный класс для кнопки
//abstract class Button
//{
//    public abstract void Click(); // Абстрактный метод для обработки клика
//}

//// Абстрактный класс для текстового поля
//abstract class TextField
//{
//    public abstract void SomeText(); // Абстрактный метод для обработки текста
//}

//// Реализация кнопки для Windows
//class WindowsButton : Button
//{
//    public override void Click()
//    {
//        Console.WriteLine("Click Windows Button"); // Логика клика для кнопки Windows
//    }
//}

//// Реализация кнопки для macOS
//class macOSButton : Button
//{
//    public override void Click()
//    {
//        Console.WriteLine("Click MacOS Button"); // Логика клика для кнопки macOS
//    }
//}

//// Реализация текстового поля для Windows
//class WindowsTextField : TextField
//{
//    public override void SomeText()
//    {
//        Console.WriteLine("Windows Text Field"); // Логика для текстового поля Windows
//    }
//}

//// Реализация текстового поля для macOS
//class macOSTextField : TextField
//{
//    public override void SomeText()
//    {
//        Console.WriteLine("MacOS Text Field"); // Логика для текстового поля macOS
//    }
//}

//// Абстрактная фабрика
//abstract class Factory
//{
//    public abstract Button CreateButton(); // Метод для создания кнопки
//    public abstract TextField CreateTextField(); // Метод для создания текстового поля
//}

//// Фабрика для создания элементов интерфейса Windows
//class WindowsFactory : Factory
//{
//    public override Button CreateButton()
//    {
//        return new WindowsButton(); // Создание кнопки Windows
//    }

//    public override TextField CreateTextField()
//    {
//        return new WindowsTextField(); // Создание текстового поля Windows
//    }
//}

//// Фабрика для создания элементов интерфейса macOS
//class macOSFactory : Factory
//{
//    public override Button CreateButton()
//    {
//        return new macOSButton(); // Создание кнопки macOS
//    }

//    public override TextField CreateTextField()
//    {
//        return new macOSTextField(); // Создание текстового поля macOS
//    }
//}

