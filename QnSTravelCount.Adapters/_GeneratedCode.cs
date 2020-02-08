namespace QnSTravelCount.Adapters
{
	public static partial class Factory
	{
		public static Contracts.Client.IAdapterAccess<I> Create<I>() where I : Contracts.IIdentifiable
		{
			Contracts.Client.IAdapterAccess<I> result = null;
			if (Adapter == AdapterType.Controller)
			{
				if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.Account.IApplication))
				{
					result = new Controller.GenericControllerAdapter<QnSTravelCount.Contracts.Persistence.Account.IApplication>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.Account.IUser))
				{
					result = new Controller.GenericControllerAdapter<QnSTravelCount.Contracts.Persistence.Account.IUser>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSTravelCount.Contracts.Business.App.ITravelExpenses))
				{
					result = new Controller.GenericControllerAdapter<QnSTravelCount.Contracts.Business.App.ITravelExpenses>() as Contracts.Client.IAdapterAccess<I>;
				}
			}
			else if (Adapter == AdapterType.Service)
			{
				if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.Account.IApplication))
				{
					result = new Service.GenericServiceAdapter<QnSTravelCount.Contracts.Persistence.Account.IApplication, Transfer.Persistence.Account.Application>(BaseUri, "Application") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSTravelCount.Contracts.Persistence.Account.IUser))
				{
					result = new Service.GenericServiceAdapter<QnSTravelCount.Contracts.Persistence.Account.IUser, Transfer.Persistence.Account.User>(BaseUri, "User") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSTravelCount.Contracts.Business.App.ITravelExpenses))
				{
					result = new Service.GenericServiceAdapter<QnSTravelCount.Contracts.Business.App.ITravelExpenses, Transfer.Business.App.TravelExpenses>(BaseUri, "TravelExpenses") as Contracts.Client.IAdapterAccess<I>;
				}
			}
			return result;
		}
	}
}
