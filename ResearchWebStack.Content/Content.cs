using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ResearchWebStack.Content
{
    public class Content : IContent
    {
        public XmlDocument getXmlFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../ResearchWebStack.Content/UnitTests.xml");
            return doc;
        }
    }
}
