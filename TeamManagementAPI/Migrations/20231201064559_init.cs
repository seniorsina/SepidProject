using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeamManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstablishmentِDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TeamType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysLits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fl = table.Column<int>(type: "int", nullable: false),
                    Val = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysLits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysLits_Fls_Fl",
                        column: x => x.Fl,
                        principalTable: "Fls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ContractStartDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ContractEndDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Player_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Fls",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "color" },
                    { 2, "teamType" },
                    { 3, "grade" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "EstablishmentِDate", "FirstColor", "Grade", "Name", "SecondColor", "TeamType" },
                values: new object[,]
                {
                    { 1, null, "1390/01/01", "قرمز", "لیگ برتر", "تیم 1", "سفید", "فوتبال" },
                    { 2, null, "1391/02/02", "آبی", "دسته اول", "تیم 2", "سیاه", "بسکتبال" },
                    { 3, null, "1392/03/03", "سفید", "دسته دوم", "تیم 3", "زرد", "والیبال" },
                    { 4, null, "1393/04/04", "مشکلی", "لیگ برتر", "تیم 4", "نارنجی", "فوتبال" },
                    { 5, null, "1394/05/05", "صورتی", "دسته اول", "تیم 5", "قهوه ای", "بسکتبال" },
                    { 6, null, "1395/06/06", "خاکستری", "دسته دوم", "تیم 6", "بنفش", "والیبال" },
                    { 7, null, "1396/07/07", "سفید", "لیگ برتر", "تیم 7", "قرمز", "هندبال" },
                    { 8, null, "1397/08/08", "سیاه", "دسته اول", "تیم 8", "آبی", "بسکتبال" },
                    { 9, null, "1398/09/09", "زرد", "دسته دوم", "تیم 9", "سبز", "والیبال" },
                    { 10, null, "1399/10/10", "مشکی", "لیگ برتر", "تیم 10", "سبز", "فوتبال" }
                });

            migrationBuilder.InsertData(
                table: "SysLits",
                columns: new[] { "Id", "Fl", "Val" },
                values: new object[,]
                {
                    { 1, 1, "قرمز" },
                    { 2, 1, "سفید" },
                    { 3, 1, "آبی" },
                    { 4, 1, "مشکی" },
                    { 5, 1, "ژرد" },
                    { 6, 2, "فوتبال" },
                    { 7, 2, "بسکتبال" },
                    { 8, 2, "والیبال" },
                    { 9, 2, "هندبال" },
                    { 10, 3, "لیگ برتر" },
                    { 11, 3, "دسته یک" },
                    { 12, 3, "دسته دوم" },
                    { 13, 3, "دسته سوم" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_SysLits_Fl",
                table: "SysLits",
                column: "Fl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "SysLits");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Fls");
        }
    }
}
