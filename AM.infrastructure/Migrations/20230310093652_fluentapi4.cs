using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluentapi4 : Migration
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
                newName: "flight_passenger");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassanger_passangersPassportNumber",
                table: "flight_passenger",
                newName: "IX_flight_passenger_passangersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_flight_passenger",
                table: "flight_passenger",
                columns: new[] { "flightsFlightId", "passangersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_flight_passenger_MyFlight_flightsFlightId",
                table: "flight_passenger",
                column: "flightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_flight_passenger_Passangers_passangersPassportNumber",
                table: "flight_passenger",
                column: "passangersPassportNumber",
                principalTable: "Passangers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_flight_passenger_MyFlight_flightsFlightId",
                table: "flight_passenger");

            migrationBuilder.DropForeignKey(
                name: "FK_flight_passenger_Passangers_passangersPassportNumber",
                table: "flight_passenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_flight_passenger",
                table: "flight_passenger");

            migrationBuilder.RenameTable(
                name: "flight_passenger",
                newName: "FlightPassanger");

            migrationBuilder.RenameIndex(
                name: "IX_flight_passenger_passangersPassportNumber",
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
