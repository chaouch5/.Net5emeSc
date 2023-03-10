using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluentApi6 : Migration
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
                newName: "planeID");

            migrationBuilder.RenameIndex(
                name: "IX_MyFlight_PlaneId",
                table: "MyFlight",
                newName: "IX_MyFlight_planeID");

            migrationBuilder.AlterColumn<int>(
                name: "planeID",
                table: "MyFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_MyPlane_planeID",
                table: "MyFlight",
                column: "planeID",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_MyPlane_planeID",
                table: "MyFlight");

            migrationBuilder.RenameColumn(
                name: "planeID",
                table: "MyFlight",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_MyFlight_planeID",
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
