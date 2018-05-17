using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HPPanelServices.Model
{
   public class URLListing
    {
        [Key]
        public int URLListingID { get; set; }
        public string ServiceAPIURL { get; set; }
        public string ServiceSiteURL { get; set; }
        public int? CompanyID { get; set; }
        public int? ServiceID { get; set; }
    }
}
