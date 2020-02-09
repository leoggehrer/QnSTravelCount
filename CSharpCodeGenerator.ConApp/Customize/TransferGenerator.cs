using System;
using System.Collections.Generic;

namespace CSharpCodeGenerator.ConApp.Generation
{
    partial class TransferGenerator
    {
        partial void CreateTransferPropertyAttributes(Type type, string propertyName, List<string> codeLines)
        {
            if (type.Name.Equals("ITravelExpenses"))
            {
                if (propertyName.Equals("Travel"))
                {
                    codeLines.Add("[JsonIgnore]");
                }
                else if (propertyName.Equals("Expenses"))
                {
                    codeLines.Add("[JsonIgnore]");
                }
                else if (propertyName.Equals("Balances"))
                {
                    codeLines.Add("[JsonIgnore]");
                }
            }
        }
    }
}
