internal interface INotificationSender
{
    void Send(string message);
    void Accept(IVisitor visitor);
}