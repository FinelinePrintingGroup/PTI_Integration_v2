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

namespace PrintableIntegration.Printable_Classes
{
    public class PackingSlip : Printable
    {
        // SOAP XML DOCUMENTS                           
        protected XmlDocument request = new XmlDocument(); 
        public XmlDocument Request
        { get { return request; } }
 
        protected XmlDocument response = new XmlDocument();
        public XmlDocument Response
        { get { return response; } }        

        // SOAP ENVELOPE VARIABLES                      
        protected string soapPrefix = "soapenv";
        protected string ptiPrefix = "pac";
        protected string soapNamespace = @"http://schemas.xmlsoap.org/soap/envelope/";
        protected string ptiNamespace = @"http://www.printable.com/WebService/PackingSlip";
        protected XmlElement root;
        protected XmlElement header;

        // PACKING SLIP VARIABLES                       
        protected int packingSlipNumber;
        protected DateTime shipDate;
        protected string carrierName;
        protected string trackingNum;
        protected decimal ship_cost;
        protected bool skipAdjustInventory = false;

        // SHIP TO ADDRESS                              
        protected string ship_attn;
        protected string ship_name;
        protected string ship_add1;
        protected string ship_add2;
        protected string ship_add3;
        protected string ship_add4;
        protected string ship_city;
        protected string ship_state;
        protected string ship_postalCode;
        protected string ship_country;

        //                                                                                  
        // CONSTRUCTOR                                                                      
        public PackingSlip()
        {
            // SOAP ENVELOPE CREATION                   
            root = request.CreateElement(soapPrefix, "Envelope", soapNamespace);
            root.SetAttribute("xmlns:soapenv", soapNamespace);
            root.SetAttribute("xmlns:pac", ptiNamespace);
            request.AppendChild(root);

            // SOAP HEADER CREATION                     
            header = request.CreateElement(soapPrefix, "Header", soapNamespace);
            root.AppendChild(header);
        }
    }


    /// <summary>Creates a Packing Slip by OrderDetail_ID (Line Item)</summary>
    public class CreatePackingSlipByLineItem : PackingSlip
    {                                                                                 
        // LINE ITEM VARIABLES                          
        private int order_id;
        private int orderDetail_id;
        private string ship_qty;

        //                                                                                  
        // CONSTRUCTOR                                                                      
        public CreatePackingSlipByLineItem()
        {
            // SOAP BODY CREATION                       
            XmlElement body = request.CreateElement(soapPrefix, "Body", soapNamespace);

            XmlElement createPackingSlipByLineItem = request.CreateElement(ptiPrefix, "CreatePackingSlipByLineItem", ptiNamespace);
            body.AppendChild(createPackingSlipByLineItem);

            XmlElement pRequest = request.CreateElement(ptiPrefix, "pRequest", ptiNamespace);
            createPackingSlipByLineItem.AppendChild(pRequest);

            root.AppendChild(body);

            // PARTNER CREDENTIALS                      
            XmlElement partnerCredentials = request.CreateElement("PartnerCredentials");
            pRequest.AppendChild(partnerCredentials);

            XmlElement tokenTag = request.CreateElement("Token");
            tokenTag.AppendChild(request.CreateTextNode(printableToken));
            partnerCredentials.AppendChild(tokenTag);

            //                                          



        }        
    }

    /// <summary>Creates a Packing Slip by Order_ID (Order)</summary>
    public class CreatePackingSlipByOrder : PackingSlip
    {
        // ORDER VARIABLES                                                                  
        private int order_id;

        // CONSTRUCTOR                                                                      
        public CreatePackingSlipByOrder()
        {
            // SOAP BODY CREATION                                                           
            XmlElement body = request.CreateElement(soapPrefix, "Body", soapNamespace);

            XmlElement createPackingSlipByLineItem = request.CreateElement(ptiPrefix, "CreatePackingSlipByOrder", ptiNamespace);
            body.AppendChild(createPackingSlipByLineItem);

            XmlElement pRequest = request.CreateElement(ptiPrefix, "pRequest", ptiNamespace);
            createPackingSlipByLineItem.AppendChild(pRequest);

            root.AppendChild(body);

            // PARTNER CREDENTIALS                      
            XmlElement partnerCredentials = request.CreateElement("PartnerCredentials");
            pRequest.AppendChild(partnerCredentials);

            XmlElement tokenTag = request.CreateElement("Token");
            tokenTag.AppendChild(request.CreateTextNode(printableToken));
            partnerCredentials.AppendChild(tokenTag);

            //                                          
        }
    }

    /// <summary>Creates a Packing Slip by SupplierWorkOrder_ID (Supplier Work Order)</summary>
    public class CreatePackingSlipBySalesWorkOrder : PackingSlip
    {
        // SALES WORK ORDER VARIABLES                                                       
        private int salesWorkOrder_id;

        // CONSTRUCTOR                                                                      
        public CreatePackingSlipBySalesWorkOrder()
        {
            // SOAP BODY CREATION                                                           
            XmlElement body = request.CreateElement(soapPrefix, "Body", soapNamespace);

            XmlElement createPackingSlipByLineItem = request.CreateElement(ptiPrefix, "CreatePackingSlipBySalesWorkOrder", ptiNamespace);
            body.AppendChild(createPackingSlipByLineItem);

            XmlElement pRequest = request.CreateElement(ptiPrefix, "pRequest", ptiNamespace);
            createPackingSlipByLineItem.AppendChild(pRequest);
            
            root.AppendChild(body);

            // PARTNER CREDENTIALS                      
            XmlElement partnerCredentials = request.CreateElement("PartnerCredentials");
            pRequest.AppendChild(partnerCredentials);

            XmlElement tokenTag = request.CreateElement("Token");
            tokenTag.AppendChild(request.CreateTextNode(printableToken));
            partnerCredentials.AppendChild(tokenTag);

            //                                          
        }
    }

    /// <summary>Creates an Update Packing Slip request using the stored PackingSlip_ID</summary>
    public class UpdatePackingSlip : PackingSlip
    {
        // UPDATE PACKING SLIP VARIABLES                                                    
        private int packingSlip_id;

        // CONSTRUCTOR                                                                      
        public UpdatePackingSlip()
        {
            // SOAP BODY CREATION                       
            XmlElement body = request.CreateElement(soapPrefix, "Body", soapNamespace);

            XmlElement createPackingSlipByLineItem = request.CreateElement(ptiPrefix, "UpdatePackingSlip", ptiNamespace);
            body.AppendChild(createPackingSlipByLineItem);

            XmlElement pRequest = request.CreateElement(ptiPrefix, "pRequest", ptiNamespace);
            createPackingSlipByLineItem.AppendChild(pRequest);

            root.AppendChild(body);

            // PARTNER CREDENTIALS                      
            XmlElement partnerCredentials = request.CreateElement("PartnerCredentials");
            pRequest.AppendChild(partnerCredentials);

            XmlElement tokenTag = request.CreateElement("Token");
            tokenTag.AppendChild(request.CreateTextNode(printableToken));
            partnerCredentials.AppendChild(tokenTag);

            //                                          
        }
    }

    
}





