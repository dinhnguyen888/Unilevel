using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class FixEntity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyReceiver",
                table: "SurveyReceiver");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02f67888-e841-43e8-b28e-d60809819562");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19f1b008-e4cf-49a8-8dee-3518741708f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2682f498-da24-4d85-a4c7-b1bad4fe5df8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b6cf3e5-662b-482a-9e40-c64cb25380ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "424632bb-4174-415f-b090-41bc16085474");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43ac6af3-4aa4-4a60-b7ca-0ec3446d172e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b198a0d-a623-4007-a234-c003f010862a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dbc0865-aa99-401f-a2fc-698251804e02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "928f5257-e461-4eac-a9f1-8fac0f057502");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2a67a9c-cb55-4b01-b519-5058c90c6ca0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd6eee6a-66f8-4ec3-a1fc-3c747a743eb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e61e2c25-3093-4410-9aa0-b42eca4f49b8");

            migrationBuilder.AddColumn<int>(
                name: "SurveyId",
                table: "SurveyReceiver",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyReceiver",
                table: "SurveyReceiver",
                columns: new[] { "SurveyRequestId", "UserId", "SurveyId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1af14a1d-9a5f-443a-bbe6-cd0562f2d50b", "6d3966aa-5885-4f7b-b58c-c1908d848b33", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "1cf499bb-fb89-4cdd-b148-73b43f7dccce", "fdf85cf8-9229-4a4d-8fd9-87344e0d3836", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "3846e67c-bea9-4162-bfab-a2795dbbb679", "714c3780-af7b-4080-859e-c8d5ee75c528", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "3dd56e77-b1ea-4e4b-8324-835747eef610", "9042dffb-73f9-4ad5-a584-18797e7ab31c", 1, "Owner", "OWNER" },
                    { "3e260814-1086-4e3c-95dc-513e0a5cfdf6", "a1369c38-1f3d-498e-bf0e-9ff1e716c004", 2, "VPCD", "VPCD" },
                    { "50ae5421-8596-4135-a62c-8d129ce0a589", "32379226-0b44-4bab-9945-23968e8e5fa7", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "7663eb3d-784f-40a2-b238-5f1b00832e9d", "84537f85-5ab5-4010-acdb-de9a50c273ec", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "9829a5fa-041d-4d39-8e16-34ce2a53271b", "78d082e9-bac5-4404-8d5d-ab6ae86360db", 4, "Guest", "GUEST" },
                    { "a0fd973e-5ff5-4fda-b6b6-4ada25d559e1", "9881b694-8ce2-41d9-ad32-421bae5cbf4e", 2, "BAM", "BAM" },
                    { "be1134c4-0d4b-4cfb-bef7-96828ca45a0c", "537b8706-8da4-4771-9912-9da1a77d609b", 2, "ASM", "ASM" },
                    { "e7b28a22-263b-44f8-b9d2-299c2aebe6b4", "9ad373e3-e7d1-4628-8121-44d29e0a27d4", 2, "BM", "BM" },
                    { "f0c9bc0d-19bd-4bac-9591-66a331d4f4a7", "721bea26-2264-40e8-8f8e-86175831663b", 1, "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyReceiver",
                table: "SurveyReceiver");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1af14a1d-9a5f-443a-bbe6-cd0562f2d50b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cf499bb-fb89-4cdd-b148-73b43f7dccce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3846e67c-bea9-4162-bfab-a2795dbbb679");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dd56e77-b1ea-4e4b-8324-835747eef610");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e260814-1086-4e3c-95dc-513e0a5cfdf6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50ae5421-8596-4135-a62c-8d129ce0a589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7663eb3d-784f-40a2-b238-5f1b00832e9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9829a5fa-041d-4d39-8e16-34ce2a53271b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0fd973e-5ff5-4fda-b6b6-4ada25d559e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be1134c4-0d4b-4cfb-bef7-96828ca45a0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7b28a22-263b-44f8-b9d2-299c2aebe6b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0c9bc0d-19bd-4bac-9591-66a331d4f4a7");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "SurveyReceiver");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyReceiver",
                table: "SurveyReceiver",
                columns: new[] { "SurveyRequestId", "UserId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02f67888-e841-43e8-b28e-d60809819562", "ab0b8cab-fa61-42a1-944e-0fba965805d9", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "19f1b008-e4cf-49a8-8dee-3518741708f2", "e254584f-0748-4636-923d-74f8244b7e58", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "2682f498-da24-4d85-a4c7-b1bad4fe5df8", "3bcab425-31b1-4e51-9efc-7cb208cdff07", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "2b6cf3e5-662b-482a-9e40-c64cb25380ce", "02c3d7d3-07ca-43a3-b3d6-1d088e4d1301", 1, "Administrator", "ADMINISTRATOR" },
                    { "424632bb-4174-415f-b090-41bc16085474", "c6202b86-e919-476d-879c-910fc66b1a08", 2, "BM", "BM" },
                    { "43ac6af3-4aa4-4a60-b7ca-0ec3446d172e", "84027522-c60f-47d8-b7a2-186008805691", 2, "VPCD", "VPCD" },
                    { "4b198a0d-a623-4007-a234-c003f010862a", "62b289ef-8263-487b-91ce-9aeedd193e58", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "4dbc0865-aa99-401f-a2fc-698251804e02", "8b3779cb-99aa-45db-a0d4-5b8a167eb55c", 1, "Owner", "OWNER" },
                    { "928f5257-e461-4eac-a9f1-8fac0f057502", "8c281158-8264-44db-8063-a54a85a76d9b", 2, "ASM", "ASM" },
                    { "a2a67a9c-cb55-4b01-b519-5058c90c6ca0", "bc18d220-f820-4e59-8bf9-0053379cf713", 4, "Guest", "GUEST" },
                    { "cd6eee6a-66f8-4ec3-a1fc-3c747a743eb1", "48d347f1-c1d2-4f4a-9494-cd697be30507", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "e61e2c25-3093-4410-9aa0-b42eca4f49b8", "9f502bee-3c3b-4681-8e8b-017c5a92df6b", 2, "BAM", "BAM" }
                });
        }
    }
}
