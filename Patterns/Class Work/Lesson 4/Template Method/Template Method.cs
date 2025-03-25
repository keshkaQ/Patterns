
//public abstract class Dbcontext
//{
//    protected Dbcontext()
//    {
//        onconfiguring();
//        onmodecreating();
//    }
//    public abstract void onconfiguring(); // настраивает подключение к базе данных
//    public abstract void onmodecreating(); // настраивает таблицы, которые имеются в базе данных

//}
//// БД, взаимодействующий с продуктами
//class Productdbcontext : Dbcontext
//{
//    public Productdbcontext() : base()
//    {
        
//    }
//    // Переопределение методы
//    public override void onconfiguring()
//    {
//        //.. подключение к базе данных
//    }
//    public override void onmodecreating()
//    {
//        //.. настраиваем таблицы, с которыми мы взаимодействуем
//    }
//}
//// БД, который ведет учет пользователей
//class UserDbcontext : Dbcontext
//{
//    public UserDbcontext() : base()
//    {

//    }
//    public override void onconfiguring()
//    {
//        ///...
//    }

//    public override void onmodecreating()
//    {
//        ///...
//    }
//}