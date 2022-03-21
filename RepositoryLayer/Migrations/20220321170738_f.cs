using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Last_Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Employee_Education = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Employee_Experience = table.Column<int>(type: "INT", nullable: false),
                    Employee_Age = table.Column<int>(type: "INT", nullable: false),
                    Employee_Designation = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CreatedBy = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_empId", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails");
        }
    }
}
