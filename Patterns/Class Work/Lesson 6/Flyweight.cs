//partial class Programm
//{
//    static void Main()
//    {
//        var flowers = new List<Flower>();
//        var FlyweightFactory = new FlyweightFactory();
//        var list = new List<Point>();
//        list.Add(new Point(1, 1));

//        var flowerModel = FlyweightFactory.GetFlowerModel(list);

//        var flower = new Flower(1, 10, flowerModel);
//        flower.Display();
//        flowers.Add(flower);

//        var flowerModel1 = FlyweightFactory.GetFlowerModel(list);
//        var flower1 = new Flower(1, 10, flowerModel);
//        flower1.Display();

//        flowers.Add(flower1);

//        flowers.RemoveAt(0);
//        flowers.RemoveAt(1);
//        FlyweightFactory.RemoveFlowerModel(list);

//    }

//}
//public class Point
//{
//    public int x { get; set; }
//    public int y { get; set; }
//    public Point(int x, int y)
//    {
//        this.x = x; this.y = y;
//    }
//}
//public class FlowerModel
//{
//    private List<Point> _points;
//    public FlowerModel(List<Point> _points)
//    {
//        _points = new();
//    }

//    public void Render(int x, int y)
//    {

//    }

//}

//public class StoneModel
//{
//    private List<Point> _points;
//    public StoneModel(List<Point> _points)
//    {
//        _points = new();
//    }

//    public void Render(int x, int y)
//    {

//    }

//}

//public class Flower
//{
//    private int _x;
//    private int _y;

//    private FlowerModel _flowerModel;

//    public Flower(int x, int y, FlowerModel flowerModel)
//    {
//        _x = x; _y = y; _flowerModel = flowerModel;
//    }

//    public void Display()
//    {
//        _flowerModel.Render(_x, _y);
//    }
//}

//public class Stone
//{
//    private int _x;
//    private int _y;

//    private StoneModel _stoneModel;

//    public Stone(int x, int y, StoneModel stoneModel)
//    {
//        _x = x; _y = y; _stoneModel = stoneModel;
//    }

//    public void Display()
//    {
//        _stoneModel.Render(_x, _y);
//    }
//}

//public class FlyweightFactory
//{
//    private Dictionary<List<Point>, FlowerModel> flowersModel = new Dictionary<List<Point>, FlowerModel>();
//    private Dictionary<List<Point>, StoneModel> stoneModel = new Dictionary<List<Point>, StoneModel>();

//    public FlowerModel GetFlowerModel(List<Point> points)
//    {
//        if (!flowersModel.ContainsKey(points))
//        {
//            flowersModel[points] = new FlowerModel(points);
//        }
//        return flowersModel[points];
//    }

//    public FlowerModel RemoveFlowerModel(List<Point> points)
//    {
//        flowersModel.Remove(points);
//        return flowersModel[points];
//    }
//    public StoneModel GetStoneModell(List<Point> points)
//    {
//        if (!stoneModel.ContainsKey(points))
//        {
//            stoneModel[points] = new StoneModel(points);
//        }
//        return stoneModel[points];
//    }
//}
