namespace QnSTravelCount.Transfer.Modules.TravelExpense
{
	public partial class Balance : QnSTravelCount.Contracts.Modules.TravelExpense.IBalance
	{
		static Balance()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Balance()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		private System.String _from;
		public System.String From
		{
			get
			{
				OnFromReading();
				return _from;
			}
			set
			{
				bool handled = false;
				OnFromChanging(ref handled, ref _from);
				if (handled == false)
				{
					this._from = value;
				}
				OnFromChanged();
			}
		}
		partial void OnFromReading();
		partial void OnFromChanging(ref bool handled, ref System.String _from);
		partial void OnFromChanged();
		private System.String _to;
		public System.String To
		{
			get
			{
				OnToReading();
				return _to;
			}
			set
			{
				bool handled = false;
				OnToChanging(ref handled, ref _to);
				if (handled == false)
				{
					this._to = value;
				}
				OnToChanged();
			}
		}
		partial void OnToReading();
		partial void OnToChanging(ref bool handled, ref System.String _to);
		partial void OnToChanged();
		private System.Double _amount;
		public System.Double Amount
		{
			get
			{
				OnAmountReading();
				return _amount;
			}
			set
			{
				bool handled = false;
				OnAmountChanging(ref handled, ref _amount);
				if (handled == false)
				{
					this._amount = value;
				}
				OnAmountChanged();
			}
		}
		partial void OnAmountReading();
		partial void OnAmountChanging(ref bool handled, ref System.Double _amount);
		partial void OnAmountChanged();
		public void CopyProperties(QnSTravelCount.Contracts.Modules.TravelExpense.IBalance other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				From = other.From;
				To = other.To;
				Amount = other.Amount;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSTravelCount.Contracts.Modules.TravelExpense.IBalance other, ref bool handled);
		partial void AfterCopyProperties(QnSTravelCount.Contracts.Modules.TravelExpense.IBalance other);
	}
}
namespace QnSTravelCount.Transfer.Modules.TravelExpense
{
	partial class Balance : TransferObject
	{
	}
}
