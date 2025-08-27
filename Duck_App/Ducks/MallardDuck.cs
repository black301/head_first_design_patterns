namespace duck_app.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        DuckType = "Mallard";
        flyBehavior = new FlyWithWings();
        quackBehavior = new NormalQuack();
    }
}