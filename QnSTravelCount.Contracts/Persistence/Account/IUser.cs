namespace QnSTravelCount.Contracts.Persistence.Account
{
    public partial interface IUser : IIdentifiable, ICopyable<IUser>
    {
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName => $"{LastName} {FirstName}";
        string PhoneNumber { get; set; }
        byte[] Avatar { get; set; }
        string AvatarMimeType { get; set; }
        State State { get; set; }
    }
}
