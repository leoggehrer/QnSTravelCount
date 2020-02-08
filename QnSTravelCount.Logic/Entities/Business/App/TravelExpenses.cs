using System;
using System.Collections.Generic;
using System.Linq;
using CommonBase.Extensions;
using QnSTravelCount.Contracts.Business.App;
using QnSTravelCount.Contracts.Modules.TravelExpense;
using QnSTravelCount.Contracts.Persistence.App;
using QnSTravelCount.Logic.Entities.Modules.TravelExpense;
using QnSTravelCount.Logic.Entities.Persistence.App;

namespace QnSTravelCount.Logic.Entities.Business.App
{
    partial class TravelExpenses
    {
        internal Travel TravelEntity { get; } = new Travel();
        partial void OnTravelReading()
        {
            _travel = TravelEntity;
        }
        internal List<Expense> ExpenseEntities { get; } = new List<Expense>();
        partial void OnExpensesReading()
        {
            _expenses = ExpenseEntities;
        }
        partial void OnIdReading()
        {
            _id = TravelEntity.Id;
        }
        partial void OnIdChanged()
        {
            TravelEntity.Id = _id;
        }

        partial void OnTotalExpenseReading()
        {
            double result = 0;

            if (ExpenseEntities != null)
            {
                foreach (var item in ExpenseEntities)
                {
                    result += item.Amount;
                }
            }
            _totalExpense = result;
        }
        partial void OnFriendPortionReading()
        {
            var result = TotalExpense;

            if (NumberOfFriends > 1)
            {
                result = result / NumberOfFriends;
            }
            _friendPortion = result;
        }
        partial void OnNumberOfFriendsReading()
        {
            int result = 0;

            if (TravelEntity != null)
            {
                result = TravelEntity.Friends.Split(";").Length;
            }
            _numberOfFriends = result;
        }
        partial void OnFriendsReading()
        {
            _friends = GetFriends();
        }
        partial void OnFriendAmountsReading()
        {
            _friendAmounts = Friends.Select(i => GetTotalExpenseBy(i)).ToArray();
        }
        partial void OnBalancesReading()
        {
            _balances = CalculateBalance();
        }
        partial void BeforeCopyProperties(ITravelExpenses other, ref bool handled)
        {
            other.CheckArgument(nameof(other));
            other.Travel.CheckArgument(nameof(other.Travel));
            other.Expenses.CheckArgument(nameof(other.Expenses));

            handled = true;
            TravelEntity.CopyProperties(other.Travel);
            ExpenseEntities.Clear();
            foreach (var item in other.Expenses)
            {
                var expense = new Expense();

                expense.CopyProperties(item);
                ExpenseEntities.Add(expense);
            }
        }

        public void Add(IExpense expense)
        {
            expense.CheckArgument(nameof(expense));

            var newItem = new Expense();

            newItem.CopyProperties(expense);
            ExpenseEntities.Add(newItem);
        }

        public IExpense CreateExpense()
        {
            return new Expense();
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

        public string[] GetFriends()
        {
            return TravelEntity != null ? TravelEntity.Friends.Split(";") : new string[0];
        }
        public double GetTotalExpenseBy(string friend)
        {
            double result = 0;

            if (ExpenseEntities != null)
            {
                var items = ExpenseEntities.Where(i => i.Friend.Equals(friend));

                if (items.Any())
                {
                    result = items.Sum(i => i.Amount);
                }
            }
            return result;
        }
        public IEnumerable<IBalance> CalculateBalance()
        {
            List<IBalance> result = new List<IBalance>();
            var friendPart = FriendPortion;
            var friends = Friends;
            var amounts = FriendAmounts;
            var friendsAndAmounts = friends.Select((f, i) => new { Friend = f, Amount = amounts[i] });
            var giveFriends = friendsAndAmounts.Where(i => i.Amount < friendPart);
            var getFriends = friendsAndAmounts.Where(i => i.Amount > friendPart);

            foreach (var give in giveFriends)
            {
                var giveDif = friendPart - give.Amount;

                foreach (var get in getFriends)
                {
                    if (Math.Abs(giveDif) > 0.01)
                    {
                        var getDif = get.Amount - result.Where(i => i.To.Equals(get.Friend))
                                                        .Sum(i => i.Amount)
                                                - friendPart;

                        if (getDif > 0)
                        {
                            var dif = Math.Min(giveDif, getDif);

                            result.Add(new Balance() { From = give.Friend, To = get.Friend, Amount = dif });
                            giveDif = giveDif - dif;
                        }
                    }
                }
            }
            return result;
        }
    }
}
