using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddSurveyRequestAndSurveyReceiver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_AspNetUsers_UserId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_UserId",
                table: "Answers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12aadad0-92c1-4fca-94c2-a10efe345a25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30e1cc9f-f452-4e51-a3d1-b7e63f72e181");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "442a5e84-6ae2-4b25-b749-a4b7ff322eff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b54e1bd-62b0-47a7-82e6-a4964df40b64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55a46a8f-158a-449f-8ec6-e401a753a00f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "687e9edf-20c0-441b-98a5-c6d054115879");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a32ccea-5c06-4769-9371-92a8e8da440f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8a8f428-6cd8-43ca-84fb-221059009c0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b54d9043-f47d-4f22-b4a1-0445071936ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7d49737-48bc-45fa-9110-7a0d877bc6d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1240fa3-fa73-462d-924c-b8f30e3605c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea4b2368-c902-4479-82a1-761111d82178");

            migrationBuilder.DropColumn(
                name: "UserAnswerId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Surveys",
                newName: "SurveyName");

            migrationBuilder.AddColumn<bool>(
                name: "IsDifferentAnswer",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMultipleAnswer",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "SurveyRequest",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyRequest_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyReceiver",
                columns: table => new
                {
                    SurveyRequestId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyReceiver", x => new { x.SurveyRequestId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SurveyReceiver_SurveyRequest_SurveyRequestId",
                        column: x => x.SurveyRequestId,
                        principalTable: "SurveyRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyReceiver");

            migrationBuilder.DropTable(
                name: "SurveyRequest");

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

            migrationBuilder.DropColumn(
                name: "IsDifferentAnswer",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsMultipleAnswer",
                table: "Questions");

            migrationBuilder.RenameColumn(
                name: "SurveyName",
                table: "Surveys",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "UserAnswerId",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Answers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12aadad0-92c1-4fca-94c2-a10efe345a25", "aa21f099-2e7b-4645-848a-36e0d723536e", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "30e1cc9f-f452-4e51-a3d1-b7e63f72e181", "e9012593-c9b1-483c-8fc6-233a566270d7", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "442a5e84-6ae2-4b25-b749-a4b7ff322eff", "33f9e4d7-ceff-4192-9b90-baf3b82c97b9", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "4b54e1bd-62b0-47a7-82e6-a4964df40b64", "b83bdafe-5b0e-4477-b5c1-5aed785d62fa", 4, "Guest", "GUEST" },
                    { "55a46a8f-158a-449f-8ec6-e401a753a00f", "cc301bd3-73fa-430c-aa68-252a5d9966bf", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "687e9edf-20c0-441b-98a5-c6d054115879", "eb79e171-6e70-4ff3-b5b3-d62b9d4c3c71", 2, "BM", "BM" },
                    { "6a32ccea-5c06-4769-9371-92a8e8da440f", "825d6c6a-3e10-4436-933b-c7fed271c386", 2, "ASM", "ASM" },
                    { "a8a8f428-6cd8-43ca-84fb-221059009c0c", "9060ccea-a93c-47d9-bb71-134d96080446", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "b54d9043-f47d-4f22-b4a1-0445071936ab", "fab2cc16-9ce4-437c-882f-7f5fe4eda975", 1, "Administrator", "ADMINISTRATOR" },
                    { "b7d49737-48bc-45fa-9110-7a0d877bc6d6", "4a7c783a-756e-49fb-8827-7079e73b27c1", 2, "VPCD", "VPCD" },
                    { "e1240fa3-fa73-462d-924c-b8f30e3605c4", "921550fe-b154-43f9-b29b-0f707d578473", 2, "BAM", "BAM" },
                    { "ea4b2368-c902-4479-82a1-761111d82178", "9bac9cd9-bf87-4e10-b434-9522976039f6", 1, "Owner", "OWNER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserId",
                table: "Answers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_AspNetUsers_UserId",
                table: "Answers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
