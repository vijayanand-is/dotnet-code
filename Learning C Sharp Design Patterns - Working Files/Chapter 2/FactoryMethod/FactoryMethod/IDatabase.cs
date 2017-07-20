using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;

namespace FactoryMethod
{
    public interface IDatabase
    {
        IDbConnection Connection { get; }
        IDbCommand Command { get; }
    }
}
