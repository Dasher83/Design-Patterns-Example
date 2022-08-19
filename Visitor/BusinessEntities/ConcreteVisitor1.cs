using Visitor.Interfaces;
using Visitor.Utils;


namespace Visitor.BusinessEntities
{
    internal class ConcreteVisitor1 : IVisitor
    {
        private readonly ConsoleColor _color;

        public ConcreteVisitor1()
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            ColorConsole.WriteLine(
                $"{element.ExclusiveMethodOfConcreteComponentA()} + ConcreteVisitor1", _color);
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            ColorConsole.WriteLine(
                $"{element.SpecialMethodOfConcreteComponentB()} + ConcreteVisitor1", _color);
        }
    }
}
