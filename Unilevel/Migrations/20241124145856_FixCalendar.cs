using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class FixCalendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitCalendarDistributor");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09f4982c-d1d9-4bd3-bb92-194aabba1b1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fe7fe74-a829-48b9-8f66-a526308baddf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a9f1aaa-04d3-4790-8eb3-433b404179aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26f2adec-ba8c-4cb3-8ff3-24def26381ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32cd993f-a014-4067-a400-370990e38892");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ec2ea6f-ab5e-4199-ac82-6eab0669a847");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55d682b3-4f8c-494d-8d35-954ffa7e1ab2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "802205ec-88fd-49a4-8ad0-3b44c80832da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a001a85-6df6-4a7e-9c6b-ae25f963c359");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab3866f-1343-4336-9fbd-5f25ca4fcb13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce5101cf-baa5-4b7f-9c85-8a3d86f4a034");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea1611bd-136b-4656-b980-784307e2e0fa");

            migrationBuilder.AlterColumn<string>(
                name: "ImplementationTime",
                table: "VisitCalendar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DistributorId",
                table: "VisitCalendar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08e5eeed-42ef-4524-ae08-46bea02626bf", "adcf057f-ee5b-4ca5-b450-d94ae3886211", 2, "ASM", "ASM" },
                    { "3f1f9fe0-5a9e-458f-939c-d6e275b934fa", "1b8ff8ae-8517-4f2d-9977-7add6040179f", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "50e1ce95-89ea-4df6-9d93-724d7df4b8a3", "ba79620f-07fb-4f2f-aee0-89ecb55f1701", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "5265a80b-ffc5-451e-b532-6aa38ecf14b4", "d063776a-6808-4004-8e71-65315890e089", 2, "BM", "BM" },
                    { "7a67daf6-aae8-4fd4-a807-ab9939d95a9b", "83695d2c-42b6-488a-832c-03d7b9680bdc", 2, "BAM", "BAM" },
                    { "7f13c7cf-8092-44d2-872a-518475a37af5", "cf573150-aeac-417c-b1df-85132c0fcdf3", 4, "Guest", "GUEST" },
                    { "8d73a2b6-0cb2-4858-8fa0-72693b44f9ec", "a7ffa22d-e7fc-4770-b22a-3e05ee77ba3c", 1, "Administrator", "ADMINISTRATOR" },
                    { "9d1c2d8e-fa23-484b-b053-8889d5e4577a", "e51fc4b1-2c39-4bd4-af63-0a9879a71b0e", 2, "VPCD", "VPCD" },
                    { "abd0f2c6-5a2a-409e-ac6f-0cf5cf30062b", "19fbea32-a2c9-412f-8b73-d296a5384029", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "bb938050-b0d9-4b62-af5c-2d33e4765262", "70f416c5-b7a0-46b3-9ad4-482d2ed99bc6", 3, "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "c3f79afa-019c-4516-a02f-a413ab296abd", "fbdc12b3-142c-4e79-880e-2038f3d3b6b9", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "f08cf211-45cf-4d6d-88cf-252ccb39bfbd", "d8d630a6-c805-4be2-9bc7-9726d8922c76", 1, "Owner", "OWNER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisitCalendar_DistributorId",
                table: "VisitCalendar",
                column: "DistributorId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitCalendar_Distributor_DistributorId",
                table: "VisitCalendar",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitCalendar_Distributor_DistributorId",
                table: "VisitCalendar");

            migrationBuilder.DropIndex(
                name: "IX_VisitCalendar_DistributorId",
                table: "VisitCalendar");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e5eeed-42ef-4524-ae08-46bea02626bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f1f9fe0-5a9e-458f-939c-d6e275b934fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50e1ce95-89ea-4df6-9d93-724d7df4b8a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5265a80b-ffc5-451e-b532-6aa38ecf14b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a67daf6-aae8-4fd4-a807-ab9939d95a9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f13c7cf-8092-44d2-872a-518475a37af5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d73a2b6-0cb2-4858-8fa0-72693b44f9ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d1c2d8e-fa23-484b-b053-8889d5e4577a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abd0f2c6-5a2a-409e-ac6f-0cf5cf30062b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb938050-b0d9-4b62-af5c-2d33e4765262");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f79afa-019c-4516-a02f-a413ab296abd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f08cf211-45cf-4d6d-88cf-252ccb39bfbd");

            migrationBuilder.DropColumn(
                name: "DistributorId",
                table: "VisitCalendar");

            migrationBuilder.AlterColumn<int>(
                name: "ImplementationTime",
                table: "VisitCalendar",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                    { "09f4982c-d1d9-4bd3-bb92-194aabba1b1e", "37481524-4cd1-4292-872f-37788ad2b5e9", 3, "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "0fe7fe74-a829-48b9-8f66-a526308baddf", "af390c3d-7c2a-4e3a-b58d-6d9f5612179e", 1, "Administrator", "ADMINISTRATOR" },
                    { "1a9f1aaa-04d3-4790-8eb3-433b404179aa", "9dcd51e6-b1a8-48d8-a70c-ffe9e4c01392", 1, "Owner", "OWNER" },
                    { "26f2adec-ba8c-4cb3-8ff3-24def26381ca", "8350d66b-8281-4751-a4e9-bfe057517be3", 2, "BM", "BM" },
                    { "32cd993f-a014-4067-a400-370990e38892", "4f33bea3-77b8-4f0b-8ef1-ddb93c51463c", 2, "ASM", "ASM" },
                    { "3ec2ea6f-ab5e-4199-ac82-6eab0669a847", "7d1ece1b-d10b-4a28-987e-353d143af6f9", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "55d682b3-4f8c-494d-8d35-954ffa7e1ab2", "82cfdb0a-1bbc-48ea-a2df-09ea09cc88c7", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "802205ec-88fd-49a4-8ad0-3b44c80832da", "70392211-09b1-4b8b-bcb7-83e072e47e44", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "8a001a85-6df6-4a7e-9c6b-ae25f963c359", "9e4120d1-ac24-415e-898b-f5f28365ba68", 2, "BAM", "BAM" },
                    { "bab3866f-1343-4336-9fbd-5f25ca4fcb13", "8023fd1d-ed7c-4944-a276-d345c353f689", 4, "Guest", "GUEST" },
                    { "ce5101cf-baa5-4b7f-9c85-8a3d86f4a034", "82cbdae4-50db-4a02-b330-5dc34ed45d50", 2, "VPCD", "VPCD" },
                    { "ea1611bd-136b-4656-b980-784307e2e0fa", "305310ed-d0c3-4897-9f13-84f336717c69", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisitCalendarDistributor_DistributorId",
                table: "VisitCalendarDistributor",
                column: "DistributorId");
        }
    }
}
