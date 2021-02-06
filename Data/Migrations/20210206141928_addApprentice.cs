using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterpriseSystemsDevelopment_EPortfolio.Data.Migrations
{
    public partial class addApprentice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KSBs");

            migrationBuilder.AddColumn<int>(
                name: "ApprenticeId",
                table: "Template",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KsbType",
                table: "Template",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TemplateId",
                table: "Evidence",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Specialism",
                columns: table => new
                {
                    SpecialismId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialism", x => x.SpecialismId);
                });

            migrationBuilder.CreateTable(
                name: "Apprentices",
                columns: table => new
                {
                    ApprenticeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialismId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    JobTitle = table.Column<string>(maxLength: 20, nullable: false),
                    Employer = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apprentices", x => x.ApprenticeId);
                    table.ForeignKey(
                        name: "FK_Apprentices_Specialism_SpecialismId",
                        column: x => x.SpecialismId,
                        principalTable: "Specialism",
                        principalColumn: "SpecialismId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Template_ApprenticeId",
                table: "Template",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_Evidence_TemplateId",
                table: "Evidence",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Apprentices_SpecialismId",
                table: "Apprentices",
                column: "SpecialismId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evidence_Template_TemplateId",
                table: "Evidence",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Template_Apprentices_ApprenticeId",
                table: "Template",
                column: "ApprenticeId",
                principalTable: "Apprentices",
                principalColumn: "ApprenticeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evidence_Template_TemplateId",
                table: "Evidence");

            migrationBuilder.DropForeignKey(
                name: "FK_Template_Apprentices_ApprenticeId",
                table: "Template");

            migrationBuilder.DropTable(
                name: "Apprentices");

            migrationBuilder.DropTable(
                name: "Specialism");

            migrationBuilder.DropIndex(
                name: "IX_Template_ApprenticeId",
                table: "Template");

            migrationBuilder.DropIndex(
                name: "IX_Evidence_TemplateId",
                table: "Evidence");

            migrationBuilder.DropColumn(
                name: "ApprenticeId",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "KsbType",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "TemplateId",
                table: "Evidence");

            migrationBuilder.CreateTable(
                name: "KSBs",
                columns: table => new
                {
                    KsbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KSBs", x => x.KsbId);
                    table.ForeignKey(
                        name: "FK_KSBs_Template_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Template",
                        principalColumn: "TemplateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KSBs_TemplateId",
                table: "KSBs",
                column: "TemplateId");
        }
    }
}
