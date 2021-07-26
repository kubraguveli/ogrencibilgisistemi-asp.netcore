using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama2.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OgrenciAdresBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adres1 = table.Column<string>(nullable: true),
                    Adres2 = table.Column<string>(nullable: true),
                    Semt = table.Column<string>(nullable: true),
                    PostaKodu = table.Column<string>(nullable: true),
                    Sehir = table.Column<string>(nullable: true),
                    Statu = table.Column<string>(nullable: true),
                    Telefon1 = table.Column<string>(nullable: true),
                    Telefon2 = table.Column<string>(nullable: true),
                    Eposta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciAdresBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciAileBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnneBabaDurum = table.Column<string>(nullable: true),
                    KiminleKaliyor = table.Column<string>(nullable: true),
                    KardesSayisi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciAileBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciOkulBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OgrenciNo = table.Column<string>(nullable: true),
                    Sınıf = table.Column<string>(nullable: true),
                    OgrenciTipi = table.Column<string>(nullable: true),
                    Okul = table.Column<string>(nullable: true),
                    OncekiOkul = table.Column<string>(nullable: true),
                    AyrilmaNedeni = table.Column<string>(nullable: true),
                    AboneDurumu = table.Column<string>(nullable: true),
                    ServisNo = table.Column<string>(nullable: true),
                    OdaNo = table.Column<string>(nullable: true),
                    YatakNo = table.Column<string>(nullable: true),
                    Notlar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciOkulBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Donem = table.Column<string>(nullable: true),
                    Ad = table.Column<string>(nullable: false),
                    Soyad = table.Column<string>(nullable: false),
                    Cinsiyet = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<string>(nullable: true),
                    DogumYeri = table.Column<string>(nullable: true),
                    KanGrubu = table.Column<string>(nullable: true),
                    SilinmeTarihi = table.Column<string>(nullable: true),
                    OgrenciAdresBilgiId = table.Column<int>(nullable: false),
                    OgrenciAileBilgiId = table.Column<int>(nullable: false),
                    OgrenciOkulBilgiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciBilgileri_OgrenciAdresBilgileri_OgrenciAdresBilgiId",
                        column: x => x.OgrenciAdresBilgiId,
                        principalTable: "OgrenciAdresBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciBilgileri_OgrenciAileBilgileri_OgrenciAileBilgiId",
                        column: x => x.OgrenciAileBilgiId,
                        principalTable: "OgrenciAileBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciBilgileri_OgrenciOkulBilgileri_OgrenciOkulBilgiId",
                        column: x => x.OgrenciOkulBilgiId,
                        principalTable: "OgrenciOkulBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciBilgileri_OgrenciAdresBilgiId",
                table: "OgrenciBilgileri",
                column: "OgrenciAdresBilgiId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciBilgileri_OgrenciAileBilgiId",
                table: "OgrenciBilgileri",
                column: "OgrenciAileBilgiId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciBilgileri_OgrenciOkulBilgiId",
                table: "OgrenciBilgileri",
                column: "OgrenciOkulBilgiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrenciBilgileri");

            migrationBuilder.DropTable(
                name: "OgrenciAdresBilgileri");

            migrationBuilder.DropTable(
                name: "OgrenciAileBilgileri");

            migrationBuilder.DropTable(
                name: "OgrenciOkulBilgileri");
        }
    }
}
