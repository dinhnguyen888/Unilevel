using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpdateSomeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094e325e-1a24-4964-89be-3e7cee5210cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e0b3bae-1e09-4b52-b94f-6edb27abd631");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e13e8fd-bb3a-4116-9bdc-f07e60e30531");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84122ddd-6ab0-40c2-b336-d8b4f205a608");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8833cbda-f28f-4d7b-9b91-38a0cf951dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "996422b9-f1e3-406c-847c-440d8f3c2fce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b80bf342-fb0f-48e2-acdf-bce5df231caa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd5cf9a8-aabe-4252-856b-7741c585e905");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cea15af0-0b8a-4b73-b9cb-c3e6dc0c6cd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf1ebd83-1b92-45b2-98ef-638fa7700595");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e33ff889-827c-4f35-b0f5-5096ea283b44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e38c6d69-2051-495a-a1c4-b1241301f84c");

            migrationBuilder.AddColumn<string>(
                name: "CalendarCreatorId",
                table: "VisitCalendar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_VisitCalendar_CalendarCreatorId",
                table: "VisitCalendar",
                column: "CalendarCreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitCalendar_AspNetUsers_CalendarCreatorId",
                table: "VisitCalendar",
                column: "CalendarCreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitCalendar_AspNetUsers_CalendarCreatorId",
                table: "VisitCalendar");

            migrationBuilder.DropIndex(
                name: "IX_VisitCalendar_CalendarCreatorId",
                table: "VisitCalendar");

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

            migrationBuilder.DropColumn(
                name: "CalendarCreatorId",
                table: "VisitCalendar");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "094e325e-1a24-4964-89be-3e7cee5210cc", "b7275db5-ecad-49fe-a5a9-a28a3a81f587", 1, "Administrator", "ADMINISTRATOR" },
                    { "0e0b3bae-1e09-4b52-b94f-6edb27abd631", "87666c78-3cc3-407b-9c00-3cc3e224ab13", 2, "BAM", "BAM" },
                    { "1e13e8fd-bb3a-4116-9bdc-f07e60e30531", "dedc074a-7248-4455-a8ad-8ef33484018a", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "84122ddd-6ab0-40c2-b336-d8b4f205a608", "b2f3e912-25cf-4de5-915d-f2fcc121b88a", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "8833cbda-f28f-4d7b-9b91-38a0cf951dad", "541a256c-0891-4eca-b546-431883abe689", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "996422b9-f1e3-406c-847c-440d8f3c2fce", "d9f8beac-f10d-430a-b2ba-f05e6b59c8c5", 3, "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "b80bf342-fb0f-48e2-acdf-bce5df231caa", "0d71323c-d805-4916-a0f0-b75176688b53", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "bd5cf9a8-aabe-4252-856b-7741c585e905", "71d10ee7-621b-45ba-93bd-62aa28a5e929", 1, "Owner", "OWNER" },
                    { "cea15af0-0b8a-4b73-b9cb-c3e6dc0c6cd1", "95dca7e0-286c-413c-ae08-400c19f0300f", 2, "VPCD", "VPCD" },
                    { "cf1ebd83-1b92-45b2-98ef-638fa7700595", "41bd0fd6-c447-4893-a3ea-0b656af2bd59", 2, "BM", "BM" },
                    { "e33ff889-827c-4f35-b0f5-5096ea283b44", "57fd4fdf-f3eb-4571-9dd9-816f9664de9d", 2, "ASM", "ASM" },
                    { "e38c6d69-2051-495a-a1c4-b1241301f84c", "9036e4df-3c0d-4fca-a330-435609216870", 4, "Guest", "GUEST" }
                });
        }
    }
}
