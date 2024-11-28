using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddAreaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "177747c0-2e00-4728-9b31-b5da3c21fb0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ff392cd-dfe5-4e68-87ef-48fd54d151f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c582a58-79d1-4d1c-b907-b8157385386a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76d860a2-a3d4-45c5-87c0-12d9abe15e1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d4d12ab-57f9-4e56-aafe-5b0ff92a0574");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b7f28e4-6725-494f-a236-fc3248ca9e39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9605e649-0a90-46a0-8904-33e11d82a920");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf96ddfa-5acc-46e5-b31d-3b81f66b6905");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd40f342-d5e1-4387-a76c-869db1f28902");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e51a3612-ec29-48ab-ad47-e289b500371f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f730b78b-9b47-49c6-8c67-8aa546a76bd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8a47ea4-95f6-4316-b27c-c0ff5a92d04e");

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "061043bc-97d4-4fb8-a610-de551e1f189d", "d24e3ad2-188a-4e00-a602-4861ab14f3f6", "BM", "BM" },
                    { "0a76abee-15a8-45bb-87ec-b6297855e6d7", "c02b4789-1416-4158-8bb5-439144c75af7", "Administrator", "ADMINISTRATOR" },
                    { "0f56493f-0f31-4cce-82e1-71baa86216f3", "e4f03eb4-7675-48a0-8889-d76d2191757e", "BAM", "BAM" },
                    { "14ac3eb5-7e82-4806-9298-fb8ea26b5e0b", "4f303f55-e029-467b-bd4a-316f2de1d5e8", "ASM", "ASM" },
                    { "1df601d5-b835-40fb-9fd4-3a67b8531dfd", "a065eec0-5909-4485-ad61-47148d9c321e", "OtherDepartment", "OTHER DEPARTMENT" },
                    { "225a86f9-b27f-49ee-ba9d-899e5f62f233", "aea0c564-08f6-4486-84b7-c052a6f5a928", "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "67905a5f-1702-499e-92ed-776ecf905e5c", "12850b4b-e590-4e0b-8f0a-3d939be098ce", "Guest", "GUEST" },
                    { "73e2ac51-39be-4b80-b925-3088b8426d2e", "1ec20d12-f52b-49a9-b475-c0a5edda681d", "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "75c49e6e-8f4c-4ad0-aac1-bffa2025caae", "f2e9c402-89c1-4f6b-bce8-e5e83054acc2", "Owner", "OWNER" },
                    { "7bbc1253-7768-469a-a331-9ab5cbca62c4", "b6f308b8-d373-45f1-92b7-0044d6d7e570", "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "9346bba2-d9af-4b52-b615-1284fbc3483d", "20125dac-9e5b-4327-87b3-6c5a1cff49f9", "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "f8d8dff2-1e55-4f5a-b1d4-d7301b3a53b5", "86465365-f013-49d4-a96b-b54d59fc47cd", "VPCD", "VPCD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "061043bc-97d4-4fb8-a610-de551e1f189d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a76abee-15a8-45bb-87ec-b6297855e6d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f56493f-0f31-4cce-82e1-71baa86216f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14ac3eb5-7e82-4806-9298-fb8ea26b5e0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1df601d5-b835-40fb-9fd4-3a67b8531dfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "225a86f9-b27f-49ee-ba9d-899e5f62f233");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67905a5f-1702-499e-92ed-776ecf905e5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e2ac51-39be-4b80-b925-3088b8426d2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75c49e6e-8f4c-4ad0-aac1-bffa2025caae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bbc1253-7768-469a-a331-9ab5cbca62c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9346bba2-d9af-4b52-b615-1284fbc3483d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8d8dff2-1e55-4f5a-b1d4-d7301b3a53b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "177747c0-2e00-4728-9b31-b5da3c21fb0e", "59ab822d-9c7d-4180-8bb1-fbc76c7b935a", "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "4ff392cd-dfe5-4e68-87ef-48fd54d151f2", "7fb46488-7aea-4d43-9d59-25210d74b7c2", "BM", "BM" },
                    { "6c582a58-79d1-4d1c-b907-b8157385386a", "4d83baf9-cab3-472f-b835-84fc7bea0803", "VPCD", "VPCD" },
                    { "76d860a2-a3d4-45c5-87c0-12d9abe15e1f", "931e74f7-aac9-4407-b529-22a31e305041", "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "7d4d12ab-57f9-4e56-aafe-5b0ff92a0574", "109c1c59-6896-4a3b-b9e4-544d355e7a05", "Owner", "OWNER" },
                    { "8b7f28e4-6725-494f-a236-fc3248ca9e39", "56dedab8-2c46-406c-95d4-7bbbcd4e3256", "BAM", "BAM" },
                    { "9605e649-0a90-46a0-8904-33e11d82a920", "a7a2aa43-95ff-4ccd-b5e0-6f6ecaf6c70e", "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "cf96ddfa-5acc-46e5-b31d-3b81f66b6905", "5707726d-e3ec-46a9-8106-1875e649a4bd", "OtherDepartment", "OTHER DEPARTMENT" },
                    { "dd40f342-d5e1-4387-a76c-869db1f28902", "99d33515-ced8-42c5-be73-6fce6debf9ee", "Administrator", "ADMINISTRATOR" },
                    { "e51a3612-ec29-48ab-ad47-e289b500371f", "08f35967-d0ff-4e06-b34f-135555c03500", "ASM", "ASM" },
                    { "f730b78b-9b47-49c6-8c67-8aa546a76bd1", "82a4c3c0-9c2b-4e2d-b67e-934fcb09d861", "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "f8a47ea4-95f6-4316-b27c-c0ff5a92d04e", "2130a788-4da7-4774-b4ca-e77881042592", "Guest", "GUEST" }
                });
        }
    }
}
