namespace duck_app;

public class Duck
{
    // reference of the interface
    public IFlyBehavior flyBehavior;
    public IQuackBehavior quackBehavior;

    public string DuckType { get; set; }
    
    public string Swim()
    {
        return "I can swim";
    }
    public string Display()
    {
        return $"I am {DuckType}";
    }

    public void setFlyBehavior(IFlyBehavior newflyBehavior)
    {
        flyBehavior = newflyBehavior;
    }

    public void setQuackBehavior(IQuackBehavior newquackBehavior)
    {
        quackBehavior = newquackBehavior;
    }

    public string performQuack()
    {
        return quackBehavior.Quack();
    }

    public  string performFly()
    {
        return flyBehavior.Fly();
    }
}