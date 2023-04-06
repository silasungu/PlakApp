using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlakApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Singer = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AlbumDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsContinued = table.Column<bool>(type: "bit", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Salers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "AlbumDate", "CreatedDate", "Discount", "IsContinued", "ModifiedDate", "Name", "Price", "Singer" },
                values: new object[] { new Guid("72b20558-443e-4018-8e0b-f3683394c5d3"), new DateTime(2023, 4, 1, 2, 12, 4, 581, DateTimeKind.Local).AddTicks(4742), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karma", 200.0, "Tarkan" });

            migrationBuilder.InsertData(
                table: "Salers",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("4a780908-450a-4930-b131-ef52eec796f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "217212Ss++", "Sila" },
                    { new Guid("b91babea-d881-488a-83ab-b684be319e02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "217212Ss++", "Sila" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Salers");
        }
    }
}
