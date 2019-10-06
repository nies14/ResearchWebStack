using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Test;

namespace ResearchWebStack.Data
{
    public interface IContentRepository
    {
        XmlDocument getXmlFile();
        TestRun deserializeXml(string filepath);
    }
}
