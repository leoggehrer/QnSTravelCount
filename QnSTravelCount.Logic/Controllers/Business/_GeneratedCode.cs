namespace QnSTravelCount.Logic.Controllers.Business.App
{
	sealed partial class TravelExpensesController : ControllerObject, Contracts.Client.IControllerAccess<QnSTravelCount.Contracts.Business.App.ITravelExpenses>
	{
		static TravelExpensesController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public TravelExpensesController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public TravelExpensesController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
