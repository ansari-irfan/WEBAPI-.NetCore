using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPPanelServices.Model.DataObject
{
    public class UploadDeviceLogsReqDTO
    {
        public int ScanPageCount { get; set; }

        public int StorageServiceType { get; set; }

        public string DeviceSerialNumber { get; set; }

        public string UserName { get; set; }
    }
}
