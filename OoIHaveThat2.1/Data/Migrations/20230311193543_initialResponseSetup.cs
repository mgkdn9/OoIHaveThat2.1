using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OoIHaveThat2._1.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialResponseSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeekerUserId = table.Column<int>(type: "int", nullable: false),
                    OwnerUserId = table.Column<int>(type: "int", nullable: false),
                    ToolRequestId = table.Column<int>(type: "int", nullable: false),
                    PriceCounterOffer = table.Column<double>(type: "float", nullable: false),
                    PriceCounterOfferCounter = table.Column<double>(type: "float", nullable: false),
                    DistanceBetween = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Response");
        }
    }
}
