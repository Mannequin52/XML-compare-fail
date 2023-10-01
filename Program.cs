using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;

namespace _2XML_comparison_fail_no1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             public bool XMLCompare(XElement primary, XElement secondary)
{
    if (primary.HasAttributes) {
        if (primary.Attributes().Count() != secondary.Attributes().Count())
            return false;
        foreach (XAttribute attr in primary.Attributes()) {
            if (secondary.Attribute(attr.Name.LocalName) == null)
                return false;
            if (attr.Value.ToLower() != secondary.Attribute(attr.Name.LocalName).Value.ToLower())
                return false;
        }
    }
    if (primary.HasElements) {
        if (primary.Elements().Count() != secondary.Elements().Count())
            return false;
        for (var i = 0; i <= primary.Elements().Count() - 1; i++) {
            if (XMLCompare(primary.Elements().Skip(i).Take(1).Single(), secondary.Elements().Skip(i).Take(1).Single()) == false)
                return false;
        }
    }
    return true;
}
             
             */
            XmlDocument prvi = new XmlDocument();
            prvi.Load("prvi.xml");

            XmlNode node = prvi.SelectSingleNode("Books");

            XmlNodeList books = node.SelectNodes("book");

            foreach (XmlNode book in books)
            {
                books Temp = new books();
                Temp.AssignInfo(book);
                lstbooks.Add(Temp);
            }
        }
    }
}
