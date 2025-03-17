/*Создайте абстрактную фабрику для создания семейства объектов графического 
интерфейса (например, кнопок и текстовых полей) для различных операционных систем 
(например, Windows, macOS).*/

//abstract class Button
//{
//    public abstract void Click();
//}

//abstract class TextField
//{
//    public abstract void SomeText();
//}

//class WindowsButton : Button
//{
//    public override void Click()
//    {
//        Console.WriteLine("Click Windows Button");
//    }
//}

//class macOSButton : Button
//{
//    public override void Click()
//    {
//        Console.WriteLine("Click MacOS Button");
//    }
//}

//class WindowsTextField : TextField
//{
//    public override void SomeText()
//    {
//        Console.WriteLine("Windows Text Field");
//    }
//}

//class macOSTextField : TextField
//{
//    public override void SomeText()
//    {
//        Console.WriteLine("MacOS Text Field");
//    }
//}

//abstract class Factory
//{
//    public abstract Button CreateButton();
//    public abstract TextField CreateTextField();
//}

//class WindowsFactory : Factory
//{
//    public override Button CreateButton()
//    {
//        return new WindowsButton();
//    }

//    public override TextField CreateTextField()
//    {
//        return new WindowsTextField();
//    }
//}

//class macOSFactory : Factory
//{
//    public override Button CreateButton()
//    {
//        return new macOSButton();
//    }

//    public override TextField CreateTextField()
//    {
//        return new macOSTextField();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Factory windowsFactory = new WindowsFactory();
//        Button windowsButton = windowsFactory.CreateButton();
//        TextField windowsTextField = windowsFactory.CreateTextField();

//        windowsButton.Click();
//        windowsTextField.SomeText();

//        Factory macOSFactory = new macOSFactory();
//        Button macOSButton = macOSFactory.CreateButton();
//        TextField macOsTextField = macOSFactory.CreateTextField();

//        macOSButton.Click();
//        macOsTextField.SomeText();
//    }
//}


