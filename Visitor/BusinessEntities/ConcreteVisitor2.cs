using Visitor.Interfaces;
using Visitor.Utils;


namespace Visitor.BusinessEntities
{
    internal class ConcreteVisitor2 : IVisitor
    {
        private readonly ConsoleColor _color;

        public ConcreteVisitor2()
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            ColorConsole.WriteLine(
                $"{element.ExclusiveMethodOfConcreteComponentA()} + ConcreteVisitor2", _color);
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            ColorConsole.WriteLine(
                $"{element.SpecialMethodOfConcreteComponentB()} + ConcreteVisitor2", _color);
        }
    }
}
