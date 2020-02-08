using System;
using System.Collections.Generic;
using System.Text;

namespace QnSTravelCount.Contracts.Modules.TravelExpense
{
    public interface IBalance
    {
        string From { get; }
        string To { get; }
        double Amount { get; }
    }
}
