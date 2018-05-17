using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPPanelServices.Model.DataObject
{
    public class FTPServerInfoDTO
    {
        public int FTPServerInfoID { get; set; }
        public string FTPServerURL { get; set; }
        public int FTPServerPort { get; set; }
        public string FTPServerUserPassword { get; set; }
        public string FTPServerUserName { get; set; }
    }
}
