using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3.EmpManSys.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeEntries",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEntry = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEntries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmployeeEntries_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEntries_EmployeeID",
                table: "EmployeeEntries",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeEntries");
        }
    }
}
