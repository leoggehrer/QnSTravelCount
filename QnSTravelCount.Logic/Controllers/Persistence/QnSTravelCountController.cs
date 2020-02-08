//MdStart
using QnSTravelCount.Logic.DataContext;

namespace QnSTravelCount.Logic.Controllers.Persistence
{
    internal abstract partial class QnSTravelCountController<I, E> : GenericController<I, E>
       where I : Contracts.IIdentifiable
       where E : Entities.IdentityObject, I, Contracts.ICopyable<I>, new()
    {
        internal IQnSTravelCountContext QnSTravelCountContext => (IQnSTravelCountContext)Context;

        protected QnSTravelCountController(IContext context)
            : base(context)
        {
        }
        protected QnSTravelCountController(ControllerObject controller)
            : base(controller)
        {
        }
    }
}
//MdEnd
