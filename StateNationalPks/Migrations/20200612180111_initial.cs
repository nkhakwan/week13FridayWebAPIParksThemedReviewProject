using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StateNationalPks.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ImageUrl", "Name", "Rating", "Type" },
                values: new object[,]
                {
                    { 1, "excellent place to visit", "https://www.themediterraneantraveller.com/wp-content/uploads/2018/11/greece-heraklion-00032.jpg", "RockyMountain National Park", 4, "National" },
                    { 2, "A good weekend kayaking outlet in Tigard", "https://cdn.travelpulse.com/images/65aaedf4-a957-df11-b491-006073e71405/c8f899f1-a4af-4ea3-b5dd-447ebbaeb40e/630x355.jpg", "cooks", 8, "State" },
                    { 3, " All red rocks", "https://www.toursbylocals.com/images/guides/46/46460/202027064423775.jpg", "Utah arches park", 3, "National" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Token", "Username" },
                values: new object[,]
                {
                    { 1, "test", null, "Leilani" },
                    { 2, "test", null, "Travis" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
