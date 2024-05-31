using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFsolution.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Doctor_PK", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdMedicament_PK", x => x.IdMedicament);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    IdPatient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdPatient_PK", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    RerfreshTokenExpiration = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("User_PK", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPatient = table.Column<int>(type: "int", nullable: false),
                    IdDoctor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("IdPrescription_PK", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "Doctor_Prescription_FK",
                        column: x => x.IdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor");
                    table.ForeignKey(
                        name: "Patient_Prescription_FK",
                        column: x => x.IdPatient,
                        principalTable: "Patient",
                        principalColumn: "IdPatient");
                });

            migrationBuilder.CreateTable(
                name: "Prescription_Medicament",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(type: "int", nullable: false),
                    IdPrescription = table.Column<int>(type: "int", nullable: false),
                    Dose = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrescriptionMedicamend_PK", x => new { x.IdMedicament, x.IdPrescription });
                    table.ForeignKey(
                        name: "Medicament_Prescription_FK",
                        column: x => x.IdMedicament,
                        principalTable: "Medicament",
                        principalColumn: "IdMedicament");
                    table.ForeignKey(
                        name: "Prescription_Medicament_FK",
                        column: x => x.IdPrescription,
                        principalTable: "Prescription",
                        principalColumn: "IdPrescription");
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe" },
                    { 2, "jane.smith@example.com", "Jane", "Smith" },
                    { 3, "alice.johnson@example.com", "Alice", "Johnson" },
                    { 4, "robert.brown@example.com", "Robert", "Brown" },
                    { 5, "emily.davis@example.com", "Emily", "Davis" },
                    { 6, "michael.wilson@example.com", "Michael", "Wilson" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Used to treat mild to moderate pain and fever.", "Paracetamol", "Analgesic" },
                    { 2, "Antibiotic used to treat various bacterial infections.", "Amoxicillin", "Antibiotic" },
                    { 3, "Used to treat type 2 diabetes.", "Metformin", "Antidiabetic" },
                    { 4, "Used to treat high blood pressure and heart failure.", "Lisinopril", "ACE Inhibitor" },
                    { 5, "Used to lower cholesterol and triglyceride levels.", "Atorvastatin", "Statin" },
                    { 6, "Used to treat or prevent bronchospasm.", "Albuterol", "Bronchodilator" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe" },
                    { 2, new DateTime(1995, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Smith" },
                    { 3, new DateTime(1987, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Johnson" },
                    { 4, new DateTime(2000, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", "Brown" },
                    { 5, new DateTime(1970, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", "Davis" },
                    { 6, new DateTime(1985, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "Wilson" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4744), new DateTime(2024, 8, 29, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4786), 1, 2 },
                    { 2, new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 7, 30, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4795), 1, 3 },
                    { 3, new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4797), new DateTime(2024, 9, 28, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4799), 4, 4 },
                    { 4, new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4802), new DateTime(2024, 8, 29, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4803), 4, 2 },
                    { 5, new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 6, 30, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4807), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "2 pills in am and pm", 200 },
                    { 2, 1, "2 pills in am and pm", 250 },
                    { 2, 2, "2 pills in am and pm", 250 },
                    { 3, 3, "2 pills in am and pm", 250 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Email",
                table: "Doctor",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdDoctor",
                table: "Prescription",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdPatient",
                table: "Prescription",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                table: "Prescription_Medicament",
                column: "IdPrescription");

            migrationBuilder.CreateIndex(
                name: "IX_User_Login",
                table: "User",
                column: "Login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescription_Medicament");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Medicament");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
