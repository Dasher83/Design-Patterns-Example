namespace ChainOfResponsibility.Interfaces
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler next);
        object Handle(object request);
    }
}
