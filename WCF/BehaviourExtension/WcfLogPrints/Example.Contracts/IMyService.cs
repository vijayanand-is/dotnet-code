using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Example.Contracts
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        int MyOperation(int myArg, List<Family> families, out string myResult);

        [OperationContract]
        int MySecondOperation(int myArg);

        [OperationContract]
        void MyThirdOperation(int i);
    }
}
