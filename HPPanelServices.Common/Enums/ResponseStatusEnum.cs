using System;
using System.Collections.Generic;
using System.Text;

namespace HPPanelServices.Utility.Enums
{
    public enum ResponseStatusEnum
    {
        ERROR = 10000,
        SUCCESS = 10001,
        NO_RECORD_FOUND = 10006,
        INVALID_CREDENTIALS = 10007,
        PASSWORD_NOT_MATCH = 10008
    }
}
