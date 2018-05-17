using HPPanelServices.Data.Repository.Implementations;
using HPPanelServices.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPPanelServices.Data.Repository.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        //HPPanelDBConext Context { get; }
        void Commit();
        IRepository<DefaultUser> DefaultUserRepository { get; }
        IRepository<CompanyAccount> CompanyAccountRepository { get; }
        IRepository<FTPServerInfo> FTPServerInfoRepository { get; }
        IRepository<MFPDevice> MFPDeviceRepository { get; }
        IRepository<MFPDeviceLog> MFPDeviceLogRepository { get; }
        IRepository<StorageService> StorageServiceRepository { get; }
        IRepository<StorageServiceEnrollment> StorageServiceEnrollmentRepository { get; }
        IRepository<URLListing> URLListingRepository { get; }
    }
}
