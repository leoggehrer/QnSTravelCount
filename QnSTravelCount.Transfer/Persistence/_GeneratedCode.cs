namespace QnSTravelCount.Transfer.Persistence.App
{
	using System.Text.Json.Serialization;
	public partial class Expense : QnSTravelCount.Contracts.Persistence.App.IExpense
	{
		static Expense()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Expense()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.Int32 TravelId
		{
			get
			{
				OnTravelIdReading();
				return _travelId;
			}
			set
			{
				bool handled = false;
				OnTravelIdChanging(ref handled, ref _travelId);
				if (handled == false)
				{
					this._travelId = value;
				}
				OnTravelIdChanged();
			}
		}
		private System.Int32 _travelId;
		partial void OnTravelIdReading();
		partial void OnTravelIdChanging(ref bool handled, ref System.Int32 _travelId);
		partial void OnTravelIdChanged();
		public System.DateTime Date
		{
			get
			{
				OnDateReading();
				return _date;
			}
			set
			{
				bool handled = false;
				OnDateChanging(ref handled, ref _date);
				if (handled == false)
				{
					this._date = value;
				}
				OnDateChanged();
			}
		}
		private System.DateTime _date;
		partial void OnDateReading();
		partial void OnDateChanging(ref bool handled, ref System.DateTime _date);
		partial void OnDateChanged();
		public System.String Description
		{
			get
			{
				OnDescriptionReading();
				return _description;
			}
			set
			{
				bool handled = false;
				OnDescriptionChanging(ref handled, ref _description);
				if (handled == false)
				{
					this._description = value;
				}
				OnDescriptionChanged();
			}
		}
		private System.String _description;
		partial void OnDescriptionReading();
		partial void OnDescriptionChanging(ref bool handled, ref System.String _description);
		partial void OnDescriptionChanged();
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
		private System.Double _amount;
		partial void OnAmountReading();
		partial void OnAmountChanging(ref bool handled, ref System.Double _amount);
		partial void OnAmountChanged();
		public System.String Friend
		{
			get
			{
				OnFriendReading();
				return _friend;
			}
			set
			{
				bool handled = false;
				OnFriendChanging(ref handled, ref _friend);
				if (handled == false)
				{
					this._friend = value;
				}
				OnFriendChanged();
			}
		}
		private System.String _friend;
		partial void OnFriendReading();
		partial void OnFriendChanging(ref bool handled, ref System.String _friend);
		partial void OnFriendChanged();
		public void CopyProperties(QnSTravelCount.Contracts.Persistence.App.IExpense other)
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
				TravelId = other.TravelId;
				Date = other.Date;
				Description = other.Description;
				Amount = other.Amount;
				Friend = other.Friend;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSTravelCount.Contracts.Persistence.App.IExpense other, ref bool handled);
		partial void AfterCopyProperties(QnSTravelCount.Contracts.Persistence.App.IExpense other);
	}
}
namespace QnSTravelCount.Transfer.Persistence.App
{
	partial class Expense : TransferObject
	{
	}
}
namespace QnSTravelCount.Transfer.Persistence.App
{
	using System.Text.Json.Serialization;
	public partial class Travel : QnSTravelCount.Contracts.Persistence.App.ITravel
	{
		static Travel()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Travel()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.String Designation
		{
			get
			{
				OnDesignationReading();
				return _designation;
			}
			set
			{
				bool handled = false;
				OnDesignationChanging(ref handled, ref _designation);
				if (handled == false)
				{
					this._designation = value;
				}
				OnDesignationChanged();
			}
		}
		private System.String _designation;
		partial void OnDesignationReading();
		partial void OnDesignationChanging(ref bool handled, ref System.String _designation);
		partial void OnDesignationChanged();
		public System.String Description
		{
			get
			{
				OnDescriptionReading();
				return _description;
			}
			set
			{
				bool handled = false;
				OnDescriptionChanging(ref handled, ref _description);
				if (handled == false)
				{
					this._description = value;
				}
				OnDescriptionChanged();
			}
		}
		private System.String _description;
		partial void OnDescriptionReading();
		partial void OnDescriptionChanging(ref bool handled, ref System.String _description);
		partial void OnDescriptionChanged();
		public System.String Currency
		{
			get
			{
				OnCurrencyReading();
				return _currency;
			}
			set
			{
				bool handled = false;
				OnCurrencyChanging(ref handled, ref _currency);
				if (handled == false)
				{
					this._currency = value;
				}
				OnCurrencyChanged();
			}
		}
		private System.String _currency;
		partial void OnCurrencyReading();
		partial void OnCurrencyChanging(ref bool handled, ref System.String _currency);
		partial void OnCurrencyChanged();
		public System.String Friends
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
		private System.String _friends;
		partial void OnFriendsReading();
		partial void OnFriendsChanging(ref bool handled, ref System.String _friends);
		partial void OnFriendsChanged();
		public System.String Category
		{
			get
			{
				OnCategoryReading();
				return _category;
			}
			set
			{
				bool handled = false;
				OnCategoryChanging(ref handled, ref _category);
				if (handled == false)
				{
					this._category = value;
				}
				OnCategoryChanged();
			}
		}
		private System.String _category;
		partial void OnCategoryReading();
		partial void OnCategoryChanging(ref bool handled, ref System.String _category);
		partial void OnCategoryChanged();
		public void CopyProperties(QnSTravelCount.Contracts.Persistence.App.ITravel other)
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
				Designation = other.Designation;
				Description = other.Description;
				Currency = other.Currency;
				Friends = other.Friends;
				Category = other.Category;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSTravelCount.Contracts.Persistence.App.ITravel other, ref bool handled);
		partial void AfterCopyProperties(QnSTravelCount.Contracts.Persistence.App.ITravel other);
	}
}
namespace QnSTravelCount.Transfer.Persistence.App
{
	partial class Travel : TransferObject
	{
	}
}
