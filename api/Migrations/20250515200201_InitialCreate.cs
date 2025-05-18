using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Win = table.Column<bool>(type: "boolean", nullable: false),
                    Mac = table.Column<bool>(type: "boolean", nullable: false),
                    Linux = table.Column<bool>(type: "boolean", nullable: false),
                    Rating = table.Column<string>(type: "text", nullable: true),
                    PositiveRatio = table.Column<int>(type: "integer", nullable: false),
                    UserReviews = table.Column<int>(type: "integer", nullable: false),
                    PriceFinal = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceOriginal = table.Column<decimal>(type: "numeric", nullable: false),
                    Discount = table.Column<int>(type: "integer", nullable: false),
                    SteamDeck = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.AppId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
