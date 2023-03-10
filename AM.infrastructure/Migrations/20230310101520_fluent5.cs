using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluent5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassanger_MyFlight_flightsFlightId",
                table: "FlightPassanger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassanger_Passangers_passangersPassportNumber",
                table: "FlightPassanger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassanger",
                table: "FlightPassanger");

            migrationBuilder.RenameTable(
                name: "FlightPassanger",
                newName: "flight-passenger");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassanger_passangersPassportNumber",
                table: "flight-passenger",
                newName: "IX_flight-passenger_passangersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_flight-passenger",
                table: "flight-passenger",
                columns: new[] { "flightsFlightId", "passangersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_flight-passenger_MyFlight_flightsFlightId",
                table: "flight-passenger",
                column: "flightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flight-passenger_Passangers_passangersPassportNumber",
                table: "flight-passenger",
                column: "passangersPassportNumber",
                principalTable: "Passangers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flight-passenger_MyFlight_flightsFlightId",
                table: "flight-passenger");

            migrationBuilder.DropForeignKey(
                name: "FK_flight-passenger_Passangers_passangersPassportNumber",
                table: "flight-passenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_flight-passenger",
                table: "flight-passenger");

            migrationBuilder.RenameTable(
                name: "flight-passenger",
                newName: "FlightPassanger");

            migrationBuilder.RenameIndex(
                name: "IX_flight-passenger_passangersPassportNumber",
                table: "FlightPassanger",
                newName: "IX_FlightPassanger_passangersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassanger",
                table: "FlightPassanger",
                columns: new[] { "flightsFlightId", "passangersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassanger_MyFlight_flightsFlightId",
                table: "FlightPassanger",
                column: "flightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassanger_Passangers_passangersPassportNumber",
                table: "FlightPassanger",
                column: "passangersPassportNumber",
                principalTable: "Passangers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
