using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApi.Migrations
{
    /// <inheritdoc />
    public partial class gender_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeGenderId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeGenderId",
                table: "Employees",
                column: "EmployeeGenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Genders_EmployeeGenderId",
                table: "Employees",
                column: "EmployeeGenderId",
                principalTable: "Genders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Genders_EmployeeGenderId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeGenderId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeGenderId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
