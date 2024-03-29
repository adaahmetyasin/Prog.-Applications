internal interface IVisitor
{
    void Visit(INotificationSender notificationSender);
}

internal class EmailVisitor : IVisitor
{
    public void Visit(INotificationSender notificationSender)
    {
        Console.WriteLine("Setup email");
    }
}

internal class TextVisitor : IVisitor
{
    public void Visit(INotificationSender notificationSender)
    {
        Console.WriteLine("Setup text");
    }
}

internal class WebVisitor : IVisitor
{
    public void Visit(INotificationSender notificationSender)
    {
        Console.WriteLine("Setup web");
    }
}