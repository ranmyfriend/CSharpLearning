namespace GenericViewWithVM.DynamicView;

public interface IInstance
{
    public string Name => "";
}

public class Apple : IInstance
{
    public string Name => "Apple";
}
public class Orange : IInstance
{
    public string Name => "Orange";
}
public class PineApple : IInstance
{
    public string Name => "PineApple";
}

public class Sharmila: IInstance
{
    public string Name => "Sharmi";
}