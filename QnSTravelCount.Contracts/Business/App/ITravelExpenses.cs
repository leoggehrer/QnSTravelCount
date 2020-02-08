//@DomainCode
//MdStart
using System.Collections.Generic;
using QnSTravelCount.Contracts.Modules.TravelExpense;
using QnSTravelCount.Contracts.Persistence.App;

namespace QnSTravelCount.Contracts.Business.App
{
    public partial interface ITravelExpenses : IIdentifiable, ICopyable<ITravelExpenses>
    {
        ITravel Travel { get; }
        IEnumerable<IExpense> Expenses { get; }

        double TotalExpense { get; }
        double FriendPortion { get; }
        int NumberOfFriends { get; }
        string[] Friends { get; }
        double[] FriendAmounts { get; }
        IEnumerable<IBalance> Balances { get; }
        IExpense CreateExpense();
        void Add(IExpense expense);
        void Remove(IExpense expense);
    }
}
//MdEnd