using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class TestSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "ad155d78-b991-4f00-b181-d7ec00c3e429", 1, "Owner", "OWNER" },
                    { "00000000-0000-0000-0000-000000000002", "6b3f6b9c-5f9c-4231-8f86-acc55d5f0e9e", 1, "Administrator", "ADMINISTRATOR" },
                    { "00000000-0000-0000-0000-000000000003", "f094e2b3-7192-4933-b624-132155cbd89d", 2, "VPCD", "VPCD" },
                    { "00000000-0000-0000-0000-000000000004", "97d7432f-e92a-4b8d-a778-1dfa5ebbdd15", 2, "BM", "BM" },
                    { "00000000-0000-0000-0000-000000000005", "b874cb2f-f839-4e47-8a02-948de596ef18", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "00000000-0000-0000-0000-000000000006", "d5b6992b-6b71-499c-a89f-423276bed424", 2, "ASM", "ASM" },
                    { "00000000-0000-0000-0000-000000000007", "255a2692-5121-43df-a24a-3652e30be95e", 2, "BAM", "BAM" },
                    { "00000000-0000-0000-0000-000000000008", "f3cd8308-4891-4694-97c7-a4b0fced3809", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "00000000-0000-0000-0000-000000000009", "f9f302f1-08d5-4e5a-af69-53cb97433a14", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "00000000-0000-0000-0000-000000000010", "96b5ff94-8315-4553-9187-209a3679870a", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "00000000-0000-0000-0000-000000000011", "30377753-1ffd-4ab0-a3c7-33a8abf37b29", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "00000000-0000-0000-0000-000000000012", "e0eda9fd-ef63-48c7-b9d3-44d5b390b0dc", 4, "Guest", "GUEST" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012");
        }
    }
}
