using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPPanelServices.Model.DataObject
{
    public class DefaultUserDTO
    {
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
    }
}
