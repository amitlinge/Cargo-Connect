using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoConnect.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UniqueKeyAndVehicalEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    NumberPlate = table.Column<string>(type: "varchar(255)", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    LoadCapacity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehicals_drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_drivers_Email",
                table: "drivers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_drivers_LicenseNumber",
                table: "drivers",
                column: "LicenseNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehicals_DriverId",
                table: "vehicals",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicals_NumberPlate",
                table: "vehicals",
                column: "NumberPlate",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicals");

            migrationBuilder.DropIndex(
                name: "IX_users_Email",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_drivers_Email",
                table: "drivers");

            migrationBuilder.DropIndex(
                name: "IX_drivers_LicenseNumber",
                table: "drivers");
        }
    }
}
