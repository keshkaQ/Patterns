//partial class Programm
//{
//    static void Main()
//    {
//        var render2D = new Render2D();
//        var grass = new Grass(render2D);

//        grass.Draw();
//        grass.render = new Render3D();
//        grass.Draw();

//    }
//}

//public abstract class GameObject
//{
//    public IRender render { get; set; }
//    protected GameObject(IRender render)
//    { 
//    }
//    public abstract void Draw();
//}
//public class Grass : GameObject
//{
//    public Grass(IRender render) : base(render)
//    {
//    }

//    public override void Draw()
//    {
//        //...
//    }
//}

//public class Stone : GameObject
//{
//    public Stone(IRender render) : base(render)
//    {
//    }
//    public override void Draw()
//    {
//        //...
//    }
//}

//public interface IRender
//{
//    void Render();
//}

//public class Render2D : IRender
//{
//    public void Render()
//    {
//       //...
//    }
//}

//public class Render3D : IRender
//{
//    public void Render()
//    {
//        //...
//    }
//}

