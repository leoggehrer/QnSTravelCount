using CommonBase.Extensions;
using QnSTravelCount.Contracts.Business.App;
using QnSTravelCount.Contracts.Persistence.App;
using QnSTravelCount.Transfer.Modules.TravelExpense;
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
        [JsonPropertyName(nameof(Balances))]
        public List<Balance> BalanceEntities { get; set; } = new List<Balance>();

        public override int Id { get => TravelEntity.Id; set => TravelEntity.Id = value; }
        partial void OnTravelReading()
        {
            _travel = TravelEntity;
        }
        partial void OnExpensesReading()
        {
            _expenses = ExpenseEntities;
        }
        partial void OnBalancesReading()
        {
            _balances = BalanceEntities;
        }

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

        partial void BeforeCopyProperties(ITravelExpenses other, ref bool handled)
        {
            other.CheckArgument(nameof(other));
            other.Travel.CheckArgument(nameof(other.Travel));
            other.Expenses.CheckArgument(nameof(other.Expenses));
            other.Balances.CheckArgument(nameof(other.Balances));

            handled = true;
            TotalExpense = other.TotalExpense;
            FriendPortion = other.FriendPortion;
            NumberOfFriends = other.NumberOfFriends;
            Friends = other.Friends;
            FriendAmounts = other.FriendAmounts;
            TravelEntity.CopyProperties(other.Travel);
            ExpenseEntities.Clear();
            foreach (var item in other.Expenses)
            {
                var expense = new Expense();

                expense.CopyProperties(item);
                ExpenseEntities.Add(expense);
            }
            BalanceEntities.Clear();
            foreach (var item in other.Balances)
            {
                var balance = new Balance();

                balance.CopyProperties(item);
                BalanceEntities.Add(balance);
            }
        }
    }
}
