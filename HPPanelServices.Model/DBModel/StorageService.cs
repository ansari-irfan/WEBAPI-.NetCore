using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HPPanelServices.Model
{
   public class StorageService
    {
        [Key]
        public int ServiceID { get; set; }
        public int ServiceType { get; set; }
        public string ServiceName { get; set; }
    }
}
