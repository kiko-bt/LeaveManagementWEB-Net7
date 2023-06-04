using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f370196-019b-4c29-a41e-c185663ab7f5", "AQAAAAIAAYagAAAAEJb7iydfgJEn3swa0qYv1bYtcH0UX0kdkgKj43Pmx3Pux4gU2VrMd8L7uZ7gcpS/XQ==", "58bf0a4a-d449-47ff-b730-7a88d1488855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb6340f8-96ac-47c1-8160-918354323c34", "AQAAAAIAAYagAAAAEFPwp7/MIVC094aNGaH6n3dZLIVM5efIb6skCkgLCPKbmbbLjjkzY/NyCK7b0ImiZQ==", "db42540c-df11-4468-a2c8-5267ead771ea" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c9d212d-0f3a-4656-80fa-83f16ee78cc2", "AQAAAAIAAYagAAAAEPMFRj/c8tNbMS701sQsIMnGvIjz2R5rLwq90gQk1Q+jhxTX+tTPOTwtkFhwPBRlRQ==", "d30251e5-0d9c-415c-9dcb-a1287ef44787" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cb50a9e-b68b-490f-8c7b-03ed2e267458", "AQAAAAIAAYagAAAAEDUniBRQNqkOiwTuJZMN7rCCYNRH0RQIlBg3/HAZ7lrHyz5nA7hvoLwjHuTp/rDjhQ==", "d9fea81b-7881-4c30-9f84-7cf65b194139" });
        }
    }
}
