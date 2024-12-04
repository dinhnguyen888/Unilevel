using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                table: "SaleStaff",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1de05086-75f2-481a-9720-b32d0feb34d6", "955d6aa9-cf75-45c0-8657-a388563f8421", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "2bac841d-f2ad-44e8-b5f8-179b30c5d191", "c2889cec-c649-46ac-baa7-4160ed0c62c2", 4, "Guest", "GUEST" },
                    { "3a9f6c08-4644-48d6-affc-041a93476fc4", "2de1966f-34a6-42a3-925d-e88dbbcc3d64", 1, "Administrator", "ADMINISTRATOR" },
                    { "404b9b70-2688-4641-bcf5-86f4e2dc71ff", "9052d320-0be0-45b1-84df-70a1f3814b24", 2, "BAM", "BAM" },
                    { "43fcbc55-62f6-4a6f-b5e3-f022d3a786af", "f3d9181e-8329-4b35-94c8-0874ef38102b", 1, "Owner", "OWNER" },
                    { "69257004-2ce1-49d2-9c55-06448658946d", "a649fcb8-34f0-4f8c-b126-539b41167fcf", 2, "VPCD", "VPCD" },
                    { "86e9eb6c-2448-4469-bab7-dca03c15656f", "70d8d824-5e35-46cf-807d-d271d99d0991", 2, "ASM", "ASM" },
                    { "9db239e1-53c1-4006-9dbb-1f1801e8f722", "d7ddc588-e2bc-45da-a5a4-efdd72b7e096", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "a20d4863-29f7-44ff-b25a-f187728263e0", "6e1fb461-1e4d-45d0-9772-4ac9086db5d8", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "b1005c22-2911-448a-9812-f0fefa7c774e", "240c8f99-f299-4b06-ad34-8bbd6f7deb31", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "d4d5594d-57e7-4206-a783-32bf35340ab1", "3016db24-bd69-4173-af1f-da3319379956", 2, "BM", "BM" },
                    { "f3b06b85-f565-4cbe-821e-d25fde97a530", "9dc4d723-3c68-431f-b8f4-d99bcac953fd", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1de05086-75f2-481a-9720-b32d0feb34d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bac841d-f2ad-44e8-b5f8-179b30c5d191");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a9f6c08-4644-48d6-affc-041a93476fc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "404b9b70-2688-4641-bcf5-86f4e2dc71ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43fcbc55-62f6-4a6f-b5e3-f022d3a786af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69257004-2ce1-49d2-9c55-06448658946d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86e9eb6c-2448-4469-bab7-dca03c15656f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9db239e1-53c1-4006-9dbb-1f1801e8f722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a20d4863-29f7-44ff-b25a-f187728263e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1005c22-2911-448a-9812-f0fefa7c774e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4d5594d-57e7-4206-a783-32bf35340ab1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3b06b85-f565-4cbe-821e-d25fde97a530");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                table: "SaleStaff",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
