using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Test;

namespace ResearchWebStack.Data
{
    public class ContentRepository : IContentRepository
    {
        public XmlDocument getXmlFile()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("../../../ResearchWebStack.Content/UnitTests.xml");
            }
            catch (Exception ex)
            {
                doc = null;
            }
            return doc;
        }
        public TestRun deserializeXml(string filepath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TestRun));
                TestRun resultingMessage = (TestRun)serializer.Deserialize(new XmlTextReader(filepath));
                return resultingMessage;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
