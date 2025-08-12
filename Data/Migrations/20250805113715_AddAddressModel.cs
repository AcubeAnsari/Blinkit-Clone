using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Temp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StoreState = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StoreCountry = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StorePincode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StorePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreWhatsAppNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoreLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StoreGoogleMapsLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
