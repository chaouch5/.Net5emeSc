using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class aeaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullName_lastName",
                table: "Passangers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "fullName_firstName",
                table: "Passangers",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passangers",
                newName: "fullName_lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passangers",
                newName: "fullName_firstName");
        }
    }
}
