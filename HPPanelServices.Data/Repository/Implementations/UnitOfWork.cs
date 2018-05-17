using HPPanelServices.Data.Repository.Interfaces;
using HPPanelServices.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace HPPanelServices.Data.Repository.Implementations
{
    public class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        private TContext _context;
        private IRepository<CompanyAccount> companyAccountRepository;
        private IRepository<DefaultUser> defaultUserRepository;
        private IRepository<FTPServerInfo> fTPServerInfoRepository;
        private IRepository<MFPDevice> mFPDeviceRepository;
        private IRepository<MFPDeviceLog> mFPDeviceLogRepository;
        private IRepository<StorageService> storageServiceRepository;
        private IRepository<StorageServiceEnrollment> storageServiceEnrollmentRepository;
        private IRepository<URLListing> uRLListingRepository;

        public UnitOfWork()
        {
        }

        public UnitOfWork(TContext context)
        {
            context.Database.EnsureCreated();
            _context = context;
        }

        public IRepository<CompanyAccount> CompanyAccountRepository
        {
            get => companyAccountRepository = companyAccountRepository ?? new Repository<CompanyAccount, TContext>(_context);
        }
        public IRepository<DefaultUser> DefaultUserRepository
        {
            get => defaultUserRepository = defaultUserRepository ?? new Repository<DefaultUser, TContext>(_context);
        }
        public IRepository<FTPServerInfo> FTPServerInfoRepository
        {
            get => fTPServerInfoRepository = fTPServerInfoRepository ?? new Repository<FTPServerInfo, TContext>(_context);
        }

        public IRepository<MFPDevice> MFPDeviceRepository
        {
            get => mFPDeviceRepository = mFPDeviceRepository ?? new Repository<MFPDevice, TContext>(_context);

        }

        public IRepository<MFPDeviceLog> MFPDeviceLogRepository
        {
            get => mFPDeviceLogRepository = mFPDeviceLogRepository ?? new Repository<MFPDeviceLog, TContext>(_context);
        }

        public IRepository<StorageService> StorageServiceRepository
        {
            get => storageServiceRepository = storageServiceRepository ?? new Repository<StorageService, TContext>(_context);
        }

        public IRepository<StorageServiceEnrollment> StorageServiceEnrollmentRepository
        {
            get => storageServiceEnrollmentRepository = storageServiceEnrollmentRepository ?? new Repository<StorageServiceEnrollment, TContext>(_context);
        }

        public IRepository<URLListing> URLListingRepository
        {
            get => uRLListingRepository = uRLListingRepository ?? new Repository<URLListing, TContext>(_context);

        }


        public void Commit()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
