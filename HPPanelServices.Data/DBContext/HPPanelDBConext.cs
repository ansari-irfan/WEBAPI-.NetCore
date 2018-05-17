using HPPanelServices.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPPanelServices.Data
{
    public class HPPanelDBConext : DbContext
    {
        public HPPanelDBConext(DbContextOptions<HPPanelDBConext> options) : base(options)
        {

        }

        public DbSet<CompanyAccount> CompanyAccount { get;set;}
        public DbSet<DefaultUser> DefaultUser { get;set;}
        public DbSet<FTPServerInfo> FTPServerInfo { get;set;}
        public DbSet<MFPDevice> MFPDevice { get;set;}
        public DbSet<MFPDeviceLog> MFPDeviceLog { get;set;}
        public DbSet<StorageService> StorageService { get;set;}
        public DbSet<URLListing> URLListing { get;set;}
        public DbSet<StorageServiceEnrollment> StorageServiceEnrollment { get;set; }
    }
}
