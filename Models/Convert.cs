using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConvertToXML_and_SendMail.Models
{
    public class Convert
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string HolderName { get; set; }
        public string Branch { get; set; }

        public List<Convert> ConvertList { get; set; }
    }
}