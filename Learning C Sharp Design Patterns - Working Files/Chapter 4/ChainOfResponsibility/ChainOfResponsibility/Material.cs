using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Material
    {
        public Guid MaterialID { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string DrawingNumber { get; set; }
        public decimal Budget { get; set; }
    }
}
