namespace duck_app.Ducks;

public class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        DuckType = "Decoy";
        flyBehavior = new FlyNoWay();
        quackBehavior = new MuteQuack();
    }
}