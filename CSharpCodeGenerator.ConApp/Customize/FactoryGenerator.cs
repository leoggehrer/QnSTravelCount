using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodeGenerator.ConApp.Generation
{
    using System.Text.Json.Serialization;
    partial class FactoryGenerator
    {
        partial void CanCreateController(string generationName, Type type, ref bool create)
        {
            if (type.Name.Equals("ITravel"))
                create = false;
            else if (type.Name.Equals("IExpense"))
                create = false;
        }
    }
}
