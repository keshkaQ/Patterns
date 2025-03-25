//class Programm
//{
//    static void Main()
//    {
//        var factory = new FlyweightFactory();

//        // Создаем легковесы для форматирования текста
//        var format1 = factory.GetTextFormat("Arial", 12, "Black");
//        var format2 = factory.GetTextFormat("Times New Roman", 14, "Red");
//        var format3 = factory.GetTextFormat("Times New Roman", 14, "Red");

//        // Создаем символы с различным форматированием
//        var characterA = new Character('A', format1);
//        var characterB = new Character('B', format2);
//        var characterC = new Character('C', format1);

//        // Выводим информацию о символах и их форматировании
//        characterA.Display();
//        characterB.Display();
//        characterC.Display();
//    }
//}

//// Класс Character представляет символ в текстовом редакторе
//public class Character
//{
//    private char _symbol; // Символ
//    private TextFormatFlyweight _format; // Ссылка на легковес форматирования

//    // Конструктор для инициализации символа и его форматирования
//    public Character(char symbol, TextFormatFlyweight format)
//    {
//        _symbol = symbol;
//        _format = format;
//    }

//    // Метод для отображения символа и его форматирования
//    public void Display()
//    {
//        Console.WriteLine($"Symbol: {_symbol}, Format: {_format.GetFormat()}");
//    }
//}

//// Класс TextFormatFlyweight представляет легковес форматирования
//public class TextFormatFlyweight
//{
//    private string _font; // Шрифт
//    private int _size; // Размер
//    private string _color; // Цвет

//    // Конструктор для инициализации форматирования
//    public TextFormatFlyweight(string font, int size, string color)
//    {
//        _font = font;
//        _size = size;
//        _color = color;
//    }

//    // Метод для получения строки форматирования
//    public string GetFormat()
//    {
//        return $"Font: {_font}, Size: {_size}, Color: {_color}";
//    }
//}

//// Класс FlyweightFactory управляет созданием и повторным использованием легковесов форматирования
//public class FlyweightFactory
//{
//    private Dictionary<string, TextFormatFlyweight> _formats = new Dictionary<string, TextFormatFlyweight>();

//    // Метод для получения или создания легковеса форматирования
//    public TextFormatFlyweight GetTextFormat(string font, int size, string color)
//    {
//        // Создаем уникальный ключ для форматирования
//        string key = $"{font}-{size}-{color}";

//        // Если легковес форматирования не существует, создаем новый
//        if (!_formats.ContainsKey(key))
//        {
//            _formats[key] = new TextFormatFlyweight(font, size, color);
//        }

//        // Возвращаем существующий или новый легковес форматирования
//        return _formats[key];
//    }
//}