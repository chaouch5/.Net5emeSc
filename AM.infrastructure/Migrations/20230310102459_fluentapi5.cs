using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluentapi5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "MyFlight",
                newName: "planeId");

            migrationBuilder.RenameIndex(
                name: "IX_MyFlight_PlaneId",
                table: "MyFlight",
                newName: "IX_MyFlight_planeId");

            migrationBuilder.AlterColumn<int>(
                name: "planeId",
                table: "MyFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlane_planeId",
                table: "MyFlight",
                column: "planeId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlane_planeId",
                table: "MyFlight");

            migrationBuilder.RenameColumn(
                name: "planeId",
                table: "MyFlight",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_MyFlight_planeId",
                table: "MyFlight",
                newName: "IX_MyFlight_PlaneId");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneId",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlane_PlaneId",
                table: "MyFlight",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
