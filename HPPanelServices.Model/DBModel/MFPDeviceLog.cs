using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HPPanelServices.Model
{
  public class MFPDeviceLog
    {
        [Key]
        public int LogID { get; set; }
        public string TransactionNumber { get; set; }
        public int ScanPageCount { get; set; }
        public string UserName { get; set; }
        public int? DeviceId { get; set; }
        public int? ServiceID { get; set; }
        [ForeignKey("DeviceId")]
        public  MFPDevice MFPDevice { get; set; }
        [ForeignKey("ServiceID")]
        public  StorageService StorageService { get; set; }
    }
}
