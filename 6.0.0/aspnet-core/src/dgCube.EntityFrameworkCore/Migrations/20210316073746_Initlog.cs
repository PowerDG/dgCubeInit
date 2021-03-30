using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace dgCube.Migrations
{
    public partial class Initlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExternalSMLogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    request_json = table.Column<string>(type: "text", nullable: true),
                    response_data = table.Column<string>(type: "text", nullable: true),
                    log_name = table.Column<string>(type: "text", nullable: true),
                    log_note = table.Column<string>(type: "text", nullable: true),
                    log_scource = table.Column<string>(type: "text", nullable: true),
                    log_level = table.Column<string>(type: "text", nullable: true),
                    created_user = table.Column<string>(type: "text", nullable: true),
                    created_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalSMLogs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalSMLogs");
        }
    }
}
