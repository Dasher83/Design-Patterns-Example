namespace Memento.Interfaces
{
    internal interface IMemento
    {
        string Name { get; }
        string State { get; }
        DateTime Date { get; }
    }
}
