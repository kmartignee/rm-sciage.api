using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rm_sciage.persistance.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RMS_T_SITE_STE",
                columns: table => new
                {
                    STE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    STE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STE_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STE_CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STE_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STE_ZIP_CODE = table.Column<int>(type: "int", nullable: false),
                    STE_STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STE_CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STE_LAST_MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMS_T_SITE_STE", x => x.STE_ID);
                });

            migrationBuilder.CreateTable(
                name: "RMS_T_USER_USR",
                columns: table => new
                {
                    USR_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USR_LAST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USR_FIRST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USR_EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USR_PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USR_PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USR_BIRTH_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USR_SKILLS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USR_IS_ADMIN = table.Column<bool>(type: "bit", nullable: false),
                    USR_CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USR_UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMS_T_USER_USR", x => x.USR_ID);
                });

            migrationBuilder.CreateTable(
                name: "RMS_T_POINTING_PTG",
                columns: table => new
                {
                    PTG_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USR_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PTG_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PTG_IS_DRIVER = table.Column<bool>(type: "bit", nullable: false),
                    PTG_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PTG_CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PTG_LAST_MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMS_T_POINTING_PTG", x => x.PTG_ID);
                    table.ForeignKey(
                        name: "FK_RMS_T_POINTING_PTG_RMS_T_USER_USR_USR_ID",
                        column: x => x.USR_ID,
                        principalTable: "RMS_T_USER_USR",
                        principalColumn: "USR_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RMS_T_CLOCKING_CLK",
                columns: table => new
                {
                    CLK_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CLK_IS_AM = table.Column<bool>(type: "bit", nullable: false),
                    CLK_ARRIVAL_TIME = table.Column<TimeSpan>(type: "time", nullable: false),
                    CLK_DEPARTURE_TIME = table.Column<TimeSpan>(type: "time", nullable: false),
                    CLK_POINTING_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CLK_CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CLK_LAST_MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMS_T_CLOCKING_CLK", x => x.CLK_ID);
                    table.ForeignKey(
                        name: "FK_RMS_T_CLOCKING_CLK_RMS_T_POINTING_PTG_CLK_POINTING_ID",
                        column: x => x.CLK_POINTING_ID,
                        principalTable: "RMS_T_POINTING_PTG",
                        principalColumn: "PTG_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RMS_TR_POINTING_SITE",
                columns: table => new
                {
                    PTG_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SITE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMS_TR_POINTING_SITE", x => new { x.PTG_ID, x.SITE_ID });
                    table.ForeignKey(
                        name: "FK_RMS_TR_POINTING_SITE_RMS_T_POINTING_PTG_PTG_ID",
                        column: x => x.PTG_ID,
                        principalTable: "RMS_T_POINTING_PTG",
                        principalColumn: "PTG_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RMS_TR_POINTING_SITE_RMS_T_SITE_STE_SITE_ID",
                        column: x => x.SITE_ID,
                        principalTable: "RMS_T_SITE_STE",
                        principalColumn: "STE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RMS_T_CLOCKING_CLK_CLK_POINTING_ID",
                table: "RMS_T_CLOCKING_CLK",
                column: "CLK_POINTING_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RMS_T_POINTING_PTG_USR_ID",
                table: "RMS_T_POINTING_PTG",
                column: "USR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RMS_TR_POINTING_SITE_SITE_ID",
                table: "RMS_TR_POINTING_SITE",
                column: "SITE_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RMS_T_CLOCKING_CLK");

            migrationBuilder.DropTable(
                name: "RMS_TR_POINTING_SITE");

            migrationBuilder.DropTable(
                name: "RMS_T_POINTING_PTG");

            migrationBuilder.DropTable(
                name: "RMS_T_SITE_STE");

            migrationBuilder.DropTable(
                name: "RMS_T_USER_USR");
        }
    }
}
