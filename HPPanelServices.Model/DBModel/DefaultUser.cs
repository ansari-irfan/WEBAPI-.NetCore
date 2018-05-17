using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HPPanelServices.Model
{
    public class DefaultUser
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
        public int? CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public CompanyAccount CompanyAccount { get; set; }
    }
}
