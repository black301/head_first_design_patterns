using duck_app.Ducks;

namespace duck_app;

class Program
{
    static void Main(string[] args)
    {
       Duck MyDuck = new MallardDuck();
       Console.WriteLine(MyDuck.DuckType);
       Console.WriteLine("  "+MyDuck.performFly());
       MyDuck.setFlyBehavior(new RooketFly());
       Console.WriteLine("  after the change " + MyDuck.performFly());
       Console.WriteLine("  "+MyDuck.performQuack());
       MyDuck = new DecoyDuck();
       Console.WriteLine(MyDuck.DuckType);
       Console.WriteLine("  "+MyDuck.performFly());
       Console.WriteLine("  "+MyDuck.performQuack());
       MyDuck = new RubberDuck();
       Console.WriteLine(MyDuck.DuckType);
       Console.WriteLine("  "+MyDuck.performFly());
       Console.WriteLine("  "+MyDuck.performQuack());
       MyDuck = new RedheadDuck();
       Console.WriteLine(MyDuck.DuckType);
       Console.WriteLine("  "+MyDuck.performFly());
       Console.WriteLine("  "+MyDuck.performQuack());
    }
}