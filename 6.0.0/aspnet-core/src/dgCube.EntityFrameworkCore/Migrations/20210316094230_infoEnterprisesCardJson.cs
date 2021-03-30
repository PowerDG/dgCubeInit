using Microsoft.EntityFrameworkCore.Migrations;

namespace dgCube.Migrations
{
    public partial class infoEnterprisesCardJson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "content_yype",
                table: "ApplicationInfos",
                newName: "content_type");

            migrationBuilder.AddColumn<string>(
                name: "enterprises_card",
                table: "ApplicationInfos",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "enterprises_card",
                table: "ApplicationInfos");

            migrationBuilder.RenameColumn(
                name: "content_type",
                table: "ApplicationInfos",
                newName: "content_yype");
        }
    }
}
