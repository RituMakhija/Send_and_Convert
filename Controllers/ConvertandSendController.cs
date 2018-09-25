using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using ConvertToXML_and_SendMail.Models;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Web;
using System.Data;

namespace ConvertToXML_and_SendMail.Controllers
{
    public class ConvertandSendController : ApiController
    {
               
        [HttpPost]
        public IHttpActionResult Index(/*DataModel _objModelMail,*/ Models.Convert convert)
        {
            if (ModelState.IsValid)
            {
                //MailMessage mail = new MailMessage();                
                //string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/DataToObtain.xml");  
                //DataSet ds = new DataSet();   
                //ds.ReadXml(xmlData);
                //string MailId = ds.Tables[0].Rows[0]["MailId"].ToString();
                //string StatusCode = ds.Tables[0].Rows[0]["StatusCode"].ToString();                             
                //mail.To.Add(MailId);
                //mail.From = new MailAddress(_objModelMail.From);
                //mail.Subject = StatusCode;
                //string Body = _objModelMail.Body;
                //mail.Body = Body;
                //mail.IsBodyHtml = true;
                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.outlook.com";
                //smtp.Port = 25;
                //smtp.UseDefaultCredentials = false;
                //smtp.Credentials = new System.Net.NetworkCredential("ritu.makhija@outlook.com", "loveyouforathousandyears1000");   
                //smtp.EnableSsl = true;
                //smtp.Send(mail);

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;                
                XmlSerializer xs = new XmlSerializer(typeof(Models.Convert);
                XmlWriter writer = XmlWriter.Create("D://data.xml", settings);
                xs.Serialize(writer, convert );

                //return Ok(mail);
                return Ok(writer);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
