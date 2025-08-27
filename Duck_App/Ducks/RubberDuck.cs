namespace duck_app.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        DuckType = "Rubber";
        flyBehavior = new FlyNoWay();
        quackBehavior = new Squeak();
    }
}