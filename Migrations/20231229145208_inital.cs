using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutbolcuKartlariMVC.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "takimlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_takimlar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ulkeler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ulkeler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "futbolcular",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<int>(type: "int", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Mevki = table.Column<int>(type: "int", nullable: false),
                    Pas = table.Column<byte>(type: "tinyint", nullable: false),
                    Dribbling = table.Column<byte>(type: "tinyint", nullable: false),
                    Sut = table.Column<byte>(type: "tinyint", nullable: false),
                    Defans = table.Column<byte>(type: "tinyint", nullable: false),
                    Fizik = table.Column<byte>(type: "tinyint", nullable: false),
                    Hiz = table.Column<byte>(type: "tinyint", nullable: false),
                    Degeri = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ayak = table.Column<int>(type: "int", nullable: false),
                    OrtalamaDeger = table.Column<int>(type: "int", nullable: false),
                    TakimID = table.Column<int>(type: "int", nullable: false),
                    MevkiID = table.Column<int>(type: "int", nullable: false),
                    UlkeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_futbolcular", x => x.ID);
                    table.ForeignKey(
                        name: "FK_futbolcular_takimlar_TakimID",
                        column: x => x.TakimID,
                        principalTable: "takimlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_futbolcular_ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "ulkeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "takimlar",
                columns: new[] { "ID", "TakimAdi" },
                values: new object[,]
                {
                    { 1, "Galatasaray" },
                    { 2, "Besiktas" }
                });

            migrationBuilder.InsertData(
                table: "ulkeler",
                columns: new[] { "ID", "UlkeAdi" },
                values: new object[,]
                {
                    { 1, "Uruguay" },
                    { 2, "Belçika" },
                    { 3, "Fildişi Sahili" },
                    { 4, "Arjantin" },
                    { 5, "Fas" },
                    { 6, "Fransa" },
                    { 7, "Almanya" },
                    { 8, "İspanya" },
                    { 9, "Danimarka" },
                    { 10, "Portekiz" },
                    { 11, "Türkiye" },
                    { 12, "Kolombiya" },
                    { 13, "Congo" },
                    { 14, "Brezilya" },
                    { 15, "Gana" },
                    { 16, "Cezayir" },
                    { 17, "İngiltere" },
                    { 18, "Hırvatistan" },
                    { 19, "Kosova" },
                    { 20, "Bosna Hersek" },
                    { 21, "Gambiya" },
                    { 22, "Kamerun" }
                });

            migrationBuilder.InsertData(
                table: "futbolcular",
                columns: new[] { "ID", "Ad", "Ayak", "Boy", "Defans", "Degeri", "Dribbling", "Fizik", "Hiz", "Kilo", "Mevki", "MevkiID", "OrtalamaDeger", "Pas", "Soyad", "Sut", "TakimID", "UlkeID", "Yas" },
                values: new object[,]
                {
                    { 1, "Lucas", 1, 166, (byte)79, 15000000m, (byte)80, (byte)78, (byte)76, 60, 3, 0, 82, (byte)77, "Torreira", (byte)70, 1, 1, 27 },
                    { 2, "Dries", 1, 169, (byte)40, 2600000m, (byte)83, (byte)49, (byte)76, 61, 4, 0, 81, (byte)80, "Mertens", (byte)80, 1, 2, 36 },
                    { 3, "Wilfried", 1, 180, (byte)37, 20000000m, (byte)85, (byte)76, (byte)90, 66, 4, 0, 81, (byte)72, "Zaha", (byte)78, 1, 3, 31 },
                    { 4, "Mauro", 1, 181, (byte)40, 20000000m, (byte)73, (byte)72, (byte)67, 75, 4, 0, 80, (byte)69, "Icardi", (byte)81, 1, 4, 30 },
                    { 5, "Fernando", 1, 190, (byte)51, 1500000m, (byte)77, (byte)83, (byte)76, 74, 1, 0, 80, (byte)72, "Muslera", (byte)80, 1, 1, 37 },
                    { 6, "Hakim", 2, 181, (byte)50, 15000000m, (byte)81, (byte)64, (byte)74, 65, 4, 0, 80, (byte)83, "Ziyech", (byte)75, 1, 5, 30 },
                    { 7, "Sacha", 1, 178, (byte)76, 17000000m, (byte)75, (byte)84, (byte)86, 70, 2, 0, 79, (byte)65, "Boey", (byte)55, 1, 6, 23 },
                    { 8, "Kerem", 2, 183, (byte)71, 6000000m, (byte)81, (byte)71, (byte)59, 75, 3, 0, 79, (byte)79, "Demirbay", (byte)76, 1, 7, 30 },
                    { 9, "Angelino", 2, 171, (byte)74, 11000000m, (byte)82, (byte)68, (byte)71, 69, 2, 0, 79, (byte)81, "Tasende", (byte)71, 1, 8, 26 },
                    { 10, "Tanguy", 1, 181, (byte)68, 21000000m, (byte)86, (byte)66, (byte)65, 76, 3, 0, 78, (byte)79, "Ndombele", (byte)71, 1, 6, 26 },
                    { 11, "Victor", 1, 185, (byte)79, 19000000m, (byte)66, (byte)84, (byte)64, 78, 2, 0, 78, (byte)59, "Nelsson", (byte)43, 1, 9, 25 },
                    { 12, "Sergio", 1, 181, (byte)67, 6000000m, (byte)74, (byte)62, (byte)51, 78, 3, 0, 78, (byte)82, "Oliveira", (byte)76, 1, 10, 31 },
                    { 13, "Kerem", 1, 173, (byte)38, 17000000m, (byte)79, (byte)56, (byte)84, 71, 4, 0, 77, (byte)71, "Aktürkoğlu", (byte)73, 1, 11, 25 },
                    { 14, "Abdulkerim", 2, 190, (byte)78, 7500000m, (byte)65, (byte)83, (byte)61, 80, 2, 0, 77, (byte)64, "Bardakçı", (byte)32, 1, 11, 29 },
                    { 15, "Davinson", 1, 187, (byte)77, 14000000m, (byte)64, (byte)78, (byte)73, 81, 2, 0, 77, (byte)54, "Sanchez", (byte)47, 1, 12, 27 },
                    { 16, "Cedric", 1, 182, (byte)36, 3400000m, (byte)73, (byte)63, (byte)81, 73, 4, 0, 76, (byte)66, "Bakambu", (byte)77, 1, 13, 32 },
                    { 17, "Mateus", 2, 175, (byte)41, 24000000m, (byte)79, (byte)55, (byte)81, 70, 4, 0, 76, (byte)72, "Tete", (byte)72, 1, 14, 23 },
                    { 18, "Günay", 1, 187, (byte)55, 1500000m, (byte)76, (byte)71, (byte)73, 85, 1, 0, 74, (byte)72, "Güvenç", (byte)72, 1, 11, 32 },
                    { 19, "Kaan", 1, 184, (byte)72, 3700000m, (byte)67, (byte)74, (byte)58, 84, 2, 0, 72, (byte)69, "Ayhan", (byte)53, 1, 11, 29 },
                    { 20, "Barış Alper", 1, 186, (byte)37, 5500000m, (byte)71, (byte)84, (byte)87, 72, 4, 0, 72, (byte)64, "Yılmaz", (byte)70, 1, 11, 23 },
                    { 21, "Mert", 1, 196, (byte)17, 1500000m, (byte)73, (byte)53, (byte)56, 92, 1, 0, 75, (byte)35, "Günok", (byte)22, 2, 11, 34 },
                    { 22, "Daniel", 1, 186, (byte)84, 12000000m, (byte)77, (byte)82, (byte)78, 79, 2, 0, 83, (byte)71, "Amartey", (byte)64, 2, 15, 28 },
                    { 23, "Eric", 1, 187, (byte)85, 4000000m, (byte)73, (byte)85, (byte)81, 77, 2, 0, 85, (byte)70, "Bailly", (byte)51, 2, 3, 29 },
                    { 24, "Rachid", 2, 182, (byte)28, 4000000m, (byte)81, (byte)58, (byte)71, 70, 4, 0, 78, (byte)81, "Ghezzal", (byte)72, 2, 16, 31 },
                    { 25, "Necip", 1, 180, (byte)68, 600000m, (byte)63, (byte)72, (byte)54, 72, 2, 0, 68, (byte)61, "Uysal", (byte)56, 2, 11, 32 },
                    { 26, "Gedson", 1, 183, (byte)75, 17000000m, (byte)80, (byte)77, (byte)79, 63, 3, 0, 78, (byte)76, "Fernandes", (byte)73, 2, 10, 24 },
                    { 27, "Alex Oxlade", 1, 175, (byte)67, 6000000m, (byte)81, (byte)72, (byte)78, 70, 3, 0, 77, (byte)76, "Chamberlain", (byte)74, 2, 17, 30 },
                    { 28, "Ante", 1, 185, (byte)46, 5000000m, (byte)77, (byte)77, (byte)80, 80, 4, 0, 77, (byte)72, "Rebic", (byte)77, 2, 18, 30 },
                    { 29, "Milot", 1, 277, (byte)50, 8500000m, (byte)77, (byte)73, (byte)81, 73, 3, 0, 76, (byte)71, "Rashica", (byte)75, 2, 19, 27 },
                    { 30, "Arthur", 2, 179, (byte)70, 6000000m, (byte)79, (byte)79, (byte)79, 80, 2, 0, 76, (byte)73, "Masuaku", (byte)61, 2, 13, 30 },
                    { 31, "Valentin", 1, 175, (byte)72, 6000000m, (byte)75, (byte)76, (byte)84, 75, 2, 0, 76, (byte)65, "Roiser", (byte)52, 2, 6, 27 },
                    { 32, "Amir", 1, 179, (byte)71, 8000000m, (byte)72, (byte)77, (byte)71, 70, 3, 0, 75, (byte)71, "Hadziahmetovic", (byte)60, 2, 20, 26 },
                    { 33, "Cenk", 1, 183, (byte)36, 3000000m, (byte)72, (byte)72, (byte)66, 78, 4, 0, 75, (byte)67, "Tosun", (byte)77, 2, 11, 32 },
                    { 34, "Omar", 2, 191, (byte)73, 3800000m, (byte)55, (byte)84, (byte)64, 90, 2, 0, 74, (byte)48, "Collay", (byte)31, 2, 21, 31 },
                    { 35, "Jean", 1, 189, (byte)71, 4800000m, (byte)71, (byte)82, (byte)54, 85, 3, 0, 74, (byte)70, "Onana", (byte)66, 2, 22, 23 },
                    { 36, "Salih", 1, 182, (byte)66, 5000000m, (byte)75, (byte)65, (byte)57, 80, 3, 0, 74, (byte)75, "Ucan", (byte)70, 2, 11, 29 },
                    { 37, "Ersin", 1, 195, (byte)11, 3500000m, (byte)32, (byte)40, (byte)38, 88, 1, 0, 74, (byte)20, "Destanoglu", (byte)16, 2, 11, 22 },
                    { 38, "Onur", 1, 179, (byte)64, 3800000m, (byte)70, (byte)72, (byte)77, 80, 3, 0, 70, (byte)69, "Bulut", (byte)59, 2, 11, 29 },
                    { 39, "Jackson", 1, 180, (byte)35, 4500000m, (byte)71, (byte)71, (byte)81, 80, 4, 0, 70, (byte)58, "Muleko", (byte)71, 2, 13, 24 },
                    { 40, "Umut", 2, 178, (byte)62, 4500000m, (byte)65, (byte)70, (byte)74, 73, 2, 0, 67, (byte)59, "Meras", (byte)42, 2, 11, 27 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_futbolcular_TakimID",
                table: "futbolcular",
                column: "TakimID");

            migrationBuilder.CreateIndex(
                name: "IX_futbolcular_UlkeID",
                table: "futbolcular",
                column: "UlkeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "futbolcular");

            migrationBuilder.DropTable(
                name: "takimlar");

            migrationBuilder.DropTable(
                name: "ulkeler");
        }
    }
}
