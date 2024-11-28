using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_AspNetUsers_UserId",
                table: "UserPermissions");

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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserPermissions",
                newName: "RoleId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15ab421d-fbf8-4232-8388-3537537c5b47", "9808c592-7611-4875-ad7e-3d15ef36ab83", 2, "BAM", "BAM" },
                    { "16e7f67b-4a27-4723-8299-e548479c8e14", "1b020eee-19df-49c7-b11c-c6d8134da132", 1, "Administrator", "ADMINISTRATOR" },
                    { "3885a48f-9691-428a-9472-8f0dcbd0f75f", "6807fe54-14e8-4988-bc6e-88d69252d283", 2, "VPCD", "VPCD" },
                    { "4e3529e7-7a9f-4754-bb22-15f8ebc04c74", "949b6ccc-7e5b-43c5-8348-0182fe534a84", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "53983ae8-01eb-4c96-a6e4-561546c905a4", "2c8be1af-c265-4db7-8980-64c0dbce2fb7", 1, "Owner", "OWNER" },
                    { "5d412212-4633-4c21-ab89-4c9e61a79ec0", "00dd6fc9-d91a-4cc6-945d-a601c97ce584", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "8cb50ef7-2ec7-40e3-8f48-e8d34bb9092b", "739fd024-b5a7-40e8-b21f-121c6dabe5f3", 4, "Guest", "GUEST" },
                    { "9206f116-51c4-47c4-8b91-a3ccad08f0d6", "98ea1050-d9af-4dd2-b830-b2e2acf0607d", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "9dd5a6f4-d667-4008-bb7c-6aff12cdcc9c", "a068aaca-0c62-4370-9a8a-48152a9734c1", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "a8cc526d-0a9c-4100-a7d2-8f50544448d6", "8f632ace-5872-48e5-b95b-a9fd08185cc4", 2, "BM", "BM" },
                    { "f1e0a3ad-11a4-493d-8802-5a005b15a0ea", "1b437557-14ab-4df1-bfa9-f0354cc0453a", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "fb56fd0d-bfb8-4510-bb22-b1af894e0ca1", "271738cd-9519-4412-b1d0-4c1e87c30747", 2, "ASM", "ASM" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_AspNetRoles_RoleId",
                table: "UserPermissions",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPermissions_AspNetRoles_RoleId",
                table: "UserPermissions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15ab421d-fbf8-4232-8388-3537537c5b47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16e7f67b-4a27-4723-8299-e548479c8e14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3885a48f-9691-428a-9472-8f0dcbd0f75f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e3529e7-7a9f-4754-bb22-15f8ebc04c74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53983ae8-01eb-4c96-a6e4-561546c905a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d412212-4633-4c21-ab89-4c9e61a79ec0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cb50ef7-2ec7-40e3-8f48-e8d34bb9092b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9206f116-51c4-47c4-8b91-a3ccad08f0d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dd5a6f4-d667-4008-bb7c-6aff12cdcc9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8cc526d-0a9c-4100-a7d2-8f50544448d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1e0a3ad-11a4-493d-8802-5a005b15a0ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb56fd0d-bfb8-4510-bb22-b1af894e0ca1");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "UserPermissions",
                newName: "UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermissions_AspNetUsers_UserId",
                table: "UserPermissions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
