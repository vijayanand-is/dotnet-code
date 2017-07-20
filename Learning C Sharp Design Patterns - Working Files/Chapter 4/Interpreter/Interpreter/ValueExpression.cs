using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class ValueExpression : Expression
    {
        private string Context;

        public ValueExpression(string Context)
        {
            this.Context = Context;
        }

        public override bool Interpret()
        {
            double value;
            if (double.TryParse(Context, out value))
            {
                return value != 0;
            }
            return !string.IsNullOrEmpty(Context);
        }
    }
}
