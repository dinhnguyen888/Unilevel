using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class FixAreaAtrributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Area_AreaId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "298aa574-5a18-4180-9bcc-28c61b7a6142");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b945088-de50-4a19-80e0-d10b5c369cd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1bb49e-c7b6-4d79-bcc9-7237831a6d3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71c52f1d-4ddf-4d20-a117-111198a2be11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7267911d-111f-4bb6-a1ad-a8d428eeda40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76f30a65-e39f-49f0-a08b-6a871a5a3c13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aaad5c7-e152-4d22-bb7d-a9baa779c6d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7aa7862-c374-48a7-bd00-30584f45f9b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbea7321-e22a-4656-8ce3-25460bb42989");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e18a3c0a-a1cb-4a8c-8ec5-a2ca204d223d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4151e95-07ce-41b2-a907-1116c76e3e6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe480cf8-58cf-40af-a13e-6a74f324f7e0");

            migrationBuilder.AlterColumn<string>(
                name: "AreaId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Area_AreaId",
                table: "AspNetUsers",
                column: "AreaId",
                principalTable: "Area",
                principalColumn: "AreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Area_AreaId",
                table: "AspNetUsers");

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
                name: "AreaId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "298aa574-5a18-4180-9bcc-28c61b7a6142", "382f7f73-4992-4b1f-809a-7d3e339cf15c", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "3b945088-de50-4a19-80e0-d10b5c369cd0", "c91f22f8-f523-42f7-9e79-207b7d7cfa20", 4, "Guest", "GUEST" },
                    { "3d1bb49e-c7b6-4d79-bcc9-7237831a6d3d", "9d95304f-d0c1-472f-b5e9-ae46ccaebede", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "71c52f1d-4ddf-4d20-a117-111198a2be11", "6b148bbd-b43d-46c8-b94b-db05eff65bab", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "7267911d-111f-4bb6-a1ad-a8d428eeda40", "05d6ee66-4fb2-4508-9b65-2feff27e2470", 2, "VPCD", "VPCD" },
                    { "76f30a65-e39f-49f0-a08b-6a871a5a3c13", "e7987d9a-46fa-43f7-9904-8a58cd5fe1ed", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "8aaad5c7-e152-4d22-bb7d-a9baa779c6d6", "fa780fc6-17ac-4074-8a18-219beb1c8308", 3, "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "b7aa7862-c374-48a7-bd00-30584f45f9b3", "e66a9ad5-c2bd-4aea-8eba-bd0e6b90fba4", 1, "Owner", "OWNER" },
                    { "cbea7321-e22a-4656-8ce3-25460bb42989", "159d3d43-6a44-486d-8f7e-749801a25f96", 1, "Administrator", "ADMINISTRATOR" },
                    { "e18a3c0a-a1cb-4a8c-8ec5-a2ca204d223d", "9bb76b7d-06cf-49c7-9a09-a3ac6c3ec4a4", 2, "ASM", "ASM" },
                    { "f4151e95-07ce-41b2-a907-1116c76e3e6e", "ef404359-9940-4026-9b69-5030296fef66", 2, "BAM", "BAM" },
                    { "fe480cf8-58cf-40af-a13e-6a74f324f7e0", "15dc68ac-0bf7-4ce8-9a71-9a6ca2f8375b", 2, "BM", "BM" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Area_AreaId",
                table: "AspNetUsers",
                column: "AreaId",
                principalTable: "Area",
                principalColumn: "AreaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
