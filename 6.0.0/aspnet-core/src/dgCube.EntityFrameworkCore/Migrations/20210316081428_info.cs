using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace dgCube.Migrations
{
    public partial class info : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationInfos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    application_name = table.Column<string>(type: "text", nullable: true),
                    application_title = table.Column<string>(type: "text", nullable: true),
                    introduction = table.Column<string>(type: "text", nullable: true),
                    service_provider = table.Column<string>(type: "text", nullable: true),
                    vsrsion = table.Column<string>(type: "text", nullable: true),
                    url = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    IconUrl = table.Column<string>(type: "text", nullable: true),
                    Images = table.Column<string[]>(type: "text[]", nullable: true),
                    Videos = table.Column<string[]>(type: "text[]", nullable: true),
                    tags = table.Column<string[]>(type: "text[]", nullable: true),
                    content_ref = table.Column<string>(type: "text", nullable: true),
                    content_yype = table.Column<string>(type: "text", nullable: true),
                    created_user = table.Column<string>(type: "text", nullable: true),
                    created_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    modify_userid = table.Column<int>(type: "integer", nullable: true),
                    last_modified_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    delete_userid = table.Column<int>(type: "integer", nullable: true),
                    delete_datetime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationInfos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationInfos");
        }
    }
}
