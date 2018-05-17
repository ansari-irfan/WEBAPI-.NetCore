﻿// <auto-generated />
using HPPanelServices.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HPPanelServices.Data.Migrations
{
    [DbContext(typeof(HPPanelDBConext))]
    [Migration("20180516115303_IntialSetup")]
    partial class IntialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HPPanelServices.Model.CompanyAccount", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyCode");

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("SubscriptionEndDate");

                    b.Property<DateTime>("SubscriptionStartDate");

                    b.HasKey("CompanyID");

                    b.ToTable("CompanyAccount");
                });

            modelBuilder.Entity("HPPanelServices.Model.DefaultUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyID");

                    b.Property<string>("UserFullName");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.HasKey("UserID");

                    b.HasIndex("CompanyID");

                    b.ToTable("DefaultUser");
                });

            modelBuilder.Entity("HPPanelServices.Model.FTPServerInfo", b =>
                {
                    b.Property<int>("FTPServerInfoID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FTPServerPort");

                    b.Property<string>("FTPServerURL");

                    b.Property<string>("FTPServerUserName");

                    b.Property<string>("FTPServerUserPassword");

                    b.HasKey("FTPServerInfoID");

                    b.ToTable("FTPServerInfo");
                });

            modelBuilder.Entity("HPPanelServices.Model.MFPDevice", b =>
                {
                    b.Property<int>("MFPDeviceID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyID");

                    b.Property<int?>("FTPServerInfoID");

                    b.Property<DateTime>("MFPDevicDeactivationDate");

                    b.Property<DateTime>("MFPDeviceEnrolledDate");

                    b.Property<string>("MFPDeviceModelName");

                    b.Property<string>("MFPDeviceSerialNumber");

                    b.HasKey("MFPDeviceID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("FTPServerInfoID");

                    b.ToTable("MFPDevice");
                });

            modelBuilder.Entity("HPPanelServices.Model.MFPDeviceLog", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DeviceId");

                    b.Property<int>("ScanPageCount");

                    b.Property<int?>("ServiceID");

                    b.Property<string>("TransactionNumber");

                    b.Property<string>("UserName");

                    b.HasKey("LogID");

                    b.HasIndex("DeviceId");

                    b.HasIndex("ServiceID");

                    b.ToTable("MFPDeviceLog");
                });

            modelBuilder.Entity("HPPanelServices.Model.StorageService", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ServiceName");

                    b.Property<int>("ServiceType");

                    b.HasKey("ServiceID");

                    b.ToTable("StorageService");
                });

            modelBuilder.Entity("HPPanelServices.Model.StorageServiceEnrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DeactivationDate");

                    b.Property<DateTime?>("EnrolledDate");

                    b.Property<int?>("MFPDeviceID");

                    b.Property<int?>("ServiceID");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("MFPDeviceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("StorageServiceEnrollment");
                });

            modelBuilder.Entity("HPPanelServices.Model.URLListing", b =>
                {
                    b.Property<int>("URLListingID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyID");

                    b.Property<string>("ServiceAPIURL");

                    b.Property<int?>("ServiceID");

                    b.Property<string>("ServiceSiteURL");

                    b.HasKey("URLListingID");

                    b.ToTable("URLListing");
                });

            modelBuilder.Entity("HPPanelServices.Model.DefaultUser", b =>
                {
                    b.HasOne("HPPanelServices.Model.CompanyAccount", "CompanyAccount")
                        .WithMany()
                        .HasForeignKey("CompanyID");
                });

            modelBuilder.Entity("HPPanelServices.Model.MFPDevice", b =>
                {
                    b.HasOne("HPPanelServices.Model.CompanyAccount", "CompanyAccount")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.HasOne("HPPanelServices.Model.FTPServerInfo", "FTPServerInfo")
                        .WithMany()
                        .HasForeignKey("FTPServerInfoID");
                });

            modelBuilder.Entity("HPPanelServices.Model.MFPDeviceLog", b =>
                {
                    b.HasOne("HPPanelServices.Model.MFPDevice", "MFPDevice")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.HasOne("HPPanelServices.Model.StorageService", "StorageService")
                        .WithMany()
                        .HasForeignKey("ServiceID");
                });

            modelBuilder.Entity("HPPanelServices.Model.StorageServiceEnrollment", b =>
                {
                    b.HasOne("HPPanelServices.Model.MFPDevice", "MFPDevice")
                        .WithMany()
                        .HasForeignKey("MFPDeviceID");

                    b.HasOne("HPPanelServices.Model.StorageService", "StorageService")
                        .WithMany()
                        .HasForeignKey("ServiceID");
                });
#pragma warning restore 612, 618
        }
    }
}
