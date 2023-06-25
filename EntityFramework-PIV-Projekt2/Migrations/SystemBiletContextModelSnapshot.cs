﻿// <auto-generated />
using System;
using EntityFramework_PIV_Projekt2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFramework_PIV_Projekt2.Migrations
{
    [DbContext(typeof(SystemBiletContext))]
    partial class SystemBiletContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.AdresModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KodPocztowy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Kraj")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Miasto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumerBudynku")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ulica")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Adres");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.BiletModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Miejsce")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rodzaj")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WydarzenieId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WydarzenieId");

                    b.ToTable("Bilety");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.KlienciBiletyTransakcjeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BiletId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataZakupu")
                        .HasColumnType("TEXT");

                    b.Property<int>("IloscZakupionychBiletow")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KlientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MetodaPlatnosci")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RabatKod")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RezerwacjaId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BiletId");

                    b.HasIndex("KlientId");

                    b.HasIndex("RabatKod");

                    b.HasIndex("RezerwacjaId");

                    b.ToTable("KlienciBiletyTransakcje");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.KlientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdresId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataUrodzenia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Imie")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("TEXT");

                    b.Property<string>("Plec")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdresId");

                    b.ToTable("Klienci");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.MiejsceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdresId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazwaObiektu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("ZdjecieObiektu")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("AdresId");

                    b.ToTable("Miejsca");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.OcenaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("KlientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Komentarz")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Ocena")
                        .HasColumnType("TEXT");

                    b.Property<int>("WydarzenieId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KlientId");

                    b.HasIndex("WydarzenieId");

                    b.ToTable("Oceny");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.OrganizatorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdresId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NazwaFirmy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdresId");

                    b.ToTable("Organizatorzy");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.RabatModel", b =>
                {
                    b.Property<string>("Kod")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Znizka")
                        .HasColumnType("TEXT");

                    b.HasKey("Kod");

                    b.ToTable("Rabaty");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.RezerwacjaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CenaRezerwacji")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataRezerwacji")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DlugoscRezerwacji")
                        .HasColumnType("TEXT");

                    b.Property<int>("KlientId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KlientId");

                    b.ToTable("Rezerwacje");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.WydarzenieModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CenaBiletu")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("IloscBiletow")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MiejsceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OrganizatorId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Plakat")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("MiejsceId");

                    b.HasIndex("OrganizatorId");

                    b.ToTable("Wydarzenia");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.BiletModel", b =>
                {
                    b.HasOne("EntityFramework_PIV_Projekt2.WydarzenieModel", "Wydarzenie")
                        .WithMany("Bilet")
                        .HasForeignKey("WydarzenieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wydarzenie");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.KlienciBiletyTransakcjeModel", b =>
                {
                    b.HasOne("EntityFramework_PIV_Projekt2.BiletModel", "Bilet")
                        .WithMany("KlienciBiletyTransakcje")
                        .HasForeignKey("BiletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework_PIV_Projekt2.KlientModel", "Klient")
                        .WithMany("Transakcje")
                        .HasForeignKey("KlientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework_PIV_Projekt2.RabatModel", "Rabat")
                        .WithMany("KlienciBiletyTransakcje")
                        .HasForeignKey("RabatKod");

                    b.HasOne("EntityFramework_PIV_Projekt2.RezerwacjaModel", "Rezerwacja")
                        .WithMany("Transakcje")
                        .HasForeignKey("RezerwacjaId");

                    b.Navigation("Bilet");

                    b.Navigation("Klient");

                    b.Navigation("Rabat");

                    b.Navigation("Rezerwacja");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.KlientModel", b =>
                {
                    b.HasOne("EntityFramework_PIV_Projekt2.AdresModel", "Adres")
                        .WithMany("Klienci")
                        .HasForeignKey("AdresId");

                    b.Navigation("Adres");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.MiejsceModel", b =>
                {
                    b.HasOne("EntityFramework_PIV_Projekt2.AdresModel", "Adres")
                        .WithMany("Miejsca")
                        .HasForeignKey("AdresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adres");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.OcenaModel", b =>
                {
                    b.HasOne("EntityFramework_PIV_Projekt2.KlientModel", "Klient")
                        .WithMany("Oceny")
                        .HasForeignKey("KlientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework_PIV_Projekt2.WydarzenieModel", "Wydarzenie")
                        .WithMany("Ocenies")
                        .HasForeignKey("WydarzenieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klient");

                    b.Navigation("Wydarzenie");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.OrganizatorModel", b =>
                {
                    b.HasOne("EntityFramework_PIV_Projekt2.AdresModel", "Adres")
                        .WithMany("Organizatorzy")
                        .HasForeignKey("AdresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adres");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.RezerwacjaModel", b =>
                {
                    b.HasOne("EntityFramework_PIV_Projekt2.KlientModel", "Klient")
                        .WithMany("Rezerwacje")
                        .HasForeignKey("KlientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klient");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.WydarzenieModel", b =>
                {
                    b.HasOne("EntityFramework_PIV_Projekt2.MiejsceModel", "Miejsce")
                        .WithMany("Wydarzenia")
                        .HasForeignKey("MiejsceId");

                    b.HasOne("EntityFramework_PIV_Projekt2.OrganizatorModel", "Organizator")
                        .WithMany("Wydarzenia")
                        .HasForeignKey("OrganizatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miejsce");

                    b.Navigation("Organizator");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.AdresModel", b =>
                {
                    b.Navigation("Klienci");

                    b.Navigation("Miejsca");

                    b.Navigation("Organizatorzy");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.BiletModel", b =>
                {
                    b.Navigation("KlienciBiletyTransakcje");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.KlientModel", b =>
                {
                    b.Navigation("Oceny");

                    b.Navigation("Rezerwacje");

                    b.Navigation("Transakcje");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.MiejsceModel", b =>
                {
                    b.Navigation("Wydarzenia");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.OrganizatorModel", b =>
                {
                    b.Navigation("Wydarzenia");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.RabatModel", b =>
                {
                    b.Navigation("KlienciBiletyTransakcje");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.RezerwacjaModel", b =>
                {
                    b.Navigation("Transakcje");
                });

            modelBuilder.Entity("EntityFramework_PIV_Projekt2.WydarzenieModel", b =>
                {
                    b.Navigation("Bilet");

                    b.Navigation("Ocenies");
                });
#pragma warning restore 612, 618
        }
    }
}
