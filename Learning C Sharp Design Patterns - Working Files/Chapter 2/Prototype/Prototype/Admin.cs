using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Admin : User
    {
        public override object Clone()
        {
            return this.MemberwiseClone() as User;
        }

        public override User DeepClone()
        {
            Admin admin = this.MemberwiseClone() as Admin;
            admin.HomeAddress = new Address
            {
                Address1 = this.HomeAddress.Address1,
                Address2 = this.HomeAddress.Address2,
                City = this.HomeAddress.City,
                State = this.HomeAddress.State,
                Zip = this.HomeAddress.Zip
            };

            admin.BusinessAddress = new Address
            {
                Address1 = this.BusinessAddress.Address1,
                Address2 = this.BusinessAddress.Address2,
                City = this.BusinessAddress.City,
                State = this.BusinessAddress.State,
                Zip = this.BusinessAddress.Zip
            };

            return admin;
        }
    }
}
