using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedLeaveTypeSelectList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a5d297-f377-4d49-b74c-d5f05b991082", "AQAAAAIAAYagAAAAEFNMTSgpvUmyfqt7F4mqUqqS1m2QS2YyNXQK4MXXNEXGmhs07KtYYfYCinqV8w/tcg==", "34d2d669-bb68-4c28-88c2-b1eb43d8d809" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1103e063-2328-4881-84e3-76b284e58118", "AQAAAAIAAYagAAAAEEdVWGkFFuuaK0fmvhsiQs6PwheyoVi/9i5wVPnP9wBDentKLdif8pv9VJ/zKPldkg==", "eadbeec3-9754-4f98-8cb1-2ea293395a88" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04404c42-a477-42e3-b328-e44321dafd78", "AQAAAAIAAYagAAAAEFWbhpDmOABgfhBmT1JSMHdrEUxSeFhl0wuwWY/u7+qsDrA6ZbYu4uF5VybgCsIIfQ==", "fd6f23c9-9dff-459c-9fba-1b8701e1284f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abbf3214-9e25-47e2-9379-3b423d5bac65", "AQAAAAIAAYagAAAAELMFMPTBTPj+/+p9YyxrUBdXKEjY8FU7mujLoOgYxnsS0SJDcMxJepeIHUGM+PaK+w==", "ece777d8-b22f-4c7d-aabb-838b0c387bb4" });
        }
    }
}
