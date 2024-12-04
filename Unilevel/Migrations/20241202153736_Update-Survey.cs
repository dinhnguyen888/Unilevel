using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpdateSurvey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SurveyRequest_SurveyId",
                table: "SurveyRequest");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "190dbead-2e26-4e06-8386-73ec3c7f4a61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d199a7f-9300-457b-9fc4-32907cd5266d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b2c9637-9b84-4b11-81fa-3617ddf77244");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8076344e-ff50-4f4f-8200-28f9acf129e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cc1b086-6f3a-4423-94b0-d66329ef8816");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93e6454c-d184-4235-b082-4e187e352756");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a466e4bf-221a-432d-a611-ef04febaed8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1eb131b-a331-47cc-a702-02a7c7ada21a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba32cf1f-2702-4645-9b8e-df732de0af75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6f7cf0a-cb38-48dd-8e03-6183b574e4e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0e7fe8-1836-4e04-b699-5e956616a5b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5cb50d6-5c05-4d21-bc3d-13c6f70a2216");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "SurveyReceiver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "SurveyResponse",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    UserAnswerContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyResponse_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26e4cf16-402c-478a-8604-30d7b88bbaed", "aa85b59d-893e-4cd1-b3bf-b3b6600749ac", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "283e4bbb-8483-4a2a-8aea-35018cf5ad85", "dd66cc0a-86d5-44e2-97f7-03ba7bafa0e7", 2, "VPCD", "VPCD" },
                    { "6122d876-4a2d-4217-9fdc-e53a1fa4e075", "96364b36-172b-4cf5-a459-2270aef2dbf1", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "6acd9f17-e8dc-4747-ad02-244bd9d3fa39", "1701bb98-b54f-42dc-b1ca-e6121e8f7218", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "94fb6f71-a129-4981-b765-bf5f1dead7fa", "6e15fac4-6de6-46c1-ba9b-f0ec0f9560ca", 2, "BAM", "BAM" },
                    { "a3c9c156-e98a-41c2-82d4-ab3cda984310", "d0144df8-4775-4d55-a8b7-c4385939525c", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "ab4ec0dc-28c7-42b7-bb8d-7351aa96a050", "f1dd5cba-3fba-4e73-842d-b929d311eec9", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "b5a3ad3f-b85e-4ba8-a811-f48b07943ce6", "a8973944-b0f1-4a12-81ef-c8870a7804a8", 1, "Administrator", "ADMINISTRATOR" },
                    { "bff23f4d-8b98-4c9f-9e4b-bfc4327f9129", "e6d0682b-871a-4c51-bd2f-851f97d9c8da", 2, "BM", "BM" },
                    { "c029a46c-603e-4601-a770-9e256b07544f", "124663a2-bc18-44ef-9ee8-28003e81579a", 2, "ASM", "ASM" },
                    { "db45bab5-53eb-4442-acc2-429e6f4a119e", "86f90750-8e0f-4dc0-89a9-d32602ceed91", 4, "Guest", "GUEST" },
                    { "f7a2b022-4566-4c7d-9f25-f4d5a448e057", "278b003f-8e02-4c75-b8d5-8637bc4602a4", 1, "Owner", "OWNER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyRequest_SurveyId",
                table: "SurveyRequest",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_SurveyId",
                table: "SurveyResponse",
                column: "SurveyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyResponse");

            migrationBuilder.DropIndex(
                name: "IX_SurveyRequest_SurveyId",
                table: "SurveyRequest");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26e4cf16-402c-478a-8604-30d7b88bbaed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "283e4bbb-8483-4a2a-8aea-35018cf5ad85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6122d876-4a2d-4217-9fdc-e53a1fa4e075");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6acd9f17-e8dc-4747-ad02-244bd9d3fa39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94fb6f71-a129-4981-b765-bf5f1dead7fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3c9c156-e98a-41c2-82d4-ab3cda984310");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab4ec0dc-28c7-42b7-bb8d-7351aa96a050");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5a3ad3f-b85e-4ba8-a811-f48b07943ce6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bff23f4d-8b98-4c9f-9e4b-bfc4327f9129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029a46c-603e-4601-a770-9e256b07544f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db45bab5-53eb-4442-acc2-429e6f4a119e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7a2b022-4566-4c7d-9f25-f4d5a448e057");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "SurveyReceiver");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "190dbead-2e26-4e06-8386-73ec3c7f4a61", "85ce7850-a898-4716-88d7-6e40ed9460d3", 2, "ASM", "ASM" },
                    { "3d199a7f-9300-457b-9fc4-32907cd5266d", "886ca073-968a-4715-b876-f3f5039a3696", 1, "Administrator", "ADMINISTRATOR" },
                    { "7b2c9637-9b84-4b11-81fa-3617ddf77244", "cce8c72c-2a87-4e01-ac94-0812f5f65a40", 4, "Guest", "GUEST" },
                    { "8076344e-ff50-4f4f-8200-28f9acf129e0", "c74e1efc-73f3-48b3-814a-f99b40205b49", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "8cc1b086-6f3a-4423-94b0-d66329ef8816", "d4c97279-75d7-4bed-a78e-77bd747d6cb4", 2, "VPCD", "VPCD" },
                    { "93e6454c-d184-4235-b082-4e187e352756", "b8f242ab-22c6-4bb8-b546-b836139f0380", 1, "Owner", "OWNER" },
                    { "a466e4bf-221a-432d-a611-ef04febaed8d", "ef44ae0c-a1a4-42da-a913-116ed0447dc7", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "b1eb131b-a331-47cc-a702-02a7c7ada21a", "8d2f62e9-4edf-4ed9-b71a-e855caa70a91", 2, "BM", "BM" },
                    { "ba32cf1f-2702-4645-9b8e-df732de0af75", "1c6f02a1-dfbb-4fc4-a136-d85a16ac8443", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "c6f7cf0a-cb38-48dd-8e03-6183b574e4e6", "7af765df-1130-473c-9fde-c6cb047410fe", 2, "BAM", "BAM" },
                    { "cf0e7fe8-1836-4e04-b699-5e956616a5b5", "0172304c-709b-46ae-835c-cd0be2a7acf9", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "d5cb50d6-5c05-4d21-bc3d-13c6f70a2216", "75f2fb98-1bd9-46c0-9ee4-956ab05f263c", 4, "OtherDepartment", "OTHER DEPARTMENT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyRequest_SurveyId",
                table: "SurveyRequest",
                column: "SurveyId",
                unique: true);
        }
    }
}
