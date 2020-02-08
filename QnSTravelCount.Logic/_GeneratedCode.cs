namespace QnSTravelCount.Logic
{
	public static partial class Factory
	{
		public static Contracts.Client.IControllerAccess<I> Create<I>() where I : Contracts.IIdentifiable
		{
			Contracts.Client.IControllerAccess<I> result = null;
			if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.App.IExpense))
			{
				result = new Controllers.Persistence.App.ExpenseController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.App.ITravel))
			{
				result = new Controllers.Persistence.App.TravelController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.Account.IApplication))
			{
				result = new Controllers.Persistence.Account.ApplicationController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.Account.IUser))
			{
				result = new Controllers.Persistence.Account.UserController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Business.App.ITravelExpenses))
			{
				result = new Controllers.Business.App.TravelExpensesController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			return result;
		}
		public static Contracts.Client.IControllerAccess<I> Create<I>(object sharedController) where I : Contracts.IIdentifiable
		{
			Contracts.Client.IControllerAccess<I> result = null;
			if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.App.IExpense))
			{
				result = new Controllers.Persistence.App.ExpenseController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.App.ITravel))
			{
				result = new Controllers.Persistence.App.TravelController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.Account.IApplication))
			{
				result = new Controllers.Persistence.Account.ApplicationController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.Account.IUser))
			{
				result = new Controllers.Persistence.Account.UserController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSTravelCount.Contracts.Business.App.ITravelExpenses))
			{
				result = new Controllers.Business.App.TravelExpensesController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			return result;
		}
	}
}
