using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddImplementationDatesNavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "VisitCalendarStatus",
                table: "VisitCalendar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0caf9e5f-7a5f-4b9c-85c2-2bb61258c09e", "224163d0-0e39-4940-8d5c-546e0860929a", 1, "Owner", "OWNER" },
                    { "331e8668-a635-4415-aaa6-f61f24bbd146", "94ccee83-620b-43dc-b6fa-67fb4faae557", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "33d10566-a071-4059-af3e-beb89366aefe", "565fab63-4f3f-4022-a3bc-0fdf972bb2b7", 2, "VPCD", "VPCD" },
                    { "3862f8b4-1217-4d05-a2d8-bba54e57f86b", "47d90f80-46f5-445d-83c1-b5536a917573", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "4a598d10-e52c-48aa-b912-66441538a268", "a2615de3-8178-473a-920e-9a903089c5ea", 2, "BAM", "BAM" },
                    { "754630ed-db60-48a9-ade8-351015495f95", "0660824d-1c48-47c8-b9da-1df9e97ff2f9", 1, "Administrator", "ADMINISTRATOR" },
                    { "99d7610d-05d8-4943-96bf-4a2d53c35730", "72f30f12-513e-48b7-9b9e-98f9d3bfe492", 2, "BM", "BM" },
                    { "9c9af68e-6e97-4e39-87c7-a9d834d1f852", "9a64eba4-32ea-46da-af69-9732f75b956b", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "d47bd2e1-39da-4bfb-bf7a-009ece359573", "3c435e88-8375-468b-8213-d9a5b25af207", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "ebe4a00e-5a42-49f4-b20d-5a79a6f1feb6", "9136768c-4f11-4990-8e2a-a0615b705007", 4, "Guest", "GUEST" },
                    { "efe88328-43d9-409a-8420-ace5e3be6867", "886fbd36-e3a1-4f1e-acd8-40129ad27493", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "f5200f0b-ff8e-4f26-95e3-a2e8f2481d35", "f1b43100-c7c1-40a6-a338-a3be809dbf8b", 2, "ASM", "ASM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0caf9e5f-7a5f-4b9c-85c2-2bb61258c09e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "331e8668-a635-4415-aaa6-f61f24bbd146");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33d10566-a071-4059-af3e-beb89366aefe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3862f8b4-1217-4d05-a2d8-bba54e57f86b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a598d10-e52c-48aa-b912-66441538a268");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "754630ed-db60-48a9-ade8-351015495f95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99d7610d-05d8-4943-96bf-4a2d53c35730");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c9af68e-6e97-4e39-87c7-a9d834d1f852");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47bd2e1-39da-4bfb-bf7a-009ece359573");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe4a00e-5a42-49f4-b20d-5a79a6f1feb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efe88328-43d9-409a-8420-ace5e3be6867");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5200f0b-ff8e-4f26-95e3-a2e8f2481d35");

            migrationBuilder.DropColumn(
                name: "VisitCalendarStatus",
                table: "VisitCalendar");

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
    }
}
