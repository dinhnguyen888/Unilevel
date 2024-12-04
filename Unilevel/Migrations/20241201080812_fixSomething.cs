using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class fixSomething : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleStaff_SaleStaff_SuperiorId",
                table: "SaleStaff");

            migrationBuilder.DropIndex(
                name: "IX_SaleStaff_SuperiorId",
                table: "SaleStaff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00e3858e-e285-47dc-bda7-7fbbbb60e3ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03209c93-41ea-4d7a-a16e-2a822f9b06f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19d0dd72-85c0-4a4b-a3e9-a0ae34f4fdc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc413e7-ae63-45c3-a796-e4bcef5f89e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26a1b693-bea1-4dee-9ee0-42a1975be4a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88ba39a3-2b98-4274-8b04-8a6cd9a14e70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96185493-b5ce-439f-a88c-98d9ca4f5224");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae27b93f-c6ef-47ca-8ac3-160c8ffb0fbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aff65079-8b04-4865-8482-9a22bfbb598e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be09425d-91b9-4a64-9b5e-2bfee35760c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c513521f-9246-4d6f-9fd1-99fe9ec08bd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8a26f3d-75d5-4084-acd9-5053ef29570f");

            migrationBuilder.DropColumn(
                name: "SuperiorId",
                table: "SaleStaff");

            migrationBuilder.AddColumn<string>(
                name: "ManagerId",
                table: "SaleStaff",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15cb3fb3-454a-4810-99e7-d125ecfe7a78", "9a446dcf-6217-451f-86d6-c24f6fde250e", 2, "BM", "BM" },
                    { "2176c1ea-536b-4761-8ba5-ba49780bf3d2", "d4ab2a0a-a2c9-4009-90e4-c0a18257de5a", 4, "Guest", "GUEST" },
                    { "36723cae-7b7d-4758-8676-2d55df5e4ffa", "27e18e22-35fc-442f-99a6-01ca207b68a4", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "5790efdd-fdbd-41f5-9767-44263c589dd8", "d160d201-0c21-494a-86ae-49287c7cc76f", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "5dc4641b-0268-4670-87e5-04aa7db716e7", "afca3e99-e010-4797-a3f1-3c33b892b6a6", 2, "ASM", "ASM" },
                    { "72317f3f-5d5e-4311-816f-281d53d4070a", "b62a0f77-9623-497c-aced-e60d6948f9a4", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "9eac5a62-2bbb-4496-8735-813a40b73e92", "8440827b-b89c-40c0-bebf-6943fedd2d76", 2, "VPCD", "VPCD" },
                    { "caa8f5da-16ae-40bd-ad7f-056d2a8e3888", "f190f3ba-6fec-4173-9c2d-061f3e251df9", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "cfc93bc2-433a-484b-a297-350318a8c12a", "97f93ca9-9f65-4680-b22e-95bb9822a772", 1, "Administrator", "ADMINISTRATOR" },
                    { "d9f42387-0e28-4457-9f80-36a688d9cdc8", "cec2f83a-be9f-44df-a275-1c866b76a2e7", 1, "Owner", "OWNER" },
                    { "e27b4a54-2d10-4f09-b2e0-3c6704389807", "4e4247e5-0c67-40de-9f24-af6b4f22702e", 2, "BAM", "BAM" },
                    { "e3b307e0-e720-4c6e-9d24-8205694a90c6", "2f582d4d-0fa1-48b2-98e8-b85d172f1861", 4, "OtherDepartment", "OTHER DEPARTMENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15cb3fb3-454a-4810-99e7-d125ecfe7a78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2176c1ea-536b-4761-8ba5-ba49780bf3d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36723cae-7b7d-4758-8676-2d55df5e4ffa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5790efdd-fdbd-41f5-9767-44263c589dd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dc4641b-0268-4670-87e5-04aa7db716e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72317f3f-5d5e-4311-816f-281d53d4070a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eac5a62-2bbb-4496-8735-813a40b73e92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caa8f5da-16ae-40bd-ad7f-056d2a8e3888");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfc93bc2-433a-484b-a297-350318a8c12a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9f42387-0e28-4457-9f80-36a688d9cdc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e27b4a54-2d10-4f09-b2e0-3c6704389807");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3b307e0-e720-4c6e-9d24-8205694a90c6");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "SaleStaff");

            migrationBuilder.AddColumn<string>(
                name: "SuperiorId",
                table: "SaleStaff",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00e3858e-e285-47dc-bda7-7fbbbb60e3ba", "eb8904cb-2b72-4ad3-ae64-2487ea96fded", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "03209c93-41ea-4d7a-a16e-2a822f9b06f6", "ce6d3356-e680-41f0-96f8-2588a57460f9", 2, "BM", "BM" },
                    { "19d0dd72-85c0-4a4b-a3e9-a0ae34f4fdc7", "bf6e63dc-c9a8-4902-828c-a9914716dadf", 1, "Owner", "OWNER" },
                    { "1dc413e7-ae63-45c3-a796-e4bcef5f89e0", "74342dd4-7cab-4d85-9c25-a9e6fde92cbf", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "26a1b693-bea1-4dee-9ee0-42a1975be4a5", "38dca20c-6c18-41f9-b324-d56682a1ad33", 2, "BAM", "BAM" },
                    { "88ba39a3-2b98-4274-8b04-8a6cd9a14e70", "cde26c41-b2d0-4242-80a3-16d1603adcd1", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "96185493-b5ce-439f-a88c-98d9ca4f5224", "fdf0198f-983e-42dd-b33e-87130fd49dce", 1, "Administrator", "ADMINISTRATOR" },
                    { "ae27b93f-c6ef-47ca-8ac3-160c8ffb0fbe", "8a691668-33a4-4930-99a0-f95509cedb0e", 4, "Guest", "GUEST" },
                    { "aff65079-8b04-4865-8482-9a22bfbb598e", "b4f4c082-93be-416f-9656-d0ec6673a6b8", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "be09425d-91b9-4a64-9b5e-2bfee35760c9", "cd1b8f73-cc35-4b20-9ed6-51787a6820b3", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "c513521f-9246-4d6f-9fd1-99fe9ec08bd3", "3bb31ef6-5d78-4fc6-b006-e2c210d50fce", 2, "ASM", "ASM" },
                    { "f8a26f3d-75d5-4084-acd9-5053ef29570f", "f38bafa4-a848-4720-9726-acc4d920d65b", 2, "VPCD", "VPCD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleStaff_SuperiorId",
                table: "SaleStaff",
                column: "SuperiorId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleStaff_SaleStaff_SuperiorId",
                table: "SaleStaff",
                column: "SuperiorId",
                principalTable: "SaleStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
