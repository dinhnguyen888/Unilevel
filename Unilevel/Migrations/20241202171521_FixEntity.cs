using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class FixEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1098fef0-0723-4212-896d-cba46228b647");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c3fb295-13bd-471d-9fe0-be11648b424c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c015285-99b8-4a08-8e2c-29ed5e6c420a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f088d95-2da1-41b8-a0ff-5f4304b1de16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523ad9ab-aee3-453e-949b-96928f3abf40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62a4e202-f18f-4000-9bf6-194938d39756");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c218f8f-e84d-41af-ae15-40be02f5ec23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86dc7a39-b728-4b92-8996-397c70b4d29f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a15bbef0-be88-4bb3-a815-383194fde1fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b30bdacd-730b-47ea-8bd1-5d02d4ef5c76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9074028-9015-418b-9a86-88b81464bb13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e37d1881-118c-433f-adaf-a777e91bf3f7");

            migrationBuilder.AlterColumn<int>(
                name: "SurveyId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "SurveyId",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Answers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1098fef0-0723-4212-896d-cba46228b647", "39d2b24a-7e30-4310-97c5-3a50100c4980", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "1c3fb295-13bd-471d-9fe0-be11648b424c", "839ad63e-35b3-425a-9cb4-f5098ee8af13", 2, "VPCD", "VPCD" },
                    { "4c015285-99b8-4a08-8e2c-29ed5e6c420a", "9183490d-1966-468a-9e08-f449dda4e6db", 4, "Guest", "GUEST" },
                    { "4f088d95-2da1-41b8-a0ff-5f4304b1de16", "4fa01490-4814-4497-9eb1-f0b7f4297038", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "523ad9ab-aee3-453e-949b-96928f3abf40", "d0092741-9893-49be-91fd-f63ba1fa44ca", 2, "ASM", "ASM" },
                    { "62a4e202-f18f-4000-9bf6-194938d39756", "4ce3a598-51a1-4b5a-a689-00fad12c36d4", 1, "Administrator", "ADMINISTRATOR" },
                    { "7c218f8f-e84d-41af-ae15-40be02f5ec23", "0227cc75-37b8-47cf-af2a-03bce8cba56f", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "86dc7a39-b728-4b92-8996-397c70b4d29f", "919ff929-13fc-4c1c-ad39-4f192f53a4ff", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "a15bbef0-be88-4bb3-a815-383194fde1fb", "03c64872-ef75-498d-8ff4-7daf67c5c659", 1, "Owner", "OWNER" },
                    { "b30bdacd-730b-47ea-8bd1-5d02d4ef5c76", "7d1c1e19-be50-4f53-a019-5ffb19f3db5f", 2, "BAM", "BAM" },
                    { "b9074028-9015-418b-9a86-88b81464bb13", "7748a8a8-75c8-46f5-82aa-aaf6d9db36c5", 2, "BM", "BM" },
                    { "e37d1881-118c-433f-adaf-a777e91bf3f7", "b733c731-beaa-4a3d-859d-ebf7d766f265", 4, "OtherDepartment", "OTHER DEPARTMENT" }
                });
        }
    }
}
