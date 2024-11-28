using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class FixRole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "131054ad-27e7-47a6-86cd-dd007dad0156", "d915faf4-bc91-4f51-901a-75766b5ba520", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "21d78134-1a58-497c-9d24-c1c2593ef286", "bfdb78e1-4f04-484b-bbd7-5377e2953daa", 2, "BAM", "BAM" },
                    { "285d59d5-e950-4918-9c35-b8652159540f", "1839dd16-ae62-4290-a2c6-f410415c8c9b", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "40833baa-c429-4c21-9ab3-1c09bef4d0bc", "68f8ac62-7465-49a0-b9d6-8237e4226777", 2, "VPCD", "VPCD" },
                    { "68d144fd-a5bc-4242-8a7c-ee3bdd08180b", "a5a18e08-1fbc-4cee-8240-e67fc0608428", 1, "Owner", "OWNER" },
                    { "88adc9f7-f197-4d89-bc21-e95fb7f7768a", "0168e8ff-8710-4fc7-a75b-4c3052f9d621", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "907ce44d-7248-472f-81be-171e4ca628e1", "a8cf1598-5b88-4d0a-87f4-04eff52e27a6", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "957ec248-2d7d-46f5-b24e-70f66ee66a59", "7ac489ca-c1de-497d-b3eb-1ad895b6a36e", 2, "ASM", "ASM" },
                    { "c1cb1076-0402-4c84-827e-9e53c9d25eaa", "1a3e8ad5-cabb-4cbf-95d4-9aa556369d9c", 4, "Guest", "GUEST" },
                    { "d04f4cfb-2b1e-4b2a-b6b6-ef1de1519495", "b4726e60-feaf-418a-858d-2cd033be32eb", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "e1e1be96-7dee-4bd3-a625-d583783170ed", "813770ab-1470-434c-b705-6b48ed511d54", 1, "Administrator", "ADMINISTRATOR" },
                    { "e5e6d8e8-b368-432c-b552-96f7151f434b", "be3be2b6-505b-4bfe-840e-cb1af86f905d", 2, "BM", "BM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "131054ad-27e7-47a6-86cd-dd007dad0156");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21d78134-1a58-497c-9d24-c1c2593ef286");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "285d59d5-e950-4918-9c35-b8652159540f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40833baa-c429-4c21-9ab3-1c09bef4d0bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68d144fd-a5bc-4242-8a7c-ee3bdd08180b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88adc9f7-f197-4d89-bc21-e95fb7f7768a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "907ce44d-7248-472f-81be-171e4ca628e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "957ec248-2d7d-46f5-b24e-70f66ee66a59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1cb1076-0402-4c84-827e-9e53c9d25eaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d04f4cfb-2b1e-4b2a-b6b6-ef1de1519495");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1e1be96-7dee-4bd3-a625-d583783170ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5e6d8e8-b368-432c-b552-96f7151f434b");

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
    }
}
