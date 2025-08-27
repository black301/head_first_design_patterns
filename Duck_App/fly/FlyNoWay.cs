namespace duck_app;

public class FlyNoWay : IFlyBehavior
{
    public string Fly()
    {
        return "duck is not Flying Today";
    }
}