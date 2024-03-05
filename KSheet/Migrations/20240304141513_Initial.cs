using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KSheet.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Position = table.Column<int>(type: "INTEGER", nullable: false),
                    Incident = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PdSignal = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    FdSignal = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    User = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calls", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "Address", "FdSignal", "Incident", "Notes", "PdSignal", "Position", "Time", "User" },
                values: new object[,]
                {
                    { 1, "16 Barby Park", "44", 306876, "Polarised needs-based policy", "51", 141, new DateTime(2012, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "0790 Elmside Crossing", "44", 733328, "Up-sized web-enabled instruction set", "41", 114, new DateTime(2017, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "220 Prentice Avenue", "42", 365002, "Persistent directional attitude", "54", 115, new DateTime(2001, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "85465 Buell Hill", "42", 704130, "Focused fresh-thinking moratorium", "36", 132, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "1 Ronald Regan Alley", "37", 988168, "Reverse-engineered solution-oriented installation", "14", 146, new DateTime(2008, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "09744 Tomscot Terrace", "44", 819494, "Horizontal scalable attitude", "10", 130, new DateTime(2006, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "41988 Sutherland Road", "35", 545423, "Advanced context-sensitive info-mediaries", "49", 109, new DateTime(2001, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "1598 Superior Parkway", "44", 975076, "Operative mission-critical project", "53", 130, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "8553 Bashford Trail", "41", 243339, "Sharable bottom-line contingency", "24", 124, new DateTime(1997, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "6 Burrows Crossing", "15", 849034, "Reverse-engineered 24 hour hub", "41", 133, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "9895 Del Mar Court", "40", 287667, "Organized grid-enabled matrices", "16", 143, new DateTime(2001, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "14 Comanche Place", "20", 806781, "Multi-layered leading edge local area network", "11", 158, new DateTime(2002, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "4577 Talisman Place", "34", 707657, "Down-sized coherent groupware", "31", 131, new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "11 Rieder Point", "28", 620511, "Mandatory value-added focus group", "17", 149, new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "57496 Maywood Terrace", "29", 620408, "Operative intermediate encryption", "50", 146, new DateTime(2000, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "14466 Rockefeller Hill", "27", 571289, "Cloned reciprocal circuit", "27", 141, new DateTime(2013, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "0 Dayton Crossing", "45", 476600, "Business-focused full-range firmware", "18", 104, new DateTime(2004, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "408 Shelley Court", "19", 219875, "Implemented well-modulated alliance", "46", 150, new DateTime(2014, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "6216 Dorton Center", "34", 767288, "Inverse contextually-based process improvement", "51", 160, new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "82 Dovetail Road", "30", 743809, "De-engineered value-added software", "17", 120, new DateTime(1996, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "5960 Scofield Place", "47", 303199, "Optimized heuristic moderator", "26", 129, new DateTime(2015, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, "76548 Summit Parkway", "32", 429386, "Assimilated empowering process improvement", "17", 151, new DateTime(2000, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, "65 Iowa Way", "35", 125483, "Profit-focused full-range open system", "18", 154, new DateTime(2016, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, "1 Golf Road", "25", 916552, "Versatile optimal protocol", "22", 137, new DateTime(1998, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, "79 Bluestem Hill", "32", 895954, "Versatile homogeneous emulation", "19", 147, new DateTime(2005, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, "29 Crowley Center", "49", 868575, "Organic 4th generation service-desk", "28", 126, new DateTime(2001, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, "324 Gateway Terrace", "44", 246925, "Advanced national implementation", "10", 122, new DateTime(2014, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, "316 Knutson Junction", "43", 759686, "Automated intangible encryption", "47", 111, new DateTime(2016, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, "2558 Sauthoff Parkway", "26", 204818, "Enterprise-wide content-based pricing structure", "51", 142, new DateTime(2003, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, "276 Crowley Road", "20", 602076, "Right-sized needs-based application", "17", 124, new DateTime(2002, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, "135 Helena Crossing", "33", 963527, "Vision-oriented stable challenge", "30", 113, new DateTime(1997, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, "542 Dahle Terrace", "23", 293820, "Grass-roots bi-directional task-force", "50", 150, new DateTime(2010, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, "86 Hagan Road", "37", 884891, "Self-enabling intermediate data-warehouse", "47", 143, new DateTime(2013, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, "2022 Sutteridge Court", "36", 560421, "Polarised multi-tasking pricing structure", "37", 137, new DateTime(1995, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, "9408 Butternut Parkway", "41", 235074, "Upgradable value-added analyzer", "38", 142, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, "8680 Cascade Junction", "30", 638378, "Proactive client-server adapter", "16", 128, new DateTime(2017, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, "04806 Monument Place", "44", 515460, "Reduced 24 hour software", "35", 124, new DateTime(2012, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, "418 Pine View Street", "39", 857433, "Profit-focused secondary frame", "44", 155, new DateTime(2013, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, "14074 Blackbird Pass", "18", 594107, "Object-based upward-trending paradigm", "36", 160, new DateTime(2004, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, "33 Mockingbird Way", "18", 189863, "User-centric mission-critical capability", "54", 101, new DateTime(2014, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, "88779 Helena Place", "17", 287843, "Open-source maximized initiative", "37", 130, new DateTime(1998, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, "23592 Monterey Center", "15", 340306, "Cloned national orchestration", "30", 143, new DateTime(2017, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, "24 Emmet Street", "49", 873478, "Function-based empowering portal", "31", 141, new DateTime(2011, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, "64636 East Point", "32", 182172, "Switchable uniform emulation", "37", 141, new DateTime(2002, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, "48 Nevada Terrace", "16", 546911, "Up-sized web-enabled parallelism", "45", 102, new DateTime(1996, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, "364 Laurel Point", "27", 388000, "Total needs-based portal", "50", 136, new DateTime(2004, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, "79741 Dahle Pass", "33", 839263, "Function-based discrete throughput", "55", 160, new DateTime(2004, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, "541 Northridge Point", "22", 777107, "Pre-emptive next generation open system", "21", 155, new DateTime(2009, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, "7 Tony Junction", "22", 915877, "Triple-buffered stable groupware", "43", 116, new DateTime(1998, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, "927 Manufacturers Lane", "24", 362449, "Focused optimal time-frame", "40", 150, new DateTime(2018, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, "56244 Charing Cross Drive", "19", 344237, "Triple-buffered 6th generation flexibility", "25", 133, new DateTime(2004, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, "3514 Southridge Point", "24", 505289, "Profit-focused leading edge productivity", "53", 157, new DateTime(2014, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, "771 Mallory Street", "26", 906690, "Devolved value-added success", "21", 152, new DateTime(2008, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, "13307 Magdeline Terrace", "39", 258410, "Extended value-added migration", "27", 158, new DateTime(2000, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, "7 Claremont Circle", "19", 862893, "Open-source local knowledge user", "14", 150, new DateTime(2002, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, "63 Donald Plaza", "23", 984681, "User-centric client-server core", "36", 116, new DateTime(2018, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, "7132 Upham Center", "29", 984292, "Intuitive heuristic extranet", "27", 138, new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, "38623 Petterle Terrace", "34", 287572, "Pre-emptive hybrid budgetary management", "41", 132, new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, "37197 Pleasure Way", "49", 561248, "Diverse dynamic migration", "41", 152, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, "21 Anderson Center", "24", 625114, "Face to face regional secured line", "41", 156, new DateTime(1997, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 61, "77 Garrison Hill", "37", 749999, "Customer-focused reciprocal productivity", "44", 104, new DateTime(2007, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 62, "98874 Warbler Court", "49", 773200, "Quality-focused motivating attitude", "51", 137, new DateTime(2001, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 63, "5 Merchant Place", "49", 160597, "Reduced 24 hour website", "55", 130, new DateTime(2013, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 64, "7 Forest Run Alley", "22", 705657, "Programmable exuding budgetary management", "27", 144, new DateTime(1999, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 65, "793 Sage Junction", "21", 481306, "Fundamental foreground product", "19", 123, new DateTime(1995, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 66, "0782 Fremont Park", "48", 789659, "User-centric executive superstructure", "18", 150, new DateTime(2008, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 67, "501 Walton Lane", "15", 449683, "Extended homogeneous toolset", "27", 119, new DateTime(2018, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 68, "104 Debra Lane", "36", 108753, "Mandatory coherent intranet", "47", 107, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 69, "71881 Valley Edge Court", "47", 213963, "Versatile maximized strategy", "46", 124, new DateTime(2005, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 70, "8 Maple Center", "45", 906827, "Front-line grid-enabled interface", "54", 117, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 71, "737 Basil Center", "44", 285726, "Extended dynamic software", "17", 138, new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 72, "15 Arkansas Hill", "40", 444584, "Versatile intangible extranet", "24", 137, new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 73, "65416 Bellgrove Hill", "43", 227531, "Versatile bifurcated matrices", "19", 142, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 74, "943 Bunting Street", "23", 312959, "Face to face zero tolerance customer loyalty", "24", 143, new DateTime(1996, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 75, "6 Merchant Avenue", "42", 970189, "Pre-emptive discrete data-warehouse", "25", 128, new DateTime(2020, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 76, "92658 Commercial Terrace", "29", 135922, "Realigned bottom-line projection", "42", 160, new DateTime(2016, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 77, "17605 Wayridge Road", "19", 686952, "Enhanced optimizing functionalities", "22", 145, new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 78, "5918 Messerschmidt Trail", "23", 363085, "Managed dynamic projection", "30", 150, new DateTime(2015, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 79, "0196 Packers Avenue", "31", 197103, "Virtual bifurcated throughput", "43", 118, new DateTime(2007, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 80, "66 Bay Trail", "33", 608439, "Synergized fresh-thinking alliance", "23", 148, new DateTime(2004, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 81, "082 Little Fleur Hill", "38", 912076, "Multi-layered empowering secured line", "18", 149, new DateTime(2017, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 82, "433 Nova Way", "25", 431833, "Stand-alone transitional installation", "53", 121, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 83, "08414 Vernon Trail", "49", 848406, "Robust methodical moratorium", "48", 116, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 84, "3327 Mayfield Pass", "18", 170695, "Profit-focused 24 hour toolset", "16", 156, new DateTime(2017, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 85, "32717 Melby Terrace", "44", 680604, "Managed dedicated implementation", "31", 136, new DateTime(2008, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 86, "0374 Ruskin Plaza", "22", 523648, "Decentralized client-server interface", "12", 140, new DateTime(1997, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 87, "84450 Evergreen Way", "42", 355088, "Quality-focused disintermediate structure", "46", 137, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 88, "5765 American Point", "15", 871204, "Decentralized bandwidth-monitored circuit", "16", 156, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 89, "9563 Ruskin Court", "46", 471207, "Organic asynchronous customer loyalty", "45", 105, new DateTime(2000, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 90, "6 Mallory Hill", "42", 614140, "Integrated context-sensitive utilisation", "22", 145, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 91, "29246 Roxbury Park", "37", 124172, "Focused zero tolerance complexity", "49", 147, new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 92, "5805 Dexter Place", "15", 929592, "Front-line discrete policy", "20", 112, new DateTime(2012, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 93, "768 Maywood Avenue", "18", 986208, "Assimilated high-level ability", "43", 144, new DateTime(2013, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 94, "85 Homewood Lane", "40", 966315, "Horizontal asynchronous superstructure", "51", 110, new DateTime(2012, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 95, "47962 Fuller Terrace", "15", 374980, "Progressive exuding flexibility", "13", 107, new DateTime(1999, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 96, "41223 Calypso Circle", "42", 399710, "Enterprise-wide dynamic analyzer", "49", 149, new DateTime(2008, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 97, "7 Eagan Trail", "15", 395087, "Quality-focused discrete strategy", "16", 122, new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 98, "6653 Sage Avenue", "34", 431106, "Future-proofed logistical protocol", "53", 159, new DateTime(2011, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 99, "2159 Cordelia Park", "25", 183348, "Configurable asynchronous archive", "16", 126, new DateTime(2000, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 100, "05582 Larry Hill", "49", 625218, "Re-engineered heuristic approach", "53", 123, new DateTime(2001, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calls");
        }
    }
}
