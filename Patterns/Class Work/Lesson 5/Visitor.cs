//using System;
//using System.Collections.Generic;

//internal class Program
//{
//    static void Main()
//    {
//        // Создаем экземпляр банка
//        var bank = new Bank();

//        // Создаем экземпляр клиента-физического лица
//        var person = new Person();
//        person.FIO = "Ivanov Ivan";
//        person.AccNumber = "1555";

//        // Создаем экземпляр клиента-компании
//        var company = new Company();
//        company.RegNumber = "3";
//        company.Title = "OOO COMPANY";

//        // Добавляем клиентов в банк
//        bank.Add(person);
//        bank.Add(company);

//        // Создаем экземпляр HTML-визитора
//        var htmlVisitor = new HTMLVisitor();

//        // Сохраняем данные клиентов в базу данных с использованием HTML-визитора
//        bank.SaveDataBase(htmlVisitor);
//    }
//}

//// Интерфейс для клиентов банка
//public interface IClient
//{
//    // Метод для принятия визитора
//    string Accept(IVisitor visitor);
//}

//// Класс для физического лица
//public class Person : IClient
//{
//    // ФИО клиента
//    public string FIO { get; set; }
//    // Номер счета клиента
//    public string AccNumber { get; set; }

//    // Метод для принятия визитора
//    public string Accept(IVisitor visitor)
//    {
//        // Сериализуем объект Person с помощью визитора
//        return visitor.Serialize(this);
//    }
//}

//// Класс для компании
//public class Company : IClient
//{
//    // Название компании
//    public string Title { get; set; }
//    // Регистрационный номер компании
//    public string RegNumber { get; set; }

//    // Метод для принятия визитора
//    public string Accept(IVisitor visitor)
//    {
//        // Сериализуем объект Company с помощью визитора
//        return visitor.Serialize(this);
//    }
//}

//// Класс для банка, который хранит список клиентов
//public class Bank
//{
//    // Список клиентов
//    private List<IClient> clients;

//    // Конструктор для инициализации списка клиентов
//    public Bank()
//    {
//        clients = new List<IClient>();
//    }

//    // Метод для добавления клиента в банк
//    public void Add(IClient client)
//    {
//        clients.Add(client);
//    }

//    // Метод для удаления клиента из банка
//    public void Remove(IClient client)
//    {
//        clients.Remove(client);
//    }

//    // Метод для сохранения данных клиентов в базу данных с использованием визитора
//    public void SaveDataBase(IVisitor visitor)
//    {
//        foreach (var client in clients)
//        {
//            // Сериализуем каждого клиента с помощью визитора
//            var serializedClient = client.Accept(visitor);
//            // Здесь можно добавить код для записи сериализованных данных в базу данных
//        }
//    }
//}

//// Интерфейс для визиторов
//public interface IVisitor
//{
//    // Метод для сериализации компании
//    string Serialize(Company company);
//    // Метод для сериализации физического лица
//    string Serialize(Person person);
//}

//// Класс для HTML-визитора
//public class HTMLVisitor : IVisitor
//{
//    // Метод для сериализации компании в HTML
//    public string Serialize(Company company)
//    {
//        // Возвращаем пустую строку, так как реализация сериализации не предоставлена
//        return string.Empty;
//    }

//    // Метод для сериализации физического лица в HTML
//    public string Serialize(Person person)
//    {
//        // Возвращаем пустую строку, так как реализация сериализации не предоставлена
//        return string.Empty;
//    }
//}

//// Класс для XML-визитора
//public class XMLVisitor : IVisitor
//{
//    // Метод для сериализации компании в XML
//    public string Serialize(Company company)
//    {
//        // Возвращаем пустую строку, так как реализация сериализации не предоставлена
//        return string.Empty;
//    }

//    // Метод для сериализации физического лица в XML
//    public string Serialize(Person person)
//    {
//        // Возвращаем пустую строку, так как реализация сериализации не предоставлена
//        return string.Empty;
//    }
//}

//// Класс для JSON-визитора
//public class JSONVisitor : IVisitor
//{
//    // Метод для сериализации компании в JSON
//    public string Serialize(Company company)
//    {
//        // Возвращаем пустую строку, так как реализация сериализации не предоставлена
//        return string.Empty;
//    }

//    // Метод для сериализации физического лица в JSON
//    public string Serialize(Person person)
//    {
//        // Возвращаем пустую строку, так как реализация сериализации не предоставлена
//        return string.Empty;
//    }
//}

//// Класс для бинарного визитора
//public class BinaryVisitor : IVisitor
//{
//    // Метод для сериализации компании в бинарный формат
//    public string Serialize(Company company)
//    {
//        // Возвращаем пустую строку, так как реализация сериализации не предоставлена
//        return string.Empty;
//    }

//    // Метод для сериализации физического лица в бинарный формат
//    public string Serialize(Person person)
//    {
//        // Возвращаем пустую строку, так как реализация сериализации не предоставлена
//        return string.Empty;
//    }
//}
