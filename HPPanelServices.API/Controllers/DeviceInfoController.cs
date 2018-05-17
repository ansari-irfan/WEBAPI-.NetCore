using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPPanelServices.Business.Implementations;
using HPPanelServices.Business.Interfaces;
using HPPanelServices.Data;
using HPPanelServices.Data.Repository.Implementations;
using HPPanelServices.Model.DataObject;
using Microsoft.AspNetCore.Mvc;

namespace HPPanelServices.API.Controllers
{
    [Route("api/DeviceInfo")]
    public class DeviceInfoController : Controller
    {
        private IDeviceInfoService _deviceInfoService;
        public DeviceInfoController(UnitOfWork<HPPanelDBConext> unitOfWork)
        {
            _deviceInfoService = new DeviceInfoService(unitOfWork);
        }
        
        [HttpPost]
        [Route("CheckSubscription")]
        public ResponseDTO<List<StorageServiceDTO>> CheckSubscription([FromBody] RequestDTO<string> request)
        {
            return _deviceInfoService.CheckSubscription(request);
        }


        [HttpPost]
        [Route("UploadDeviceLogs")]
        public async Task<ResponseDTO<bool>> UploadDeviceLogs([FromBody] RequestDTO<UploadDeviceLogsReqDTO> request)
        {
            return await _deviceInfoService.UploadDeviceLogs(request);
        }


        [HttpPost]
        [Route("GetFTPServerDetails")]
        public async Task<ResponseDTO<FTPServerInfoDTO>> GetFTPServerDetails([FromBody] RequestDTO<string> request)
        {
            return await _deviceInfoService.GetFTPServerDetails(request);
        }
    }
}