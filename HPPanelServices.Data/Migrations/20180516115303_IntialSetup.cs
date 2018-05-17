using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HPPanelServices.Data.Migrations
{
    public partial class IntialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyAccount",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyCode = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    SubscriptionEndDate = table.Column<DateTime>(nullable: false),
                    SubscriptionStartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAccount", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "FTPServerInfo",
                columns: table => new
                {
                    FTPServerInfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FTPServerPort = table.Column<int>(nullable: false),
                    FTPServerURL = table.Column<string>(nullable: true),
                    FTPServerUserName = table.Column<string>(nullable: true),
                    FTPServerUserPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FTPServerInfo", x => x.FTPServerInfoID);
                });

            migrationBuilder.CreateTable(
                name: "StorageService",
                columns: table => new
                {
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceName = table.Column<string>(nullable: true),
                    ServiceType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageService", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "URLListing",
                columns: table => new
                {
                    URLListingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyID = table.Column<int>(nullable: true),
                    ServiceAPIURL = table.Column<string>(nullable: true),
                    ServiceID = table.Column<int>(nullable: true),
                    ServiceSiteURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URLListing", x => x.URLListingID);
                });

            migrationBuilder.CreateTable(
                name: "DefaultUser",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyID = table.Column<int>(nullable: true),
                    UserFullName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultUser", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_DefaultUser_CompanyAccount_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CompanyAccount",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MFPDevice",
                columns: table => new
                {
                    MFPDeviceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyID = table.Column<int>(nullable: true),
                    FTPServerInfoID = table.Column<int>(nullable: true),
                    MFPDevicDeactivationDate = table.Column<DateTime>(nullable: false),
                    MFPDeviceEnrolledDate = table.Column<DateTime>(nullable: false),
                    MFPDeviceModelName = table.Column<string>(nullable: true),
                    MFPDeviceSerialNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MFPDevice", x => x.MFPDeviceID);
                    table.ForeignKey(
                        name: "FK_MFPDevice_CompanyAccount_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CompanyAccount",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MFPDevice_FTPServerInfo_FTPServerInfoID",
                        column: x => x.FTPServerInfoID,
                        principalTable: "FTPServerInfo",
                        principalColumn: "FTPServerInfoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MFPDeviceLog",
                columns: table => new
                {
                    LogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeviceId = table.Column<int>(nullable: true),
                    ScanPageCount = table.Column<int>(nullable: false),
                    ServiceID = table.Column<int>(nullable: true),
                    TransactionNumber = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MFPDeviceLog", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_MFPDeviceLog_MFPDevice_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "MFPDevice",
                        principalColumn: "MFPDeviceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MFPDeviceLog_StorageService_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "StorageService",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorageServiceEnrollment",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeactivationDate = table.Column<DateTime>(nullable: true),
                    EnrolledDate = table.Column<DateTime>(nullable: true),
                    MFPDeviceID = table.Column<int>(nullable: true),
                    ServiceID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageServiceEnrollment", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_StorageServiceEnrollment_MFPDevice_MFPDeviceID",
                        column: x => x.MFPDeviceID,
                        principalTable: "MFPDevice",
                        principalColumn: "MFPDeviceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StorageServiceEnrollment_StorageService_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "StorageService",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DefaultUser_CompanyID",
                table: "DefaultUser",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_MFPDevice_CompanyID",
                table: "MFPDevice",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_MFPDevice_FTPServerInfoID",
                table: "MFPDevice",
                column: "FTPServerInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_MFPDeviceLog_DeviceId",
                table: "MFPDeviceLog",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_MFPDeviceLog_ServiceID",
                table: "MFPDeviceLog",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageServiceEnrollment_MFPDeviceID",
                table: "StorageServiceEnrollment",
                column: "MFPDeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageServiceEnrollment_ServiceID",
                table: "StorageServiceEnrollment",
                column: "ServiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultUser");

            migrationBuilder.DropTable(
                name: "MFPDeviceLog");

            migrationBuilder.DropTable(
                name: "StorageServiceEnrollment");

            migrationBuilder.DropTable(
                name: "URLListing");

            migrationBuilder.DropTable(
                name: "MFPDevice");

            migrationBuilder.DropTable(
                name: "StorageService");

            migrationBuilder.DropTable(
                name: "CompanyAccount");

            migrationBuilder.DropTable(
                name: "FTPServerInfo");
        }
    }
}
