using Visitor.Interfaces;


namespace Visitor.BusinessEntities
{
    internal static class Client
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach(IComponent component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
