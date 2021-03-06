﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QnSTravelCount.Logic.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "App");

            migrationBuilder.CreateTable(
                name: "Travel",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Designation = table.Column<string>(maxLength: 256, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Currency = table.Column<string>(maxLength: 10, nullable: false),
                    Friends = table.Column<string>(maxLength: 1024, nullable: false),
                    Category = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    TravelId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 128, nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Friend = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expense_Travel_TravelId",
                        column: x => x.TravelId,
                        principalSchema: "App",
                        principalTable: "Travel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expense_TravelId",
                schema: "App",
                table: "Expense",
                column: "TravelId");

            migrationBuilder.CreateIndex(
                name: "IX_Travel_Designation",
                schema: "App",
                table: "Travel",
                column: "Designation",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expense",
                schema: "App");

            migrationBuilder.DropTable(
                name: "Travel",
                schema: "App");
        }
    }
}
