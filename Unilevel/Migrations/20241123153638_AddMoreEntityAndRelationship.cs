using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddMoreEntityAndRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_GroupRole_GroupRoleId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermission_AspNetUsers_UserId",
                table: "UserPermission");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermission_Permission_PermissionId",
                table: "UserPermission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPermission",
                table: "UserPermission");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04254319-bd83-4ae0-ab15-e668d8ec2d60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08635918-20b8-40d9-8a32-687bffab632c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1398f135-30a4-4312-a83c-893bca742d2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f684f94-d893-4928-8756-563fc1b012db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf3818c-0c6d-4967-b8ed-e59f234f6df4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9401aa7c-11ad-4a83-a905-214e6e18e041");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0a34ef7-39f5-40a2-8b0c-535c428fcab4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bba507ea-8af0-42e4-b5c3-0e845c1092be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bba6d57f-58c5-48fc-975d-6194f94c092d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf10eda2-ec57-448c-8efc-060e9d8b3c4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d795568c-c96c-4c9d-a72a-fdfa4ef9ea04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff9447e2-44af-4af4-ab0f-58624c59d666");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "UserPermission",
                newName: "UserPermissions");

            migrationBuilder.RenameIndex(
                name: "IX_UserPermission_PermissionId",
                table: "UserPermissions",
                newName: "IX_UserPermissions_PermissionId");

            migrationBuilder.AddColumn<string>(
                name: "AreaId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "GroupRoleId",
                table: "AspNetRoles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPermissions",
                table: "UserPermissions",
                columns: new[] { "UserId", "PermissionId" });

            migrationBuilder.CreateTable(
                name: "JobForVisitation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkingPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reporter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobForVisitation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitCalendar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImplementationTime = table.Column<int>(type: "int", nullable: false),
                    VisitPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCalendar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImplementationDate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitCalendarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImplementationDate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImplementationDate_VisitCalendar_VisitCalendarId",
                        column: x => x.VisitCalendarId,
                        principalTable: "VisitCalendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitCalendarId = table.Column<int>(type: "int", nullable: false),
                    VisitorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => new { x.VisitorId, x.VisitCalendarId });
                    table.ForeignKey(
                        name: "FK_Visitors_AspNetUsers_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visitors_VisitCalendar_VisitCalendarId",
                        column: x => x.VisitCalendarId,
                        principalTable: "VisitCalendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distributor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SaleManagementIdId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleStaff",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SuperiorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistributorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SaleStaffId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleStaff_Distributor_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Distributor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SaleStaff_SaleStaff_SaleStaffId",
                        column: x => x.SaleStaffId,
                        principalTable: "SaleStaff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VisitCalendarDistributor",
                columns: table => new
                {
                    VisitCalendarId = table.Column<int>(type: "int", nullable: false),
                    DistributorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCalendarDistributor", x => new { x.VisitCalendarId, x.DistributorId });
                    table.ForeignKey(
                        name: "FK_VisitCalendarDistributor_Distributor_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Distributor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitCalendarDistributor_VisitCalendar_VisitCalendarId",
                        column: x => x.VisitCalendarId,
                        principalTable: "VisitCalendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "009f42a1-fe16-4293-8e7a-abaf4e288e5f", "691097da-fb4e-457e-a5ae-c44f362b8d18", 2, "BAM", "BAM" },
                    { "464a56d5-aa95-4f58-9a10-1869e488d403", "f18a7203-dd54-48f2-9280-0403b235e6b8", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "53b61fc1-5d29-42a1-8acc-ad5e18c3cb1e", "f6e56b22-7d4d-41da-a67b-67663d1bfcac", 1, "Administrator", "ADMINISTRATOR" },
                    { "7993ec28-e8ad-4275-8b59-633979c25ca1", "963fe1d3-a43e-47ea-ba7f-8d98426a34cc", 1, "Owner", "OWNER" },
                    { "7f8cfc09-46be-41e5-bcf7-18abb6fe6a3e", "ba39b90e-ea45-4150-a45e-1f1e4bef7f5a", 4, "Guest", "GUEST" },
                    { "8853fb00-5075-4b63-b91e-953fb8ead8b2", "83bec652-8e5a-4ee8-a2b5-22b3f2cd859b", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "9c402e7d-7676-4082-8ac6-77e3c43e7e2f", "48a94ea6-05e4-4d8a-93eb-a77aca01a23d", 2, "BM", "BM" },
                    { "afb28b3e-0041-4b12-9554-c2b58ff66cd2", "663e8ff5-0524-41ce-92f2-00eb6749c215", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "b7a4ba95-2ee3-41ff-b321-6fe2ebb87562", "e5dabd72-f84d-48cb-9d3c-b8ed950afacd", 3, "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "dcc22d99-4021-465a-b139-4c23e0a6d004", "2ba03275-d1de-4a7e-bd2d-349f62e9b1fa", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "f16de8db-1802-4222-a6a8-b1bc7544fb34", "8b901348-a47e-4090-aef9-abf7cdaf7fb9", 2, "ASM", "ASM" },
                    { "fb71c2e3-11b5-4530-9dc2-743e062d6a15", "bad0ac8c-5a30-4716-943f-58f78b06ae7d", 2, "VPCD", "VPCD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AreaId",
                table: "AspNetUsers",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Distributor_SaleManagementIdId",
                table: "Distributor",
                column: "SaleManagementIdId");

            migrationBuilder.CreateIndex(
                name: "IX_ImplementationDate_VisitCalendarId",
                table: "ImplementationDate",
                column: "VisitCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleStaff_DistributorId",
                table: "SaleStaff",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleStaff_SaleStaffId",
                table: "SaleStaff",
                column: "SaleStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitCalendarDistributor_DistributorId",
                table: "VisitCalendarDistributor",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_VisitCalendarId",
                table: "Visitors",
                column: "VisitCalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_GroupRole_GroupRoleId",
                table: "AspNetRoles",
                column: "GroupRoleId",
                principalTable: "GroupRole",
                principalColumn: "GroupRoleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Area_AreaId",
                table: "AspNetUsers",
                column: "AreaId",
                principalTable: "Area",
                principalColumn: "AreaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_AspNetUsers_UserId",
                table: "UserPermissions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_Permission_PermissionId",
                table: "UserPermissions",
                column: "PermissionId",
                principalTable: "Permission",
                principalColumn: "PermissionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Distributor_SaleStaff_SaleManagementIdId",
                table: "Distributor",
                column: "SaleManagementIdId",
                principalTable: "SaleStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_GroupRole_GroupRoleId",
                table: "AspNetRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Area_AreaId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_AspNetUsers_UserId",
                table: "UserPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_Permission_PermissionId",
                table: "UserPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Distributor_SaleStaff_SaleManagementIdId",
                table: "Distributor");

            migrationBuilder.DropTable(
                name: "ImplementationDate");

            migrationBuilder.DropTable(
                name: "JobForVisitation");

            migrationBuilder.DropTable(
                name: "VisitCalendarDistributor");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "VisitCalendar");

            migrationBuilder.DropTable(
                name: "SaleStaff");

            migrationBuilder.DropTable(
                name: "Distributor");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AreaId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPermissions",
                table: "UserPermissions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "009f42a1-fe16-4293-8e7a-abaf4e288e5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "464a56d5-aa95-4f58-9a10-1869e488d403");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53b61fc1-5d29-42a1-8acc-ad5e18c3cb1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7993ec28-e8ad-4275-8b59-633979c25ca1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f8cfc09-46be-41e5-bcf7-18abb6fe6a3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8853fb00-5075-4b63-b91e-953fb8ead8b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c402e7d-7676-4082-8ac6-77e3c43e7e2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afb28b3e-0041-4b12-9554-c2b58ff66cd2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7a4ba95-2ee3-41ff-b321-6fe2ebb87562");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcc22d99-4021-465a-b139-4c23e0a6d004");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f16de8db-1802-4222-a6a8-b1bc7544fb34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb71c2e3-11b5-4530-9dc2-743e062d6a15");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "UserPermissions",
                newName: "UserPermission");

            migrationBuilder.RenameIndex(
                name: "IX_UserPermissions_PermissionId",
                table: "UserPermission",
                newName: "IX_UserPermission_PermissionId");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroupRoleId",
                table: "AspNetRoles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPermission",
                table: "UserPermission",
                columns: new[] { "UserId", "PermissionId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04254319-bd83-4ae0-ab15-e668d8ec2d60", "a4c22144-5db8-4283-810e-bc12443a4bfb", "Role", 2, "BM", "BM" },
                    { "08635918-20b8-40d9-8a32-687bffab632c", "7da8f71f-b67f-4634-a2fc-51bd39bd154c", "Role", 1, "Owner", "OWNER" },
                    { "1398f135-30a4-4312-a83c-893bca742d2e", "290b3856-c605-478a-b34e-070b17cf72a3", "Role", 3, "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "4f684f94-d893-4928-8756-563fc1b012db", "0435b00f-39fc-4356-9ebc-e974d269bc3b", "Role", 4, "Guest", "GUEST" },
                    { "7bf3818c-0c6d-4967-b8ed-e59f234f6df4", "9ba66be1-b5b7-47d0-85b1-ee7e16684fd4", "Role", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "9401aa7c-11ad-4a83-a905-214e6e18e041", "5e42e06a-e318-467e-9666-0ede9e7bc379", "Role", 2, "BAM", "BAM" },
                    { "b0a34ef7-39f5-40a2-8b0c-535c428fcab4", "9df06dd6-f7bc-4554-a4ad-0b79b50eedf3", "Role", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "bba507ea-8af0-42e4-b5c3-0e845c1092be", "1664c1e2-1025-4b88-9a67-4ad9887c9b65", "Role", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "bba6d57f-58c5-48fc-975d-6194f94c092d", "ddda53a4-66b7-4513-8429-fa193e922c7f", "Role", 2, "VPCD", "VPCD" },
                    { "cf10eda2-ec57-448c-8efc-060e9d8b3c4c", "a0b6fe6b-7c85-4949-aefe-4df08292a6a2", "Role", 1, "Administrator", "ADMINISTRATOR" },
                    { "d795568c-c96c-4c9d-a72a-fdfa4ef9ea04", "e197449d-52d6-434d-affa-d0c10b09eb23", "Role", 2, "ASM", "ASM" },
                    { "ff9447e2-44af-4af4-ab0f-58624c59d666", "d35de113-6d07-4cf6-9bae-227f5e2540f4", "Role", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_GroupRole_GroupRoleId",
                table: "AspNetRoles",
                column: "GroupRoleId",
                principalTable: "GroupRole",
                principalColumn: "GroupRoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermission_AspNetUsers_UserId",
                table: "UserPermission",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermission_Permission_PermissionId",
                table: "UserPermission",
                column: "PermissionId",
                principalTable: "Permission",
                principalColumn: "PermissionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
