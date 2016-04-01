using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer.Logic
{
    class XmlStructure
    {

        public string InitTag;
        public string Tag;
        public XmlStructure(int xmlVersion)
        {
            InitTag = "<?xml version='" + xmlVersion + ".0'?>";
        }

        public void SetTag(string tag)
        {
            this.Tag = "<"+tag+"></"+tag+">";
        }
    }
}
