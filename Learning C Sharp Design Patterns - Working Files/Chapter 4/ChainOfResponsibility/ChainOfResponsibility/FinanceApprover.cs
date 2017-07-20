using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class FinanceApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if (material.Budget < 100000)
            {
                if (NextApprover != null)
                {
                    // finance may be the end of the chain, but this allows changes later
                    NextApprover.ApproveMaterial(material, ref reason);
                }
                return true;
            }
            else
            {
                reason = "This is way too much - find another way!";
                return false;
            }
        }

    }
}
