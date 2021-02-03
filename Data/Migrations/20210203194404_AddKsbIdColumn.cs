using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterpriseSystemsDevelopment_EPortfolio.Data.Migrations
{
    public partial class AddKsbIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Evidence",
                table: "Template",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KsbKey",
                table: "Template",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KsbKey",
                table: "Template");

            migrationBuilder.AlterColumn<int>(
                name: "Evidence",
                table: "Template",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }
    }
}
