namespace ChainOfResponsibility.BusinessEntities
{
    internal class SquirrelHandler: AbstractHandler
    {
        public override object? Handle(object request)
        {
            if(request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request}.";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
