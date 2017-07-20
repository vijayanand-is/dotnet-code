using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Parser
    {
        public Expression Parse(string Context)
        {
            List<string> parts = new List<string>(Context.Split(' '));

            if (parts.Count < 3)
            {
                return new ValueExpression(Context);
            }

            Expression firstExpression = new ValueExpression(parts[0]);
            parts.RemoveAt(0);
            return GetNextExpression(parts, firstExpression);
        }

        private Expression GetNextExpression(List<string> Parts, Expression FirstExpression)
        {
            if (Parts.Count < 2)
            {
                return FirstExpression;
            }

            Expression secondExpression = new ValueExpression(Parts[1]);
            string part = Parts[0];
            Parts.RemoveAt(0);
            Parts.RemoveAt(0);
            if (part.ToUpper().Equals("OR"))
            {
                return new OrExpression(FirstExpression, GetNextExpression(Parts, secondExpression));
            }
            else
            {
                return new AndExpression(FirstExpression, GetNextExpression(Parts, secondExpression));
            }
        }
    }

}
