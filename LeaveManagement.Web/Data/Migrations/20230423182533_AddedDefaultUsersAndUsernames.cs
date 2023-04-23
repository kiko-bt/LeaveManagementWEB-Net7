using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1c9d212d-0f3a-4656-80fa-83f16ee78cc2", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPMFRj/c8tNbMS701sQsIMnGvIjz2R5rLwq90gQk1Q+jhxTX+tTPOTwtkFhwPBRlRQ==", "d30251e5-0d9c-415c-9dcb-a1287ef44787", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3cb50a9e-b68b-490f-8c7b-03ed2e267458", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDUniBRQNqkOiwTuJZMN7rCCYNRH0RQIlBg3/HAZ7lrHyz5nA7hvoLwjHuTp/rDjhQ==", "d9fea81b-7881-4c30-9f84-7cf65b194139", "admin@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "14d1c795-ee26-4779-a8a5-1a5f07649bba", false, null, "AQAAAAIAAYagAAAAEHuo/2AbfNfmKqUXKdBH7I+vBOVUACiP4h6pafFYfNaScX47oB//8hIypYJuH2Z2/Q==", "2d39ccab-2a56-45e1-b3cd-871cddaa2a61", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "51a48766-9608-4613-9b69-ebb16a735154", false, null, "AQAAAAIAAYagAAAAEFlL+WC6H+s4sLu/gDVeqS2YInwSAeaI4C2rbVj4YWPNdjQbShUP05fo3++9yPR1sA==", "d43b389f-45bd-4c29-887c-96890f1c1f70", null });
        }
    }
}
