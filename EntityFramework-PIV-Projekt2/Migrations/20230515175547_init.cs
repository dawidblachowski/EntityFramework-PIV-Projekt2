using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_PIV_Projekt2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kraj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miasto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumerBudynku = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rabaty",
                columns: table => new
                {
                    Kod = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Znizka = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rabaty", x => x.Kod);
                });

            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Klienci_Adres_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adres",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Miejsca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaObiektu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZdjecieObiektu = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AdresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miejsca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Miejsca_Adres_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizatorzy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NazwaFirmy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizatorzy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizatorzy_Adres_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezerwacje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRezerwacji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DlugoscRezerwacji = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CenaRezerwacji = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    KlientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezerwacje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezerwacje_Klienci_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klienci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wydarzenia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CenaBiletu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IloscBiletow = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plakat = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MiejsceId = table.Column<int>(type: "int", nullable: true),
                    OrganizatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wydarzenia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wydarzenia_Miejsca_MiejsceId",
                        column: x => x.MiejsceId,
                        principalTable: "Miejsca",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Wydarzenia_Organizatorzy_OrganizatorId",
                        column: x => x.OrganizatorId,
                        principalTable: "Organizatorzy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bilety",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rodzaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miejsce = table.Column<int>(type: "int", nullable: true),
                    WydarzenieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilety", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bilety_Wydarzenia_WydarzenieId",
                        column: x => x.WydarzenieId,
                        principalTable: "Wydarzenia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oceny",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Komentarz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KlientId = table.Column<int>(type: "int", nullable: false),
                    WydarzenieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oceny", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oceny_Klienci_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klienci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oceny_Wydarzenia_WydarzenieId",
                        column: x => x.WydarzenieId,
                        principalTable: "Wydarzenia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transakcje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetodaPlatnosci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataZakupu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IloscZakupionychBiletow = table.Column<int>(type: "int", nullable: false),
                    BiletId = table.Column<int>(type: "int", nullable: false),
                    KlientId = table.Column<int>(type: "int", nullable: false),
                    RezerwacjaId = table.Column<int>(type: "int", nullable: true),
                    RabatKod = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transakcje_Bilety_BiletId",
                        column: x => x.BiletId,
                        principalTable: "Bilety",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transakcje_Klienci_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klienci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transakcje_Rabaty_RabatKod",
                        column: x => x.RabatKod,
                        principalTable: "Rabaty",
                        principalColumn: "Kod");
                    table.ForeignKey(
                        name: "FK_Transakcje_Rezerwacje_RezerwacjaId",
                        column: x => x.RezerwacjaId,
                        principalTable: "Rezerwacje",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_WydarzenieId",
                table: "Bilety",
                column: "WydarzenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Klienci_AdresId",
                table: "Klienci",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Miejsca_AdresId",
                table: "Miejsca",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Oceny_KlientId",
                table: "Oceny",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Oceny_WydarzenieId",
                table: "Oceny",
                column: "WydarzenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizatorzy_AdresId",
                table: "Organizatorzy",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezerwacje_KlientId",
                table: "Rezerwacje",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcje_BiletId",
                table: "Transakcje",
                column: "BiletId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcje_KlientId",
                table: "Transakcje",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcje_RabatKod",
                table: "Transakcje",
                column: "RabatKod");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcje_RezerwacjaId",
                table: "Transakcje",
                column: "RezerwacjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenia_MiejsceId",
                table: "Wydarzenia",
                column: "MiejsceId");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenia_OrganizatorId",
                table: "Wydarzenia",
                column: "OrganizatorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oceny");

            migrationBuilder.DropTable(
                name: "Transakcje");

            migrationBuilder.DropTable(
                name: "Bilety");

            migrationBuilder.DropTable(
                name: "Rabaty");

            migrationBuilder.DropTable(
                name: "Rezerwacje");

            migrationBuilder.DropTable(
                name: "Wydarzenia");

            migrationBuilder.DropTable(
                name: "Klienci");

            migrationBuilder.DropTable(
                name: "Miejsca");

            migrationBuilder.DropTable(
                name: "Organizatorzy");

            migrationBuilder.DropTable(
                name: "Adres");
        }
    }
}
