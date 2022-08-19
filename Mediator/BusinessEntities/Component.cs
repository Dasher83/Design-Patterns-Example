using Mediator.Interfaces;

namespace Mediator.BusinessEntities
{
    internal abstract class Component : IMediated
    {
        protected IMediator? _mediator;

        public Component(IMediator? mediator = null)
        {
            _mediator = mediator;
        }

        public IMediator? Mediator {
            get => _mediator;
            set => _mediator = value; 
        }

        protected void RequireMediator()
        {
            if(_mediator == null)
            {
                throw new NullReferenceException(nameof(_mediator));
            }
        }
    }
}
