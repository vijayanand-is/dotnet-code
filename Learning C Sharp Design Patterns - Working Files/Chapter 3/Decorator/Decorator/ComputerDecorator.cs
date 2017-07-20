using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ComputerDecorator : Computer
    {
        protected Computer BaseComputer = null;

        protected string OptionCode = "";
        protected decimal Price = 0.0M;

        protected ComputerDecorator(Computer computer)
        {
            BaseComputer = computer;
            Model = computer.Model;
        }

        #region Computer Members

        public override string GetOptionCode()
        {
            return string.Format("{0}-{1}", BaseComputer.GetOptionCode(), OptionCode);
        }

        public override decimal GetPrice()
        {
            return Price + BaseComputer.GetPrice();
        }

        #endregion
    }
}
