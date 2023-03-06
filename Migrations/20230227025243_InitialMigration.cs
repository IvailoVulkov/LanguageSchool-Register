using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageSchool.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AgeTypes_AgeTypes_AgeTypeId",
                table: "AgeTypes");

            migrationBuilder.DropIndex(
                name: "IX_AgeTypes_AgeTypeId",
                table: "AgeTypes");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "SchoolYears");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Adult",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Enum",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AgeTypeId",
                table: "AgeTypes");

            migrationBuilder.RenameColumn(
                name: "Child",
                table: "Categories",
                newName: "Name");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SchoolYears",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "BookPrice",
                table: "SchoolYears",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "SchoolYears",
                table: "SchoolYears",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SertificatId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Language",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RegCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SertificateNo = table.Column<int>(type: "int", nullable: false),
                    SertificateImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegCourse_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RegCourse_CourseId",
                table: "RegCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_RegCourse_StudentId",
                table: "RegCourse",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "RegCourse");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SchoolYears",
                table: "SchoolYears");

            migrationBuilder.DropColumn(
                name: "SertificatId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Child");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "SchoolYears",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<int>(
                name: "BookPrice",
                table: "SchoolYears",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "SchoolYears",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Courses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Adult",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Enum",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgeTypeId",
                table: "AgeTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AgeTypes_AgeTypeId",
                table: "AgeTypes",
                column: "AgeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AgeTypes_AgeTypes_AgeTypeId",
                table: "AgeTypes",
                column: "AgeTypeId",
                principalTable: "AgeTypes",
                principalColumn: "Id");
        }
    }
}
