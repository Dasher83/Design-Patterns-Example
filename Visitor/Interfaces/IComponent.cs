namespace Visitor.Interfaces
{
    internal interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
