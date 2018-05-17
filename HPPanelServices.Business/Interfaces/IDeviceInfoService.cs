using HPPanelServices.Model.DataObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HPPanelServices.Business.Interfaces
{
    public interface IDeviceInfoService
    {
        ResponseDTO<List<StorageServiceDTO>> CheckSubscription(RequestDTO<string> request);
        Task<ResponseDTO<bool>> UploadDeviceLogs(RequestDTO<UploadDeviceLogsReqDTO> request);
        Task<ResponseDTO<FTPServerInfoDTO>> GetFTPServerDetails(RequestDTO<string> request);

    }
}
