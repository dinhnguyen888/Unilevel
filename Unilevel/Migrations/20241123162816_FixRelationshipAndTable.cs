using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class FixRelationshipAndTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distributor_SaleStaff_SaleManagementIdId",
                table: "Distributor");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleStaff_Distributor_DistributorId",
                table: "SaleStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleStaff_SaleStaff_SaleStaffId",
                table: "SaleStaff");

            migrationBuilder.DropIndex(
                name: "IX_SaleStaff_DistributorId",
                table: "SaleStaff");

            migrationBuilder.DropIndex(
                name: "IX_SaleStaff_SaleStaffId",
                table: "SaleStaff");

            migrationBuilder.DropIndex(
                name: "IX_Distributor_SaleManagementIdId",
                table: "Distributor");

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
                name: "DistributorId",
                table: "SaleStaff");

            migrationBuilder.DropColumn(
                name: "SaleStaffId",
                table: "SaleStaff");

            migrationBuilder.DropColumn(
                name: "SaleManagementIdId",
                table: "Distributor");

            migrationBuilder.AlterColumn<string>(
                name: "SuperiorId",
                table: "SaleStaff",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitCalendarId",
                table: "JobForVisitation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SaleManagementId",
                table: "Distributor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SaleDistributor",
                columns: table => new
                {
                    SaleStaffId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DistributorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDistributor", x => new { x.DistributorId, x.SaleStaffId });
                    table.ForeignKey(
                        name: "FK_SaleDistributor_Distributor_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Distributor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleDistributor_SaleStaff_SaleStaffId",
                        column: x => x.SaleStaffId,
                        principalTable: "SaleStaff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "094e325e-1a24-4964-89be-3e7cee5210cc", "b7275db5-ecad-49fe-a5a9-a28a3a81f587", 1, "Administrator", "ADMINISTRATOR" },
                    { "0e0b3bae-1e09-4b52-b94f-6edb27abd631", "87666c78-3cc3-407b-9c00-3cc3e224ab13", 2, "BAM", "BAM" },
                    { "1e13e8fd-bb3a-4116-9bdc-f07e60e30531", "dedc074a-7248-4455-a8ad-8ef33484018a", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "84122ddd-6ab0-40c2-b336-d8b4f205a608", "b2f3e912-25cf-4de5-915d-f2fcc121b88a", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "8833cbda-f28f-4d7b-9b91-38a0cf951dad", "541a256c-0891-4eca-b546-431883abe689", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "996422b9-f1e3-406c-847c-440d8f3c2fce", "d9f8beac-f10d-430a-b2ba-f05e6b59c8c5", 3, "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "b80bf342-fb0f-48e2-acdf-bce5df231caa", "0d71323c-d805-4916-a0f0-b75176688b53", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "bd5cf9a8-aabe-4252-856b-7741c585e905", "71d10ee7-621b-45ba-93bd-62aa28a5e929", 1, "Owner", "OWNER" },
                    { "cea15af0-0b8a-4b73-b9cb-c3e6dc0c6cd1", "95dca7e0-286c-413c-ae08-400c19f0300f", 2, "VPCD", "VPCD" },
                    { "cf1ebd83-1b92-45b2-98ef-638fa7700595", "41bd0fd6-c447-4893-a3ea-0b656af2bd59", 2, "BM", "BM" },
                    { "e33ff889-827c-4f35-b0f5-5096ea283b44", "57fd4fdf-f3eb-4571-9dd9-816f9664de9d", 2, "ASM", "ASM" },
                    { "e38c6d69-2051-495a-a1c4-b1241301f84c", "9036e4df-3c0d-4fca-a330-435609216870", 4, "Guest", "GUEST" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleStaff_SuperiorId",
                table: "SaleStaff",
                column: "SuperiorId");

            migrationBuilder.CreateIndex(
                name: "IX_JobForVisitation_VisitCalendarId",
                table: "JobForVisitation",
                column: "VisitCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDistributor_SaleStaffId",
                table: "SaleDistributor",
                column: "SaleStaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobForVisitation_VisitCalendar_VisitCalendarId",
                table: "JobForVisitation",
                column: "VisitCalendarId",
                principalTable: "VisitCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleStaff_SaleStaff_SuperiorId",
                table: "SaleStaff",
                column: "SuperiorId",
                principalTable: "SaleStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobForVisitation_VisitCalendar_VisitCalendarId",
                table: "JobForVisitation");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleStaff_SaleStaff_SuperiorId",
                table: "SaleStaff");

            migrationBuilder.DropTable(
                name: "SaleDistributor");

            migrationBuilder.DropIndex(
                name: "IX_SaleStaff_SuperiorId",
                table: "SaleStaff");

            migrationBuilder.DropIndex(
                name: "IX_JobForVisitation_VisitCalendarId",
                table: "JobForVisitation");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094e325e-1a24-4964-89be-3e7cee5210cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e0b3bae-1e09-4b52-b94f-6edb27abd631");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e13e8fd-bb3a-4116-9bdc-f07e60e30531");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84122ddd-6ab0-40c2-b336-d8b4f205a608");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8833cbda-f28f-4d7b-9b91-38a0cf951dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "996422b9-f1e3-406c-847c-440d8f3c2fce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b80bf342-fb0f-48e2-acdf-bce5df231caa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd5cf9a8-aabe-4252-856b-7741c585e905");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cea15af0-0b8a-4b73-b9cb-c3e6dc0c6cd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf1ebd83-1b92-45b2-98ef-638fa7700595");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e33ff889-827c-4f35-b0f5-5096ea283b44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e38c6d69-2051-495a-a1c4-b1241301f84c");

            migrationBuilder.DropColumn(
                name: "VisitCalendarId",
                table: "JobForVisitation");

            migrationBuilder.DropColumn(
                name: "SaleManagementId",
                table: "Distributor");

            migrationBuilder.AlterColumn<string>(
                name: "SuperiorId",
                table: "SaleStaff",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistributorId",
                table: "SaleStaff",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleStaffId",
                table: "SaleStaff",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleManagementIdId",
                table: "Distributor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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
                name: "IX_SaleStaff_DistributorId",
                table: "SaleStaff",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleStaff_SaleStaffId",
                table: "SaleStaff",
                column: "SaleStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Distributor_SaleManagementIdId",
                table: "Distributor",
                column: "SaleManagementIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Distributor_SaleStaff_SaleManagementIdId",
                table: "Distributor",
                column: "SaleManagementIdId",
                principalTable: "SaleStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleStaff_Distributor_DistributorId",
                table: "SaleStaff",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleStaff_SaleStaff_SaleStaffId",
                table: "SaleStaff",
                column: "SaleStaffId",
                principalTable: "SaleStaff",
                principalColumn: "Id");
        }
    }
}
