using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yum.GovData.Models
{
    public class RecordViewModel
    {
        public string NameofPublicBody { get; set; }
        public string TypeofOrganization { get; set; }
        public string ControllingBody { get; set; }
        public string Address { get; set; }
        public string ContactNos { get; set; }
        public string FaxNos { get; set; }
        public string Website { get; set; }
        public string EmailAddress { get; set; }
        public string ExtraInfoType { get; set; }
        public string ExtraInfoValue { get; set; }
        public string ExtraInfoType2 { get; set; }
        public string ExtraInfoValue2 { get; set; }
        public string ExtraInfoType3 { get; set; }
        public string ExtraInfoValue3 { get; set; }
    }
}