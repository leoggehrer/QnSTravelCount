namespace QnSTravelCount.Logic.Entities.Persistence.App
{
	using System;
	partial class Expense : QnSTravelCount.Contracts.Persistence.App.IExpense
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
		public override bool Equals(object obj)
		{
			if (!(obj is QnSTravelCount.Contracts.Persistence.App.IExpense instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSTravelCount.Contracts.Persistence.App.IExpense other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && TravelId == other.TravelId && Date == other.Date && IsEqualsWith(Description, other.Description) && Amount == other.Amount && IsEqualsWith(Friend, other.Friend);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, TravelId, Date, Description, Amount, HashCode.Combine(Friend));
		}
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.App
{
	partial class Expense : IdentityObject
	{
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.App
{
	partial class Expense
	{
		public QnSTravelCount.Logic.Entities.Persistence.App.Travel Travel
		{
			get;
			set;
		}
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.App
{
	using System;
	partial class Travel : QnSTravelCount.Contracts.Persistence.App.ITravel
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
		public override bool Equals(object obj)
		{
			if (!(obj is QnSTravelCount.Contracts.Persistence.App.ITravel instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSTravelCount.Contracts.Persistence.App.ITravel other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Designation, other.Designation) && IsEqualsWith(Description, other.Description) && IsEqualsWith(Currency, other.Currency) && IsEqualsWith(Friends, other.Friends) && IsEqualsWith(Category, other.Category);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Designation, Description, Currency, Friends, HashCode.Combine(Category));
		}
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.App
{
	partial class Travel : IdentityObject
	{
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.App
{
	partial class Travel
	{
		public System.Collections.Generic.ICollection<QnSTravelCount.Logic.Entities.Persistence.App.Expense> Expenses
		{
			get;
			set;
		}
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.Account
{
	using System;
	partial class Application : QnSTravelCount.Contracts.Persistence.Account.IApplication
	{
		static Application()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Application()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.String Name
		{
			get
			{
				OnNameReading();
				return _name;
			}
			set
			{
				bool handled = false;
				OnNameChanging(ref handled, ref _name);
				if (handled == false)
				{
					this._name = value;
				}
				OnNameChanged();
			}
		}
		private System.String _name;
		partial void OnNameReading();
		partial void OnNameChanging(ref bool handled, ref System.String _name);
		partial void OnNameChanged();
		public System.String Token
		{
			get
			{
				OnTokenReading();
				return _token;
			}
			set
			{
				bool handled = false;
				OnTokenChanging(ref handled, ref _token);
				if (handled == false)
				{
					this._token = value;
				}
				OnTokenChanged();
			}
		}
		private System.String _token;
		partial void OnTokenReading();
		partial void OnTokenChanging(ref bool handled, ref System.String _token);
		partial void OnTokenChanged();
		public QnSTravelCount.Contracts.State State
		{
			get
			{
				OnStateReading();
				return _state;
			}
			set
			{
				bool handled = false;
				OnStateChanging(ref handled, ref _state);
				if (handled == false)
				{
					this._state = value;
				}
				OnStateChanged();
			}
		}
		private QnSTravelCount.Contracts.State _state;
		partial void OnStateReading();
		partial void OnStateChanging(ref bool handled, ref QnSTravelCount.Contracts.State _state);
		partial void OnStateChanged();
		public void CopyProperties(QnSTravelCount.Contracts.Persistence.Account.IApplication other)
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
				Name = other.Name;
				Token = other.Token;
				State = other.State;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSTravelCount.Contracts.Persistence.Account.IApplication other, ref bool handled);
		partial void AfterCopyProperties(QnSTravelCount.Contracts.Persistence.Account.IApplication other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSTravelCount.Contracts.Persistence.Account.IApplication instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSTravelCount.Contracts.Persistence.Account.IApplication other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Name, other.Name) && IsEqualsWith(Token, other.Token) && State == other.State;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Name, Token, State);
		}
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.Account
{
	partial class Application : IdentityObject
	{
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.Account
{
	partial class Application
	{
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.Account
{
	using System;
	partial class User : QnSTravelCount.Contracts.Persistence.Account.IUser
	{
		static User()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public User()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.String UserName
		{
			get
			{
				OnUserNameReading();
				return _userName;
			}
			set
			{
				bool handled = false;
				OnUserNameChanging(ref handled, ref _userName);
				if (handled == false)
				{
					this._userName = value;
				}
				OnUserNameChanged();
			}
		}
		private System.String _userName;
		partial void OnUserNameReading();
		partial void OnUserNameChanging(ref bool handled, ref System.String _userName);
		partial void OnUserNameChanged();
		public System.String Password
		{
			get
			{
				OnPasswordReading();
				return _password;
			}
			set
			{
				bool handled = false;
				OnPasswordChanging(ref handled, ref _password);
				if (handled == false)
				{
					this._password = value;
				}
				OnPasswordChanged();
			}
		}
		private System.String _password;
		partial void OnPasswordReading();
		partial void OnPasswordChanging(ref bool handled, ref System.String _password);
		partial void OnPasswordChanged();
		public System.String Email
		{
			get
			{
				OnEmailReading();
				return _email;
			}
			set
			{
				bool handled = false;
				OnEmailChanging(ref handled, ref _email);
				if (handled == false)
				{
					this._email = value;
				}
				OnEmailChanged();
			}
		}
		private System.String _email;
		partial void OnEmailReading();
		partial void OnEmailChanging(ref bool handled, ref System.String _email);
		partial void OnEmailChanged();
		public System.String FirstName
		{
			get
			{
				OnFirstNameReading();
				return _firstName;
			}
			set
			{
				bool handled = false;
				OnFirstNameChanging(ref handled, ref _firstName);
				if (handled == false)
				{
					this._firstName = value;
				}
				OnFirstNameChanged();
			}
		}
		private System.String _firstName;
		partial void OnFirstNameReading();
		partial void OnFirstNameChanging(ref bool handled, ref System.String _firstName);
		partial void OnFirstNameChanged();
		public System.String LastName
		{
			get
			{
				OnLastNameReading();
				return _lastName;
			}
			set
			{
				bool handled = false;
				OnLastNameChanging(ref handled, ref _lastName);
				if (handled == false)
				{
					this._lastName = value;
				}
				OnLastNameChanged();
			}
		}
		private System.String _lastName;
		partial void OnLastNameReading();
		partial void OnLastNameChanging(ref bool handled, ref System.String _lastName);
		partial void OnLastNameChanged();
		public System.String FullName
		{
			get
			{
				OnFullNameReading();
				return _fullName;
			}
			set
			{
				bool handled = false;
				OnFullNameChanging(ref handled, ref _fullName);
				if (handled == false)
				{
					this._fullName = value;
				}
				OnFullNameChanged();
			}
		}
		private System.String _fullName;
		partial void OnFullNameReading();
		partial void OnFullNameChanging(ref bool handled, ref System.String _fullName);
		partial void OnFullNameChanged();
		public System.String PhoneNumber
		{
			get
			{
				OnPhoneNumberReading();
				return _phoneNumber;
			}
			set
			{
				bool handled = false;
				OnPhoneNumberChanging(ref handled, ref _phoneNumber);
				if (handled == false)
				{
					this._phoneNumber = value;
				}
				OnPhoneNumberChanged();
			}
		}
		private System.String _phoneNumber;
		partial void OnPhoneNumberReading();
		partial void OnPhoneNumberChanging(ref bool handled, ref System.String _phoneNumber);
		partial void OnPhoneNumberChanged();
		public System.Byte[] Avatar
		{
			get
			{
				OnAvatarReading();
				return _avatar;
			}
			set
			{
				bool handled = false;
				OnAvatarChanging(ref handled, ref _avatar);
				if (handled == false)
				{
					this._avatar = value;
				}
				OnAvatarChanged();
			}
		}
		private System.Byte[] _avatar;
		partial void OnAvatarReading();
		partial void OnAvatarChanging(ref bool handled, ref System.Byte[] _avatar);
		partial void OnAvatarChanged();
		public System.String AvatarMimeType
		{
			get
			{
				OnAvatarMimeTypeReading();
				return _avatarMimeType;
			}
			set
			{
				bool handled = false;
				OnAvatarMimeTypeChanging(ref handled, ref _avatarMimeType);
				if (handled == false)
				{
					this._avatarMimeType = value;
				}
				OnAvatarMimeTypeChanged();
			}
		}
		private System.String _avatarMimeType;
		partial void OnAvatarMimeTypeReading();
		partial void OnAvatarMimeTypeChanging(ref bool handled, ref System.String _avatarMimeType);
		partial void OnAvatarMimeTypeChanged();
		public QnSTravelCount.Contracts.State State
		{
			get
			{
				OnStateReading();
				return _state;
			}
			set
			{
				bool handled = false;
				OnStateChanging(ref handled, ref _state);
				if (handled == false)
				{
					this._state = value;
				}
				OnStateChanged();
			}
		}
		private QnSTravelCount.Contracts.State _state;
		partial void OnStateReading();
		partial void OnStateChanging(ref bool handled, ref QnSTravelCount.Contracts.State _state);
		partial void OnStateChanged();
		public void CopyProperties(QnSTravelCount.Contracts.Persistence.Account.IUser other)
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
				UserName = other.UserName;
				Password = other.Password;
				Email = other.Email;
				FirstName = other.FirstName;
				LastName = other.LastName;
				FullName = other.FullName;
				PhoneNumber = other.PhoneNumber;
				Avatar = other.Avatar;
				AvatarMimeType = other.AvatarMimeType;
				State = other.State;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSTravelCount.Contracts.Persistence.Account.IUser other, ref bool handled);
		partial void AfterCopyProperties(QnSTravelCount.Contracts.Persistence.Account.IUser other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSTravelCount.Contracts.Persistence.Account.IUser instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSTravelCount.Contracts.Persistence.Account.IUser other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(UserName, other.UserName) && IsEqualsWith(Password, other.Password) && IsEqualsWith(Email, other.Email) && IsEqualsWith(FirstName, other.FirstName) && IsEqualsWith(LastName, other.LastName) && IsEqualsWith(FullName, other.FullName) && IsEqualsWith(PhoneNumber, other.PhoneNumber) && IsEqualsWith(Avatar, other.Avatar) && IsEqualsWith(AvatarMimeType, other.AvatarMimeType) && State == other.State;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, UserName, Password, Email, FirstName, HashCode.Combine(LastName, FullName, PhoneNumber, Avatar, AvatarMimeType, State));
		}
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.Account
{
	partial class User : IdentityObject
	{
	}
}
namespace QnSTravelCount.Logic.Entities.Persistence.Account
{
	partial class User
	{
	}
}
