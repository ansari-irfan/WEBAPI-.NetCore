using HPPanelServices.Business.Interfaces;
using HPPanelServices.Data.Repository.Implementations;
using HPPanelServices.Data.Repository.Interfaces;
using HPPanelServices.Model;
using HPPanelServices.Model.DataObject;
using HPPanelServices.Utility.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPPanelServices.Business.Implementations
{
    public class DeviceInfoService : IDeviceInfoService
    {
        private IUnitOfWork unitOfWork;
        public DeviceInfoService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public ResponseDTO<List<StorageServiceDTO>> CheckSubscription(RequestDTO<string> request)
        {
            ResponseDTO<List<StorageServiceDTO>> response = new ResponseDTO<List<StorageServiceDTO>>();

            MFPDevice mfpDevice = null;
            CompanyAccount companyAccount = null;


            List<StorageServiceEnrollment> storageServiceEnrollmentList = null;
            List<StorageServiceDTO> storageServiceList = new List<StorageServiceDTO>();
            try
            {
                mfpDevice = unitOfWork.MFPDeviceRepository.Get(x => x.MFPDeviceSerialNumber == request.Data).FirstOrDefault();


                if (mfpDevice != null)
                {
                    companyAccount = unitOfWork.CompanyAccountRepository.Get(c => c.CompanyID == mfpDevice.CompanyID).FirstOrDefault();
                }

                if (mfpDevice == null)
                {
                    response.Message = "Device not registered.";
                }
                else if (mfpDevice != null && (DateTime.Compare(mfpDevice.MFPDevicDeactivationDate, DateTime.UtcNow) < 0))
                {
                    response.Message = "Device Deactivated.";
                }
                else if (companyAccount == null)
                {
                    response.Message = "Company not registered.";
                }
                else if (companyAccount != null && (DateTime.Compare(companyAccount.SubscriptionEndDate, DateTime.UtcNow) < 0))
                {
                    response.Message = "Company subscription expired.";
                }
                else
                {
                    storageServiceEnrollmentList = unitOfWork.StorageServiceEnrollmentRepository.Get(c => c.MFPDeviceID == mfpDevice.MFPDeviceID).ToList();

                    foreach (StorageServiceEnrollment storageServiceEnrollment in storageServiceEnrollmentList)
                    {
                        URLListing urlListing = null;
                        if (companyAccount != null && storageServiceEnrollment != null)
                        {
                            urlListing = unitOfWork.URLListingRepository.Get(x => x.CompanyID == companyAccount.CompanyID && x.ServiceID == storageServiceEnrollment.ServiceID).FirstOrDefault();

                        }

                        StorageService storageService = unitOfWork.StorageServiceRepository.Get(x => x.ServiceID == storageServiceEnrollment.ServiceID).FirstOrDefault();

                        if (storageService != null)
                        {
                            StorageServiceDTO dto = new StorageServiceDTO
                            {
                                ServiceID = storageService.ServiceID,
                                ServiceName = storageService.ServiceName,
                                ServiceAPIURL = urlListing != null ? urlListing.ServiceAPIURL : "",
                                ServiceSiteURL = urlListing != null ? urlListing.ServiceSiteURL : "",
                                ServiceType = storageService.ServiceType,
                            };

                            storageServiceList.Add(dto);
                        }

                    }
                }


                response.Data = storageServiceList;
                if (storageServiceList != null && storageServiceList.Count > 0)
                {
                    response.Status = ResponseStatusEnum.SUCCESS;
                }
                else
                {
                    response.Status = ResponseStatusEnum.ERROR;
                }
            }
            catch (Exception)
            {
                response.Data = null;
                response.Status = ResponseStatusEnum.ERROR;
            }

            return response;
        }

        public Task<ResponseDTO<FTPServerInfoDTO>> GetFTPServerDetails(RequestDTO<string> request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDTO<bool>> UploadDeviceLogs(RequestDTO<UploadDeviceLogsReqDTO> request)
        {
            throw new NotImplementedException();
        }
    }
}
