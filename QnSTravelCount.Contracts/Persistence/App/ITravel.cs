//@DomainCode
//MdStart
namespace QnSTravelCount.Contracts.Persistence.App
{
    public partial interface ITravel : IIdentifiable, ICopyable<ITravel>
    {
        string Designation { get; set; }
        string Description { get; set; }
        string Currency { get; set; }
        string Friends { get; set; }
        string Category { get; set; }
    }
}
//MdEnd