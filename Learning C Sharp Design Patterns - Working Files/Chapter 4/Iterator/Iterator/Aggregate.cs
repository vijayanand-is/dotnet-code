using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Aggregate : IAggregate
    {
        List<User> Values = null;

        public Aggregate()
        {
            Values = new List<User>();
        }

        #region IAggregate Members

        public IIterator GetIterator()
        {
            return new IteratorClass(this);
        }

        #endregion

        public User this[int index]
        {
            get
            {
                if (index < Values.Count)
                {
                    return Values[index];
                }
                else
                {
                    // might throw an exception here
                    return null;
                }
            }
            set
            {
                Values.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return Values.Count;
            }
        }
    }
}
