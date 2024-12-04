using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpdateNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26e4cf16-402c-478a-8604-30d7b88bbaed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "283e4bbb-8483-4a2a-8aea-35018cf5ad85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6122d876-4a2d-4217-9fdc-e53a1fa4e075");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6acd9f17-e8dc-4747-ad02-244bd9d3fa39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94fb6f71-a129-4981-b765-bf5f1dead7fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3c9c156-e98a-41c2-82d4-ab3cda984310");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab4ec0dc-28c7-42b7-bb8d-7351aa96a050");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5a3ad3f-b85e-4ba8-a811-f48b07943ce6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bff23f4d-8b98-4c9f-9e4b-bfc4327f9129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029a46c-603e-4601-a770-9e256b07544f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db45bab5-53eb-4442-acc2-429e6f4a119e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7a2b022-4566-4c7d-9f25-f4d5a448e057");

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotifyReceiver",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifyReceiver", x => new { x.UserId, x.NotificationId });
                    table.ForeignKey(
                        name: "FK_NotifyReceiver_Notification_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1098fef0-0723-4212-896d-cba46228b647", "39d2b24a-7e30-4310-97c5-3a50100c4980", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "1c3fb295-13bd-471d-9fe0-be11648b424c", "839ad63e-35b3-425a-9cb4-f5098ee8af13", 2, "VPCD", "VPCD" },
                    { "4c015285-99b8-4a08-8e2c-29ed5e6c420a", "9183490d-1966-468a-9e08-f449dda4e6db", 4, "Guest", "GUEST" },
                    { "4f088d95-2da1-41b8-a0ff-5f4304b1de16", "4fa01490-4814-4497-9eb1-f0b7f4297038", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "523ad9ab-aee3-453e-949b-96928f3abf40", "d0092741-9893-49be-91fd-f63ba1fa44ca", 2, "ASM", "ASM" },
                    { "62a4e202-f18f-4000-9bf6-194938d39756", "4ce3a598-51a1-4b5a-a689-00fad12c36d4", 1, "Administrator", "ADMINISTRATOR" },
                    { "7c218f8f-e84d-41af-ae15-40be02f5ec23", "0227cc75-37b8-47cf-af2a-03bce8cba56f", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "86dc7a39-b728-4b92-8996-397c70b4d29f", "919ff929-13fc-4c1c-ad39-4f192f53a4ff", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "a15bbef0-be88-4bb3-a815-383194fde1fb", "03c64872-ef75-498d-8ff4-7daf67c5c659", 1, "Owner", "OWNER" },
                    { "b30bdacd-730b-47ea-8bd1-5d02d4ef5c76", "7d1c1e19-be50-4f53-a019-5ffb19f3db5f", 2, "BAM", "BAM" },
                    { "b9074028-9015-418b-9a86-88b81464bb13", "7748a8a8-75c8-46f5-82aa-aaf6d9db36c5", 2, "BM", "BM" },
                    { "e37d1881-118c-433f-adaf-a777e91bf3f7", "b733c731-beaa-4a3d-859d-ebf7d766f265", 4, "OtherDepartment", "OTHER DEPARTMENT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotifyReceiver_NotificationId",
                table: "NotifyReceiver",
                column: "NotificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotifyReceiver");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1098fef0-0723-4212-896d-cba46228b647");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c3fb295-13bd-471d-9fe0-be11648b424c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c015285-99b8-4a08-8e2c-29ed5e6c420a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f088d95-2da1-41b8-a0ff-5f4304b1de16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523ad9ab-aee3-453e-949b-96928f3abf40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62a4e202-f18f-4000-9bf6-194938d39756");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c218f8f-e84d-41af-ae15-40be02f5ec23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86dc7a39-b728-4b92-8996-397c70b4d29f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a15bbef0-be88-4bb3-a815-383194fde1fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b30bdacd-730b-47ea-8bd1-5d02d4ef5c76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9074028-9015-418b-9a86-88b81464bb13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e37d1881-118c-433f-adaf-a777e91bf3f7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26e4cf16-402c-478a-8604-30d7b88bbaed", "aa85b59d-893e-4cd1-b3bf-b3b6600749ac", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "283e4bbb-8483-4a2a-8aea-35018cf5ad85", "dd66cc0a-86d5-44e2-97f7-03ba7bafa0e7", 2, "VPCD", "VPCD" },
                    { "6122d876-4a2d-4217-9fdc-e53a1fa4e075", "96364b36-172b-4cf5-a459-2270aef2dbf1", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "6acd9f17-e8dc-4747-ad02-244bd9d3fa39", "1701bb98-b54f-42dc-b1ca-e6121e8f7218", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "94fb6f71-a129-4981-b765-bf5f1dead7fa", "6e15fac4-6de6-46c1-ba9b-f0ec0f9560ca", 2, "BAM", "BAM" },
                    { "a3c9c156-e98a-41c2-82d4-ab3cda984310", "d0144df8-4775-4d55-a8b7-c4385939525c", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "ab4ec0dc-28c7-42b7-bb8d-7351aa96a050", "f1dd5cba-3fba-4e73-842d-b929d311eec9", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "b5a3ad3f-b85e-4ba8-a811-f48b07943ce6", "a8973944-b0f1-4a12-81ef-c8870a7804a8", 1, "Administrator", "ADMINISTRATOR" },
                    { "bff23f4d-8b98-4c9f-9e4b-bfc4327f9129", "e6d0682b-871a-4c51-bd2f-851f97d9c8da", 2, "BM", "BM" },
                    { "c029a46c-603e-4601-a770-9e256b07544f", "124663a2-bc18-44ef-9ee8-28003e81579a", 2, "ASM", "ASM" },
                    { "db45bab5-53eb-4442-acc2-429e6f4a119e", "86f90750-8e0f-4dc0-89a9-d32602ceed91", 4, "Guest", "GUEST" },
                    { "f7a2b022-4566-4c7d-9f25-f4d5a448e057", "278b003f-8e02-4c75-b8d5-8637bc4602a4", 1, "Owner", "OWNER" }
                });
        }
    }
}
