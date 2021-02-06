using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterpriseSystemsDevelopment_EPortfolio.Data.Migrations
{
    public partial class AddedApprenticeToTemplates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Template_Apprentices_ApprenticeId",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Evidence",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Apprentices");

            migrationBuilder.AlterColumn<int>(
                name: "ApprenticeId",
                table: "Template",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Template_Apprentices_ApprenticeId",
                table: "Template",
                column: "ApprenticeId",
                principalTable: "Apprentices",
                principalColumn: "ApprenticeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Template_Apprentices_ApprenticeId",
                table: "Template");

            migrationBuilder.AlterColumn<int>(
                name: "ApprenticeId",
                table: "Template",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Evidence",
                table: "Template",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Template",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Apprentices",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Template_Apprentices_ApprenticeId",
                table: "Template",
                column: "ApprenticeId",
                principalTable: "Apprentices",
                principalColumn: "ApprenticeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
