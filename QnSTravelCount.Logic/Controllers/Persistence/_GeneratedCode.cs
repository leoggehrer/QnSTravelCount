namespace QnSTravelCount.Logic.Controllers.Persistence.App
{
	sealed partial class ExpenseController : GenericController<QnSTravelCount.Contracts.Persistence.App.IExpense, Entities.Persistence.App.Expense>
	{
		static ExpenseController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public ExpenseController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public ExpenseController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSTravelCount.Logic.Controllers.Persistence.App
{
	sealed partial class TravelController : GenericController<QnSTravelCount.Contracts.Persistence.App.ITravel, Entities.Persistence.App.Travel>
	{
		static TravelController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public TravelController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public TravelController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSTravelCount.Logic.Controllers.Persistence.Account
{
	sealed partial class ApplicationController : GenericController<QnSTravelCount.Contracts.Persistence.Account.IApplication, Entities.Persistence.Account.Application>
	{
		static ApplicationController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public ApplicationController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public ApplicationController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSTravelCount.Logic.Controllers.Persistence.Account
{
	sealed partial class UserController : GenericController<QnSTravelCount.Contracts.Persistence.Account.IUser, Entities.Persistence.Account.User>
	{
		static UserController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public UserController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public UserController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
