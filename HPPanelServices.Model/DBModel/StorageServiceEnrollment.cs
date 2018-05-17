using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HPPanelServices.Model
{
    public class StorageServiceEnrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int? MFPDeviceID { get; set; }
        public int? ServiceID { get; set; }
        public DateTime? EnrolledDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        [ForeignKey("MFPDeviceID")]
        public  MFPDevice MFPDevice { get; set; }
        [ForeignKey("ServiceID")]
        public StorageService StorageService { get; set; }
    }
}
