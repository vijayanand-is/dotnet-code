using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class User : Element
    {
        public User(string name, DateTime expirationDate, int credits)
        {
            Name = name;
            ExpirationDate = expirationDate;
            Credits = credits;
        }

        public string Name { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int Credits { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
