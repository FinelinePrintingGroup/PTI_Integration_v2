using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace PrintableIntegration.Printable_Classes
{
    public class Printable
    {
        public static Uri printableURI_packingSlip
        {
            get { return new Uri(@"https://services.printable.com/TRANS/0.9/PackingSlip.asmx"); } 
        }

        public static Uri printableURI_invoice
        {
            get { return new Uri(@"https://services.printable.com/TRANS/0.9/Invoice.asmx"); } 
        }
        
        public static Uri printableURI_settlement
        {
            get { return new Uri(@"https://services.printable.com/TRANS/0.9/Settlement.asmx"); }
        }

        public static string printableToken
        {
            get { return "4F3515138E8BAA6A8D968BAE7F486C34"; }
        }


        public static void saveXMLDocument(XmlDocument xml, string filename)
        {
            System.IO.FileInfo file = new System.IO.FileInfo("../../XML/");
            file.Directory.Create();

            if ((filename != "") && (filename != null))
            {
                xml.Save("../../XML/" + filename + ".xml");
            }
            else
            {
                xml.Save("../../XML/" + DateTime.Now.ToShortDateString() + ".xml");
            }

        }
    }
}
