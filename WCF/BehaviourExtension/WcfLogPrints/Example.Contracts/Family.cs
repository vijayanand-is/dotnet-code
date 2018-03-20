using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Example.Contracts
{
    [DataContract]
    public class Family
    {
        [DataMember]
        public Person HeadOfFamily { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
