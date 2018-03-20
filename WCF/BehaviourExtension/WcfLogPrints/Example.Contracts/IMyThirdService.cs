using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Example.Contracts
{
    [ServiceContract]
    public interface IMyThirdService
    {
        [OperationContract]
        int MyOperation(int myArg);
    }
}
