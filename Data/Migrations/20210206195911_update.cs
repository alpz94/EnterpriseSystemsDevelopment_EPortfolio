using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterpriseSystemsDevelopment_EPortfolio.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_Template_TemplateId",
                table: "Evidence");

            migrationBuilder.AlterColumn<int>(
                name: "TemplateId",
                table: "Evidence",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_Template_TemplateId",
                table: "Evidence",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_Template_TemplateId",
                table: "Evidence");

            migrationBuilder.AlterColumn<int>(
                name: "TemplateId",
                table: "Evidence",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_Template_TemplateId",
                table: "Evidence",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
