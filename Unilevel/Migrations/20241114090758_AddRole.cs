using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "179562e3-cbb7-42d1-899b-d2320191eacb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36d82d26-77ca-4228-8b38-e45242902d96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38c77a1f-6dcd-4f67-8994-fd14dc50e3af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57770b93-d658-4d1d-be46-f71bb236e541");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ac5f3b1-3aad-44f8-b9d9-c4969339cebe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f4440a1-9e59-4cfa-9f5d-ea3bcf45f7f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e7d8eea-1320-4a3b-a6f2-51a7304add7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b59fd6a3-ddcd-4cc8-9d56-80115c139665");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b94b005c-8941-4262-8b4e-43744e94af05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d15d7533-9c1d-4439-9e48-ebe7d86e907c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a6424a-f976-4af6-b5ee-7bd53a95046a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd2d18d0-056c-4876-960f-45b256f3ba08");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "179562e3-cbb7-42d1-899b-d2320191eacb", "34d932bc-45c1-4c11-8d9d-587cf5022999", "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "36d82d26-77ca-4228-8b38-e45242902d96", "273f0334-6aed-4ad3-96bf-c66aa1a33291", "VPCD", "VPCD" },
                    { "38c77a1f-6dcd-4f67-8994-fd14dc50e3af", "e6a9ee75-7cec-4280-8931-8deb3045388f", "Guest", "GUEST" },
                    { "57770b93-d658-4d1d-be46-f71bb236e541", "2476d233-374f-48aa-9563-d848340321f3", "Owner", "OWNER" },
                    { "8ac5f3b1-3aad-44f8-b9d9-c4969339cebe", "d4f4effc-0925-48d9-bb66-27a6c556cc92", "Channel Activation Head", "CHANNEL ACTIVATION HEAD" },
                    { "8f4440a1-9e59-4cfa-9f5d-ea3bcf45f7f1", "2861e51c-7bf7-441f-9ae9-e6ac3f526744", "BM", "BM" },
                    { "9e7d8eea-1320-4a3b-a6f2-51a7304add7e", "62d5076f-6c71-45d7-9824-8995068860a8", "BAM", "BAM" },
                    { "b59fd6a3-ddcd-4cc8-9d56-80115c139665", "e52106ee-45b0-4185-94b9-35cb9caa85d6", "ASM", "ASM" },
                    { "b94b005c-8941-4262-8b4e-43744e94af05", "05dcba59-5c2d-423d-b10e-36f6078dcf50", "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "d15d7533-9c1d-4439-9e48-ebe7d86e907c", "88439e6e-d36d-4113-9805-91098a8d82cf", "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "d8a6424a-f976-4af6-b5ee-7bd53a95046a", "d55227d7-b6f7-40b3-beb5-c16b977b1f8b", "OtherDepartment", "OTHER DEPARTMENT" },
                    { "fd2d18d0-056c-4876-960f-45b256f3ba08", "b4f51687-c80b-4479-9c8e-5c15b759857c", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
