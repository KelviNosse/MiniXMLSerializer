using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer.Logic
{
    public class XmlName : Attribute
    {
        public string Name { get; set; }

        public XmlName(string name)
        {
            Name = name;
        }
    }
}
