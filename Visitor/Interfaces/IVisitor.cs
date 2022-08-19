using Visitor.BusinessEntities;


namespace Visitor.Interfaces
{
    internal interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);
        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}
