using CommonBase.Extensions;
using QnSTravelCount.Contracts.Persistence.App;
using QnSTravelCount.Transfer.Persistence.App;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace QnSTravelCount.Transfer.Business.App
{
    partial class TravelExpenses
    {
        [JsonPropertyName(nameof(Travel))]
        public Travel TravelEntity { get; set; } = new Travel();
        [JsonPropertyName(nameof(Expenses))]
        public List<Expense> ExpenseEntities { get; set; } = new List<Expense>();


        public IExpense CreateExpense()
        {
            return new Expense();
        }
        public void Add(IExpense expense)
        {
            expense.CheckArgument(nameof(expense));

            var newItem = new Expense();

            newItem.CopyProperties(expense);
            ExpenseEntities.Add(newItem);
        }
        public void Remove(IExpense expense)
        {
            expense.CheckArgument(nameof(expense));

            foreach (var item in ExpenseEntities)
            {
                if (item.Id != 0 && item.Id == expense.Id)
                {
                    ExpenseEntities.Remove(item);
                }
                else if (item.Description != null && item.Description.Equals(expense.Description))
                {
                    ExpenseEntities.Remove(item);
                }
            }
        }
    }
}
