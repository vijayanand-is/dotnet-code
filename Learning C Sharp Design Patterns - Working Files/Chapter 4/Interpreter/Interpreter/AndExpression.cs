using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class AndExpression : Expression
    {

        private Expression Expression1 = null;
        private Expression Expression2 = null;

        public AndExpression(Expression expression1, Expression expression2)
        {
            this.Expression1 = expression1;
            this.Expression2 = expression2;
        }

        public override bool Interpret()
        {
            return Expression1.Interpret() && Expression2.Interpret();
        }
    }

}
