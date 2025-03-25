
//class Programm
//{
//    static void Main()
//    {
//        HomeFacade homeFacade = new HomeFacade();
//        homeFacade.ActivateHome();
//        Console.WriteLine(new string('-', 20));

//        homeFacade.DeactivateHome();

//    }
//}

//class LightingSystem
//{
//    public void TurnOnLights()
//    {
//        Console.WriteLine("Включаем свет");
//    }

//    public void TurnOffLights()
//    {
//        Console.WriteLine("Выключаем свет");
//    }
//}
//class HeatingSystem
//{
//    public void TurnOnHeating()
//    {
//        Console.WriteLine("Включаем отопление");
//    }
//    public void TurnOffHeating()
//    {
//        Console.WriteLine("Выключаем отопление");
//    }
//}

//class SecuritySystem
//{
//    public void Activate()
//    {
//        Console.WriteLine("Включаем систему безопасности");
//    }
//    public void Deactivate()
//    {
//        Console.WriteLine("Выключаем систему безопасности");
//    }

//}
//class HomeFacade
//{
//    private LightingSystem lightingSystem;
//    private HeatingSystem heatingSystem;
//    private SecuritySystem securitySystem;

//    public HomeFacade()
//    {
//        lightingSystem = new LightingSystem();
//        heatingSystem = new HeatingSystem();
//        securitySystem = new SecuritySystem();
//    }

//    public void ActivateHome()
//    {
//        Console.WriteLine("Алиса, Я дома");
//        lightingSystem.TurnOnLights();
//        heatingSystem.TurnOnHeating();
//        securitySystem.Deactivate();
//    }

//    public void DeactivateHome()
//    {
//        Console.WriteLine("Алиса, Я уезжаю из дома");
//        lightingSystem.TurnOffLights();
//        heatingSystem.TurnOffHeating();
//        securitySystem.Activate();
//    }
//}