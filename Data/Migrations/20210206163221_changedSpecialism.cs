using Microsoft.EntityFrameworkCore.Migrations;

namespace EnterpriseSystemsDevelopment_EPortfolio.Data.Migrations
{
    public partial class changedSpecialism : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apprentices_Specialism_SpecialismId",
                table: "Apprentices");

            migrationBuilder.DropTable(
                name: "Specialism");

            migrationBuilder.DropIndex(
                name: "IX_Apprentices_SpecialismId",
                table: "Apprentices");

            migrationBuilder.DropColumn(
                name: "SpecialismId",
                table: "Apprentices");

            migrationBuilder.AddColumn<int>(
                name: "Specialism",
                table: "Apprentices",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialism",
                table: "Apprentices");

            migrationBuilder.AddColumn<int>(
                name: "SpecialismId",
                table: "Apprentices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Specialism",
                columns: table => new
                {
                    SpecialismId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialism", x => x.SpecialismId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apprentices_SpecialismId",
                table: "Apprentices",
                column: "SpecialismId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apprentices_Specialism_SpecialismId",
                table: "Apprentices",
                column: "SpecialismId",
                principalTable: "Specialism",
                principalColumn: "SpecialismId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
