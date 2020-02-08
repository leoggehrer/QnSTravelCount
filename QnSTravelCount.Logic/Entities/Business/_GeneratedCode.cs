namespace QnSTravelCount.Logic.Entities.Business.App
{
	using System;
	partial class TravelExpenses : QnSTravelCount.Contracts.Business.App.ITravelExpenses
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
		private QnSTravelCount.Contracts.Persistence.App.ITravel _travel;
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
		partial void OnTravelReading();
		partial void OnTravelChanging(ref bool handled, ref QnSTravelCount.Contracts.Persistence.App.ITravel _travel);
		partial void OnTravelChanged();
		private System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Persistence.App.IExpense> _expenses;
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
		partial void OnExpensesReading();
		partial void OnExpensesChanging(ref bool handled, ref System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Persistence.App.IExpense> _expenses);
		partial void OnExpensesChanged();
		private System.Int32 _id;
		public System.Int32 Id
		{
			get
			{
				OnIdReading();
				return _id;
			}
			set
			{
				bool handled = false;
				OnIdChanging(ref handled, ref _id);
				if (handled == false)
				{
					this._id = value;
				}
				OnIdChanged();
			}
		}
		partial void OnIdReading();
		partial void OnIdChanging(ref bool handled, ref System.Int32 _id);
		partial void OnIdChanged();
		private System.Double _totalExpense;
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
		partial void OnTotalExpenseReading();
		partial void OnTotalExpenseChanging(ref bool handled, ref System.Double _totalExpense);
		partial void OnTotalExpenseChanged();
		private System.Double _friendPortion;
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
		partial void OnFriendPortionReading();
		partial void OnFriendPortionChanging(ref bool handled, ref System.Double _friendPortion);
		partial void OnFriendPortionChanged();
		private System.Int32 _numberOfFriends;
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
		partial void OnNumberOfFriendsReading();
		partial void OnNumberOfFriendsChanging(ref bool handled, ref System.Int32 _numberOfFriends);
		partial void OnNumberOfFriendsChanged();
		private System.String[] _friends;
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
		partial void OnFriendsReading();
		partial void OnFriendsChanging(ref bool handled, ref System.String[] _friends);
		partial void OnFriendsChanged();
		private System.Double[] _friendAmounts;
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
		partial void OnFriendAmountsReading();
		partial void OnFriendAmountsChanging(ref bool handled, ref System.Double[] _friendAmounts);
		partial void OnFriendAmountsChanged();
		private System.Collections.Generic.IEnumerable<QnSTravelCount.Contracts.Modules.TravelExpense.IBalance> _balances;
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
				Id = other.Id;
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
		public override bool Equals(object obj)
		{
			if (!(obj is QnSTravelCount.Contracts.Business.App.ITravelExpenses instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSTravelCount.Contracts.Business.App.ITravelExpenses other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Travel, other.Travel) && IsEqualsWith(Expenses, other.Expenses) && Id == other.Id && TotalExpense == other.TotalExpense && FriendPortion == other.FriendPortion && NumberOfFriends == other.NumberOfFriends && IsEqualsWith(Friends, other.Friends) && IsEqualsWith(FriendAmounts, other.FriendAmounts) && IsEqualsWith(Balances, other.Balances);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Travel, Expenses, Id, TotalExpense, HashCode.Combine(FriendPortion, NumberOfFriends, Friends, FriendAmounts, Balances));
		}
	}
}
namespace QnSTravelCount.Logic.Entities.Business.App
{
	partial class TravelExpenses : IdentityObject
	{
	}
}
