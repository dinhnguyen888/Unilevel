using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class FixRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0216f606-dcdc-48b6-b02e-ef2783bc028b", "8f03d6ae-a99f-49c7-9e74-f6dbd64b8120", 2, "ASM", "ASM" },
                    { "0cc8be55-a731-40ba-a593-d6d55ce4c713", "c0b57927-6049-4e17-9187-1526b5f1def8", 1, "Administrator", "ADMINISTRATOR" },
                    { "2452f72d-8ba0-4b0e-9f16-91b2407e06fd", "2a964ab7-1b94-49b1-967d-51c24a577428", 1, "Owner", "OWNER" },
                    { "31a983d7-4a28-4f57-8645-0b8965798f27", "a646f287-e989-486f-ab35-b06b59ec1e38", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "515ce12e-9b2b-4a7d-b506-bd184afc1467", "21fb3a87-86fa-4551-b640-c3fcf9ff9d6c", 2, "VPCD", "VPCD" },
                    { "723e87cf-101b-4d74-a083-91bc1ea0df5a", "65db8904-b9c5-4db0-824d-bc961a8eb208", 2, "BM", "BM" },
                    { "83ca2987-81a0-47d3-9897-84e6bd7d37fd", "93fff0f1-30ec-4e4d-a39d-750b1219e1db", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "8cd0ebcb-8a4e-4908-99aa-7759dc8d77f5", "f3c29b8d-9abe-4a46-a07e-4a7f1409aac8", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "a0064caf-a8b7-47a7-b40a-d53a005446ff", "e7e49a48-81f8-45ce-9f10-8bb5ce71b999", 3, "Distributor", "DISTRIBUTOR - OM/TL" },
                    { "c20173db-c7e4-4bca-b893-92299797de32", "0ddaa760-9244-4161-ba2b-34402e03523e", 2, "BAM", "BAM" },
                    { "c368078e-5117-4f4f-969c-6cb3f51f651b", "31be52ad-ebdd-454e-bd01-ee6eace5bd4a", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "ee2e2e8d-7e63-4d7a-a232-3b44659cd8b1", "20e76b6d-5f30-4a2f-9472-7a4032aac613", 4, "Guest", "GUEST" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0216f606-dcdc-48b6-b02e-ef2783bc028b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cc8be55-a731-40ba-a593-d6d55ce4c713");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2452f72d-8ba0-4b0e-9f16-91b2407e06fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31a983d7-4a28-4f57-8645-0b8965798f27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "515ce12e-9b2b-4a7d-b506-bd184afc1467");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "723e87cf-101b-4d74-a083-91bc1ea0df5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83ca2987-81a0-47d3-9897-84e6bd7d37fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cd0ebcb-8a4e-4908-99aa-7759dc8d77f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0064caf-a8b7-47a7-b40a-d53a005446ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c20173db-c7e4-4bca-b893-92299797de32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c368078e-5117-4f4f-969c-6cb3f51f651b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee2e2e8d-7e63-4d7a-a232-3b44659cd8b1");

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
        }
    }
}
