using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HPPanelServices.Model
{
    public class FTPServerInfo
    {
        [Key]
        public int FTPServerInfoID { get; set; }
        public string FTPServerURL { get; set; }
        public int FTPServerPort { get; set; }
        public string FTPServerUserName { get; set; }
        public string FTPServerUserPassword { get; set; }
    }
}
