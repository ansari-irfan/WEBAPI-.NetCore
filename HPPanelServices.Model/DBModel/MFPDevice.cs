using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HPPanelServices.Model
{
    public class MFPDevice
    {
        [Key]
        public int MFPDeviceID { get; set; }
        public string MFPDeviceSerialNumber { get; set; }
        public string MFPDeviceModelName { get; set; }
        public DateTime MFPDeviceEnrolledDate { get; set; }
        public DateTime MFPDevicDeactivationDate { get; set; }
        public int? CompanyID { get; set; }
        public int? FTPServerInfoID { get; set; }
        [ForeignKey("CompanyID")]
        public CompanyAccount CompanyAccount { get; set; }
        [ForeignKey("FTPServerInfoID")]
        public FTPServerInfo FTPServerInfo { get; set; }
    }
}
