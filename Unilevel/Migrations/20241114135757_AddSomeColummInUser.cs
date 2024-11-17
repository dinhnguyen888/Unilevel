using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddSomeColummInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09f17941-83c3-4ea9-854a-89039ee80eba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "114567a2-f8f3-4e98-820f-76f4507e4233");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1332a9df-3bab-4631-8040-95e4cc52e631");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33700c54-ed5e-45aa-b270-75a06623832b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "474aa305-7699-44ad-91f1-c8fa273e540d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bf53583-22c8-42ee-9b39-6b7cb6f8e0b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "962e4030-bfb2-4ef6-ba65-b32c64202e88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "996d214d-bd33-42e2-bfdc-e728636d38b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5447da8-da9b-428a-aa83-a53ee552c70f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aeff9ffb-b518-4cbf-96dc-dd8b8dd2f717");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b159d61a-b70f-4c5d-87d9-ea1ffc6259ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7cdceb5-2ab3-4414-a964-10558efc1b3a");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reporter",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Reporter",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09f17941-83c3-4ea9-854a-89039ee80eba", "9a81a3b8-6a94-4803-b245-5a13a6c0724f", "BAM", "BAM" },
                    { "114567a2-f8f3-4e98-820f-76f4507e4233", "682bc440-923b-452e-842a-bfd3efaf4fd0", "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "1332a9df-3bab-4631-8040-95e4cc52e631", "43d1c84c-f067-4fca-bede-4ad1b7eeb477", "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "33700c54-ed5e-45aa-b270-75a06623832b", "321f62a0-c15b-49b2-8bdc-db195c29d46d", "Guest", "GUEST" },
                    { "474aa305-7699-44ad-91f1-c8fa273e540d", "f78b6bb6-0ed6-4aec-86e4-fc5d1a8dcdeb", "BM", "BM" },
                    { "4bf53583-22c8-42ee-9b39-6b7cb6f8e0b4", "9277f767-ccf7-466d-9db7-ed7392549b3e", "Owner", "OWNER" },
                    { "962e4030-bfb2-4ef6-ba65-b32c64202e88", "6e3692e7-8a52-4d3c-961b-2f0f39814ee2", "ASM", "ASM" },
                    { "996d214d-bd33-42e2-bfdc-e728636d38b0", "fc6abe11-97a6-4e4e-9fbc-2032b8e8360c", "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "a5447da8-da9b-428a-aa83-a53ee552c70f", "6f940fd4-5786-41bc-a4b0-4df6139dbea0", "Administrator", "ADMINISTRATOR" },
                    { "aeff9ffb-b518-4cbf-96dc-dd8b8dd2f717", "34e04c58-994c-4a65-bc82-941540ce7a72", "OtherDepartment", "OTHER DEPARTMENT" },
                    { "b159d61a-b70f-4c5d-87d9-ea1ffc6259ee", "5a78ca70-ab67-4fca-8abf-03a3cf682595", "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "d7cdceb5-2ab3-4414-a964-10558efc1b3a", "f271ecd8-bca0-4738-be59-a91bc8b216e2", "VPCD", "VPCD" }
                });
        }
    }
}
