using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpdateSaleStaffAndDistributor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c4c1433-a4b2-4a74-9914-4671270b554d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f829664-8427-4785-b56d-2033a6244ee1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bcc5a8a-be60-4d3c-8492-37086158160f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cfa4316-941b-4f88-8853-53334dcb7c51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f9ae651-c7f6-4dba-963b-03bee2b3877a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ff59d00-1a4c-4eea-98ba-fb83f501aa78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76d6822d-9716-4ae9-bacd-937a960a869e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8696e5ba-357d-4dd3-b966-c1f7c9106633");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f910f9e-3a78-4fe7-96b4-57d0ea50c2ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96b3cce0-089c-489a-85fb-2282c37c4e38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b42ed5c8-1d55-4c83-8132-4e847e3afe8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b55e0c63-ad66-45bc-8e2c-8180e5875474");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c4c1433-a4b2-4a74-9914-4671270b554d", "2ba6d6e7-518a-4503-a32c-9c20b47d2f32", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "0f829664-8427-4785-b56d-2033a6244ee1", "132e8b1b-2d9b-41ca-8991-5e397585cd92", 2, "BAM", "BAM" },
                    { "1bcc5a8a-be60-4d3c-8492-37086158160f", "41673641-9f2e-4021-920b-57937018a17c", 2, "BM", "BM" },
                    { "4cfa4316-941b-4f88-8853-53334dcb7c51", "4aa92ecc-c307-4575-9abc-c95140f1a511", 4, "Guest", "GUEST" },
                    { "5f9ae651-c7f6-4dba-963b-03bee2b3877a", "89f6e865-c9c7-47d4-871e-9eb7c9b5aa71", 1, "Administrator", "ADMINISTRATOR" },
                    { "5ff59d00-1a4c-4eea-98ba-fb83f501aa78", "e031d34a-99d8-4ab6-967a-db897aa6d455", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "76d6822d-9716-4ae9-bacd-937a960a869e", "e73602b3-48c7-4314-8718-24dd0e6a44a8", 2, "ASM", "ASM" },
                    { "8696e5ba-357d-4dd3-b966-c1f7c9106633", "8267ffb0-ca8c-4e03-99d5-64bb850a3dfd", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "8f910f9e-3a78-4fe7-96b4-57d0ea50c2ff", "d23c873b-dcf8-4a67-82de-4715a3c1b258", 2, "VPCD", "VPCD" },
                    { "96b3cce0-089c-489a-85fb-2282c37c4e38", "daeb1ff0-10b3-45ed-9f76-e6ddd3eca6e1", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "b42ed5c8-1d55-4c83-8132-4e847e3afe8b", "94fe590d-2934-42ae-95b8-697bac1df228", 1, "Owner", "OWNER" },
                    { "b55e0c63-ad66-45bc-8e2c-8180e5875474", "3e936f91-c528-4b81-b4a7-cf4d22650e7a", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" }
                });
        }
    }
}
