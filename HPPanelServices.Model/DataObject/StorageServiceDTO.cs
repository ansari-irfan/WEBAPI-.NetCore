using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPPanelServices.Model.DataObject
{
   public class StorageServiceDTO
    {
        public int ServiceID { get; set; }
        public int ServiceType { get; set; }
        public string ServiceName { get; set; }
        public string ServiceAPIURL { get; set; }
        public string ServiceSiteURL { get; set; }

    }
}
