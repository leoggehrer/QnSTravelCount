//@DomainCode
//MdStart
using System;

namespace QnSTravelCount.Contracts.Persistence.App
{
    public partial interface IExpense : IIdentifiable, ICopyable<IExpense>
    {
        int TravelId { get; set; }
        DateTime Date { get; }
        string Description { get; set; }
        double Amount { get; set; }
        string Friend { get; set; }
    }
}
//MdEnd