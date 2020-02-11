namespace QnSTravelCount.Adapters
{
	public static partial class Factory
	{
		public static Contracts.Client.IAdapterAccess<I> Create<I>() where I : Contracts.IIdentifiable
		{
			Contracts.Client.IAdapterAccess<I> result = null;
			if (Adapter == AdapterType.Controller)
			{
				if (typeof(I) == typeof(QnSTravelCount.Contracts.Business.App.ITravelExpenses))
				{
					result = new Controller.GenericControllerAdapter<QnSTravelCount.Contracts.Business.App.ITravelExpenses>() as Contracts.Client.IAdapterAccess<I>;
				}
			}
			else if (Adapter == AdapterType.Service)
			{
				if (typeof(I) == typeof(QnSTravelCount.Contracts.Business.App.ITravelExpenses))
				{
					result = new Service.GenericServiceAdapter<QnSTravelCount.Contracts.Business.App.ITravelExpenses, Transfer.Business.App.TravelExpenses>(BaseUri, "TravelExpenses") as Contracts.Client.IAdapterAccess<I>;
				}
			}
			return result;
		}
	}
}
