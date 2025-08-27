namespace duck_app.Ducks;

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        DuckType = "Redhead";
        flyBehavior = new FlyWithWings();
        quackBehavior = new NormalQuack();
    }
}