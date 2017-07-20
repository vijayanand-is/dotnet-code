using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class EngineeringApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(material.DrawingNumber))
            {
                isValid = false;
                reason = "There is no drawing for this material";
            }
            if (string.IsNullOrWhiteSpace(material.PartNumber))
            {
                isValid = false;
                reason = "There is no part number for this material";
            }

            if (isValid)
            {
                if (NextApprover != null)
                {
                    return NextApprover.ApproveMaterial(material, ref reason);
                }
            }
            return isValid;
        }

    }
}
