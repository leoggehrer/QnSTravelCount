namespace QnSTravelCount.Transfer.Business.App
{
	using System.Text.Json.Serialization;
	public partial class TravelExpenses : QnSTravelCount.Contracts.Business.App.ITravelExpenses
	{
		static TravelExpenses()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public TravelExpenses()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		[JsonIgnore]
		public QnSTravelCount.Contracts.Persistence.App.ITravel Travel
		{
			get
			{
				OnTravelReading();
				return _travel;
			}
			set
			{
				bool handled = false;
				OnTravelChanging(ref handled, ref _travel);
				if (handled == false)
				{
					this._travel = value;
				}
				OnTravelChanged();
			}
		}
		private QnSTravelCount.Contracts.Persistence.App.ITravel _travel;
		partial void OnTravelReading();
		partial void OnTravelChanging(ref bool handled, ref QnSTravelCount.Contracts.Persistence.App.ITravel _travel);
		partial void OnTravelChanged();
		[JsonIgnore]
		public System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Persistence.App.IExpense> Expenses
		{
			get
			{
				OnExpensesReading();
				return _expenses;
			}
			set
			{
				bool handled = false;
				OnExpensesChanging(ref handled, ref _expenses);
				if (handled == false)
				{
					this._expenses = value;
				}
				OnExpensesChanged();
			}
		}
		private System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Persistence.App.IExpense> _expenses;
		partial void OnExpensesReading();
		partial void OnExpensesChanging(ref bool handled, ref System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Persistence.App.IExpense> _expenses);
		partial void OnExpensesChanged();
		public System.Double TotalExpense
		{
			get
			{
				OnTotalExpenseReading();
				return _totalExpense;
			}
			set
			{
				bool handled = false;
				OnTotalExpenseChanging(ref handled, ref _totalExpense);
				if (handled == false)
				{
					this._totalExpense = value;
				}
				OnTotalExpenseChanged();
			}
		}
		private System.Double _totalExpense;
		partial void OnTotalExpenseReading();
		partial void OnTotalExpenseChanging(ref bool handled, ref System.Double _totalExpense);
		partial void OnTotalExpenseChanged();
		public System.Double FriendPortion
		{
			get
			{
				OnFriendPortionReading();
				return _friendPortion;
			}
			set
			{
				bool handled = false;
				OnFriendPortionChanging(ref handled, ref _friendPortion);
				if (handled == false)
				{
					this._friendPortion = value;
				}
				OnFriendPortionChanged();
			}
		}
		private System.Double _friendPortion;
		partial void OnFriendPortionReading();
		partial void OnFriendPortionChanging(ref bool handled, ref System.Double _friendPortion);
		partial void OnFriendPortionChanged();
		public System.Int32 NumberOfFriends
		{
			get
			{
				OnNumberOfFriendsReading();
				return _numberOfFriends;
			}
			set
			{
				bool handled = false;
				OnNumberOfFriendsChanging(ref handled, ref _numberOfFriends);
				if (handled == false)
				{
					this._numberOfFriends = value;
				}
				OnNumberOfFriendsChanged();
			}
		}
		private System.Int32 _numberOfFriends;
		partial void OnNumberOfFriendsReading();
		partial void OnNumberOfFriendsChanging(ref bool handled, ref System.Int32 _numberOfFriends);
		partial void OnNumberOfFriendsChanged();
		public System.String[] Friends
		{
			get
			{
				OnFriendsReading();
				return _friends;
			}
			set
			{
				bool handled = false;
				OnFriendsChanging(ref handled, ref _friends);
				if (handled == false)
				{
					this._friends = value;
				}
				OnFriendsChanged();
			}
		}
		private System.String[] _friends;
		partial void OnFriendsReading();
		partial void OnFriendsChanging(ref bool handled, ref System.String[] _friends);
		partial void OnFriendsChanged();
		public System.Double[] FriendAmounts
		{
			get
			{
				OnFriendAmountsReading();
				return _friendAmounts;
			}
			set
			{
				bool handled = false;
				OnFriendAmountsChanging(ref handled, ref _friendAmounts);
				if (handled == false)
				{
					this._friendAmounts = value;
				}
				OnFriendAmountsChanged();
			}
		}
		private System.Double[] _friendAmounts;
		partial void OnFriendAmountsReading();
		partial void OnFriendAmountsChanging(ref bool handled, ref System.Double[] _friendAmounts);
		partial void OnFriendAmountsChanged();
		public System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Modules.TravelExpense.IBalance> Balances
		{
			get
			{
				OnBalancesReading();
				return _balances;
			}
			set
			{
				bool handled = false;
				OnBalancesChanging(ref handled, ref _balances);
				if (handled == false)
				{
					this._balances = value;
				}
				OnBalancesChanged();
			}
		}
		private System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Modules.TravelExpense.IBalance> _balances;
		partial void OnBalancesReading();
		partial void OnBalancesChanging(ref bool handled, ref System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Modules.TravelExpense.IBalance> _balances);
		partial void OnBalancesChanged();
		public void CopyProperties(QnSTravelCount.Contracts.Business.App.ITravelExpenses other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				Travel = other.Travel;
				Expenses = other.Expenses;
				TotalExpense = other.TotalExpense;
				FriendPortion = other.FriendPortion;
				NumberOfFriends = other.NumberOfFriends;
				Friends = other.Friends;
				FriendAmounts = other.FriendAmounts;
				Balances = other.Balances;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSTravelCount.Contracts.Business.App.ITravelExpenses other, ref bool handled);
		partial void AfterCopyProperties(QnSTravelCount.Contracts.Business.App.ITravelExpenses other);
	}
}
namespace QnSTravelCount.Transfer.Business.App
{
	partial class TravelExpenses : TransferObject
	{
	}
}
