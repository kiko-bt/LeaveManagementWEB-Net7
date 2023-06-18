using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98fff803-3fd8-4363-8c6e-af64f6c0037a", "AQAAAAIAAYagAAAAEODax7cja/GrMelC6M0reNOaakLL4YH6tF9JU0So9YR2Uik7n82g1DP5ll3FZ1qWcQ==", "11e3f633-e2bd-4485-8362-a67996457266" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af8e0eba-55d1-49f5-b55a-21ed6070be3b", "AQAAAAIAAYagAAAAEBjjoVMfea13wxpx+A3eMBRqH1ALMbt5yLJSshfnUjuIYiaEmzElu1hJIIRiMVt0FA==", "6d26f38f-4132-45bc-ad46-d3e7cc539e93" });
        }
    }
}
