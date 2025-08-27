namespace duck_app;

public class MuteQuack : IQuackBehavior
{
    public string Quack()
    {
        return "MuteQuack";
    }
}