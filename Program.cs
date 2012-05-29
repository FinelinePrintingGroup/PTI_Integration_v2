using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PrintableIntegration
{
    class Program
    {
        ConsoleText ConsoleText = new ConsoleText();

        static void Main(string[] args)
        {
            Printable_Classes.CreatePackingSlipByLineItem byLineItem = new PrintableIntegration.Printable_Classes.CreatePackingSlipByLineItem();
            ConsoleText.ConsOut_Red(byLineItem.Request);


            Printable_Classes.CreatePackingSlipByOrder byOrder = new PrintableIntegration.Printable_Classes.CreatePackingSlipByOrder();
            ConsoleText.ConsOut_Cyan(byOrder.Request);


            Printable_Classes.CreatePackingSlipBySalesWorkOrder bySalesWorkOrder = new PrintableIntegration.Printable_Classes.CreatePackingSlipBySalesWorkOrder();
            ConsoleText.ConsOut_Magenta(bySalesWorkOrder.Request);


            Printable_Classes.UpdatePackingSlip updatePackingSlip = new PrintableIntegration.Printable_Classes.UpdatePackingSlip();
            ConsoleText.ConsOut_Yellow(updatePackingSlip.Request);

            Printable_Classes.Printable.saveXMLDocument(byLineItem.Request, "request_test");
        }
        
    }
}
