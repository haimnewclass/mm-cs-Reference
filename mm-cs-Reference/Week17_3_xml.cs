using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace mm_cs_Reference
{
    internal class Week17_3_xml
    {
        public void Run()
        {
            XmlDocument xmlDoc = new XmlDocument();
            string fname = @"C:\Users\ASI\source\repos\haimnewclass\mm-cs-Reference\mm-cs-Reference\XMLFile1.xml";
            xmlDoc.Load(fname);
            string ud =  xmlDoc["Orders"]["Order"]["Item"].Attributes["Id"].Value;
            XmlNodeList list =  xmlDoc.SelectNodes("//Items/[Id='Cola']");

            xmlDoc["Orders"]["Order"]["Item"].Attributes["Id"].Value = "Dani";

            XmlNode node = xmlDoc.SelectSingleNode("//Items/[Id='Cola']");
            node.AppendChild(xmlDoc.CreateNode(XmlNodeType.Element,"Bottle",""));

            string sql = @"<Orders><Order Id='123' Name='Tnuva'>< Item Id = 'Milki' price = '3' ></ Item ></Order/></Orders>";

            xmlDoc.LoadXml(sql);
            
            //xmlDoc["Orders"]["Order"]


        }
    }
}
