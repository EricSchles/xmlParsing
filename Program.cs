using System;
using System.Text;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<user name=\"John Doe\">A user node</user>");
            Console.WriteLine(xmlDoc.DocumentElement.Name);
            Console.WriteLine(xmlDoc.DocumentElement.InnerText);
            Console.ReadKey();
        }
    }
}
