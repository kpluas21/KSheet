using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KSheet3.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "Id", "Address", "FdSignal", "Notes", "PdSignal", "Position" },
                values: new object[,]
                {
                    { 1, "7956 Summerview Alley", "30", "Multi-layered full-range hub", "28", 146 },
                    { 2, "11445 Briar Crest Road", "26", "Visionary system-worthy groupware", "55", 148 },
                    { 3, "674 Pine View Parkway", "23", "Visionary coherent archive", "53", 109 },
                    { 4, "1207 Petterle Street", "8", "Open-source empowering structure", "34", 111 },
                    { 5, "495 Bunker Hill Hill", "13", "Expanded asymmetric neural-net", "43", 122 },
                    { 6, "92831 Linden Drive", "8", "User-centric local architecture", "42", 134 },
                    { 7, "97813 Northport Crossing", "2", "Devolved reciprocal local area network", "3", 120 },
                    { 8, "4293 Novick Avenue", "10", "Fully-configurable bandwidth-monitored artificial intelligence", "12", 144 },
                    { 9, "93026 Donald Road", "31", "Open-source dedicated website", "13", 158 },
                    { 10, "70059 Redwing Lane", "5", "Focused well-modulated open system", "34", 120 },
                    { 11, "7 Spenser Crossing", "22", "Universal actuating focus group", "48", 104 },
                    { 92, "3 Buhler Avenue", "5", "Self-enabling 24 hour Graphical User Interface", "8", 146 },
                    { 93, "60465 Fordem Alley", "21", "Advanced incremental installation", "21", 102 },
                    { 94, "94565 Briar Crest Plaza", "20", "Reduced neutral installation", "16", 149 },
                    { 95, "74726 Forest Run Terrace", "32", "User-friendly high-level open architecture", "6", 143 },
                    { 96, "5 Dennis Park", "20", "Persevering modular initiative", "41", 115 },
                    { 97, "04 Union Junction", "10", "Horizontal directional matrix", "27", 107 },
                    { 98, "39205 Moulton Place", "8", "Realigned non-volatile concept", "42", 120 },
                    { 99, "26 Nancy Center", "2", "Mandatory content-based data-warehouse", "36", 144 },
                    { 100, "09348 Burrows Lane", "1", "De-engineered multi-state product", "39", 116 },
                    { 101, "24499 Miller Park", "15", "Triple-buffered homogeneous artificial intelligence", "5", 153 },
                    { 102, "1 Warrior Street", "13", "Streamlined human-resource service-desk", "24", 132 },
                    { 103, "63 Prairie Rose Plaza", "19", "User-friendly tertiary customer loyalty", "2", 112 },
                    { 104, "88 Gale Point", "23", "Future-proofed motivating capacity", "47", 137 },
                    { 105, "11343 Weeping Birch Drive", "8", "Future-proofed bottom-line toolset", "22", 113 },
                    { 106, "368 Fairview Trail", "1", "Synergistic bifurcated budgetary management", "49", 109 },
                    { 107, "61 Oxford Plaza", "30", "Polarised tangible info-mediaries", "26", 128 },
                    { 108, "67 Westend Park", "2", "Multi-tiered 3rd generation application", "38", 130 },
                    { 109, "624 Hooker Pass", "1", "Exclusive multi-tasking standardization", "53", 131 },
                    { 110, "448 Tomscot Alley", "31", "Multi-channelled actuating info-mediaries", "52", 157 },
                    { 111, "1656 Kensington Center", "7", "Persistent directional matrix", "6", 137 },
                    { 112, "59 Rusk Street", "14", "Fundamental didactic concept", "22", 123 },
                    { 113, "6 Fuller Alley", "18", "Fundamental encompassing access", "20", 146 },
                    { 114, "76747 Mendota Hill", "8", "Ergonomic zero defect throughput", "49", 133 },
                    { 115, "0393 Oxford Place", "32", "Re-engineered demand-driven framework", "19", 158 },
                    { 116, "63 Mallard Street", "8", "Re-engineered methodical parallelism", "45", 121 },
                    { 117, "54602 Garrison Court", "25", "Assimilated eco-centric challenge", "12", 148 },
                    { 118, "4 Arkansas Terrace", "2", "Decentralized leading edge portal", "38", 124 },
                    { 119, "27495 Arrowood Pass", "10", "Persevering contextually-based definition", "22", 109 },
                    { 120, "09473 Toban Circle", "23", "Fundamental analyzing secured line", "40", 106 },
                    { 121, "9 Old Shore Avenue", "5", "Switchable encompassing circuit", "7", 120 },
                    { 122, "806 Oneill Point", "19", "Expanded uniform data-warehouse", "48", 116 },
                    { 123, "80 Briar Crest Parkway", "9", "Vision-oriented 24/7 capability", "17", 154 },
                    { 124, "324 Kenwood Road", "10", "Total transitional contingency", "48", 126 },
                    { 125, "55 Fuller Terrace", "22", "Cross-group bi-directional system engine", "54", 114 },
                    { 126, "28 Farmco Point", "5", "Profound system-worthy superstructure", "48", 108 },
                    { 127, "1 Briar Crest Place", "14", "Synergistic scalable protocol", "53", 120 },
                    { 128, "1978 Hollow Ridge Hill", "21", "Upgradable human-resource framework", "40", 117 },
                    { 129, "01 Gale Hill", "27", "Team-oriented radical website", "42", 113 },
                    { 130, "835 Sunfield Pass", "29", "Open-architected exuding software", "7", 159 },
                    { 131, "622 Lien Center", "5", "Public-key system-worthy product", "32", 121 },
                    { 132, "9 Stuart Way", "3", "Ergonomic reciprocal service-desk", "8", 152 },
                    { 133, "280 Sheridan Center", "30", "Triple-buffered interactive middleware", "47", 154 },
                    { 134, "542 Fair Oaks Place", "14", "Grass-roots logistical benchmark", "37", 156 },
                    { 135, "9 Jackson Hill", "14", "Ameliorated demand-driven array", "4", 127 },
                    { 136, "225 Ryan Lane", "5", "Pre-emptive dedicated conglomeration", "41", 153 },
                    { 137, "5 Killdeer Pass", "17", "Diverse directional knowledge user", "1", 158 },
                    { 138, "28503 Oxford Pass", "4", "Pre-emptive secondary product", "38", 122 },
                    { 139, "32470 Hermina Road", "16", "Ameliorated dynamic flexibility", "11", 117 },
                    { 140, "3 Scott Trail", "13", "Down-sized reciprocal frame", "24", 110 },
                    { 141, "3 Talmadge Crossing", "1", "Cross-group empowering Graphic Interface", "17", 105 },
                    { 142, "729 Heath Parkway", "27", "Seamless coherent software", "40", 102 },
                    { 143, "83621 Golf Trail", "28", "Automated attitude-oriented emulation", "2", 149 },
                    { 144, "80126 Haas Drive", "18", "Customizable system-worthy attitude", "1", 126 },
                    { 145, "955 Pepper Wood Trail", "23", "Synergistic eco-centric local area network", "14", 145 },
                    { 146, "1765 Grayhawk Road", "3", "Self-enabling holistic forecast", "8", 110 },
                    { 147, "68458 Pierstorff Circle", "23", "Balanced dynamic leverage", "14", 129 },
                    { 148, "7639 Tennyson Parkway", "16", "Horizontal zero administration Graphical User Interface", "19", 143 },
                    { 149, "8941 High Crossing Alley", "17", "Distributed mission-critical superstructure", "5", 131 },
                    { 150, "8492 Buell Hill", "28", "Re-engineered zero defect task-force", "7", 137 },
                    { 151, "0 Hagan Junction", "10", "Focused object-oriented challenge", "33", 160 },
                    { 152, "5457 Harbort Trail", "10", "Programmable neutral conglomeration", "8", 160 },
                    { 153, "89 Blaine Lane", "15", "Triple-buffered local solution", "4", 114 },
                    { 154, "07 Iowa Road", "28", "Mandatory even-keeled ability", "14", 137 },
                    { 155, "1 Sloan Avenue", "30", "Optional stable solution", "37", 119 },
                    { 156, "72487 Hauk Park", "7", "Fully-configurable actuating solution", "22", 154 },
                    { 157, "67 Crescent Oaks Point", "17", "Focused discrete definition", "38", 107 },
                    { 158, "52113 Marcy Center", "2", "Diverse uniform superstructure", "48", 127 },
                    { 159, "6 7th Junction", "24", "Up-sized demand-driven methodology", "48", 143 },
                    { 160, "5 Buhler Way", "1", "Fully-configurable contextually-based budgetary management", "28", 116 },
                    { 161, "9 Express Terrace", "12", "Virtual holistic open architecture", "54", 123 },
                    { 162, "70397 Stephen Road", "24", "Optional disintermediate installation", "19", 110 },
                    { 163, "9936 Manley Court", "16", "Extended multi-state Graphical User Interface", "29", 102 },
                    { 164, "9829 Clyde Gallagher Circle", "11", "Operative non-volatile orchestration", "43", 159 },
                    { 165, "6 Norway Maple Hill", "24", "De-engineered background help-desk", "33", 114 },
                    { 166, "7 Nelson Park", "3", "Configurable responsive moratorium", "38", 146 },
                    { 167, "19123 Lunder Alley", "8", "Organized web-enabled implementation", "20", 105 },
                    { 168, "34555 Daystar Crossing", "25", "Streamlined next generation secured line", "40", 156 },
                    { 169, "86637 Corscot Point", "27", "Reactive solution-oriented orchestration", "43", 154 },
                    { 170, "38 American Ash Park", "28", "Fundamental fault-tolerant service-desk", "52", 150 },
                    { 171, "546 Grasskamp Crossing", "25", "Reduced modular extranet", "50", 102 },
                    { 172, "75 Express Drive", "2", "Extended value-added circuit", "36", 130 },
                    { 173, "40 Homewood Alley", "5", "Integrated scalable superstructure", "7", 145 },
                    { 174, "4707 Gina Pass", "13", "Function-based well-modulated system engine", "41", 146 },
                    { 175, "805 Sommers Crossing", "25", "Expanded web-enabled structure", "15", 140 },
                    { 176, "99193 Eggendart Junction", "7", "Intuitive optimal hub", "45", 132 },
                    { 177, "34 Summerview Park", "10", "Persevering impactful policy", "33", 103 },
                    { 178, "7848 Cambridge Parkway", "23", "Business-focused scalable access", "47", 133 },
                    { 179, "3 Cambridge Road", "20", "Public-key even-keeled time-frame", "31", 132 },
                    { 180, "92 Lunder Crossing", "22", "Re-contextualized 3rd generation data-warehouse", "21", 142 },
                    { 181, "296 Dorton Hill", "4", "Triple-buffered demand-driven core", "54", 120 },
                    { 182, "941 Fallview Junction", "22", "Streamlined stable frame", "2", 137 },
                    { 183, "48 Gulseth Drive", "15", "Stand-alone non-volatile installation", "11", 122 },
                    { 184, "224 Express Way", "23", "Public-key zero tolerance product", "39", 119 },
                    { 185, "38 Ronald Regan Pass", "14", "Universal asymmetric application", "35", 124 },
                    { 186, "68010 Heath Plaza", "18", "Persevering 24 hour installation", "32", 144 },
                    { 187, "50869 Arapahoe Court", "4", "Synergistic 24 hour success", "55", 106 },
                    { 188, "6986 Buena Vista Drive", "16", "Inverse leading edge matrices", "4", 114 },
                    { 189, "3162 Crowley Alley", "28", "Persevering logistical synergy", "15", 135 },
                    { 190, "7958 Lyons Way", "3", "Up-sized bottom-line framework", "6", 147 },
                    { 191, "977 Bayside Park", "9", "De-engineered national pricing structure", "48", 102 },
                    { 192, "6079 Summer Ridge Crossing", "12", "Persevering global time-frame", "31", 102 },
                    { 193, "3 Anniversary Street", "6", "Fully-configurable multi-tasking time-frame", "16", 119 },
                    { 194, "3 Mayfield Hill", "6", "Reduced object-oriented extranet", "51", 134 },
                    { 195, "966 Harper Pass", "25", "Enterprise-wide clear-thinking service-desk", "50", 132 },
                    { 196, "01179 Muir Alley", "21", "Progressive real-time success", "34", 138 },
                    { 197, "95 Anniversary Place", "30", "Enterprise-wide logistical algorithm", "26", 144 },
                    { 198, "4 Rockefeller Plaza", "3", "Ameliorated zero tolerance help-desk", "27", 155 },
                    { 199, "0753 Holy Cross Circle", "8", "Profit-focused tangible focus group", "51", 157 },
                    { 200, "0452 Oneill Avenue", "14", "Enhanced tangible archive", "28", 133 },
                    { 201, "39 Ridgeway Road", "4", "Grass-roots intangible archive", "50", 136 },
                    { 202, "5 Trailsway Avenue", "18", "Configurable value-added productivity", "24", 144 },
                    { 203, "13 Hollow Ridge Trail", "11", "User-friendly neutral service-desk", "36", 107 },
                    { 204, "97036 6th Terrace", "32", "Triple-buffered regional encryption", "17", 133 },
                    { 205, "96852 Warrior Parkway", "32", "Public-key empowering installation", "11", 139 },
                    { 206, "18986 Duke Place", "18", "Focused intangible policy", "25", 130 },
                    { 207, "23771 Mallard Center", "30", "Ergonomic heuristic challenge", "51", 151 },
                    { 208, "71 Straubel Street", "12", "Function-based static adapter", "22", 151 },
                    { 209, "9 Kensington Place", "25", "Self-enabling real-time collaboration", "23", 159 },
                    { 210, "4729 Katie Park", "15", "Synergistic contextually-based flexibility", "1", 150 },
                    { 211, "32 Schurz Park", "11", "Face to face needs-based focus group", "27", 154 },
                    { 212, "52059 Fair Oaks Road", "6", "Digitized mobile system engine", "48", 119 },
                    { 213, "9 Butternut Lane", "18", "User-centric zero administration hub", "27", 128 },
                    { 214, "6 Mesta Trail", "28", "Operative systematic approach", "53", 113 },
                    { 215, "8 Caliangt Parkway", "20", "Focused system-worthy framework", "48", 133 },
                    { 216, "8 Laurel Terrace", "6", "Devolved global portal", "2", 152 },
                    { 217, "6 Warbler Road", "22", "Synchronised static artificial intelligence", "11", 143 },
                    { 218, "450 Roth Alley", "17", "Fully-configurable tangible hardware", "33", 102 },
                    { 219, "538 Crowley Alley", "19", "Realigned client-driven encryption", "43", 113 },
                    { 220, "0 Eastwood Plaza", "29", "Multi-tiered object-oriented moderator", "43", 125 },
                    { 221, "5 Arkansas Pass", "20", "Inverse local focus group", "46", 154 },
                    { 222, "19 Sachtjen Hill", "12", "Distributed didactic complexity", "14", 103 },
                    { 223, "424 Moose Terrace", "10", "Organized web-enabled toolset", "4", 111 },
                    { 224, "38 Montana Way", "9", "Synchronised 5th generation moderator", "49", 130 },
                    { 225, "70 Meadow Ridge Center", "6", "Cross-group mission-critical website", "7", 124 },
                    { 226, "006 Dexter Hill", "4", "Visionary human-resource function", "28", 126 },
                    { 227, "7800 Laurel Alley", "20", "Up-sized directional architecture", "43", 158 },
                    { 228, "16209 Northwestern Circle", "26", "Upgradable systematic workforce", "9", 121 },
                    { 229, "3557 Calypso Place", "22", "Customizable bottom-line projection", "13", 147 },
                    { 230, "67 Rusk Terrace", "13", "Profound didactic task-force", "45", 147 },
                    { 231, "6 Killdeer Place", "29", "Organic human-resource contingency", "18", 145 },
                    { 232, "2 Union Center", "4", "Advanced scalable attitude", "5", 131 },
                    { 233, "8094 Sunfield Parkway", "13", "Sharable scalable budgetary management", "43", 159 },
                    { 234, "7631 Marcy Lane", "6", "Synergized 4th generation projection", "28", 157 },
                    { 235, "5088 Golden Leaf Way", "4", "Reduced system-worthy challenge", "31", 109 },
                    { 236, "23277 Becker Place", "2", "Profit-focused executive benchmark", "27", 105 },
                    { 237, "75663 Southridge Hill", "12", "Realigned executive orchestration", "10", 126 },
                    { 238, "81184 Huxley Circle", "23", "Multi-layered zero defect collaboration", "25", 144 },
                    { 239, "67 Morningstar Terrace", "15", "Multi-lateral human-resource Graphic Interface", "4", 102 },
                    { 240, "220 Northland Drive", "12", "Inverse national help-desk", "45", 133 },
                    { 241, "823 Farwell Junction", "3", "Streamlined object-oriented access", "12", 141 },
                    { 242, "29 Moulton Point", "7", "Pre-emptive modular service-desk", "22", 102 },
                    { 243, "4337 Northridge Avenue", "10", "Versatile 24/7 encoding", "42", 144 },
                    { 244, "63218 Twin Pines Plaza", "6", "Business-focused transitional attitude", "28", 137 },
                    { 245, "57667 Main Way", "14", "Programmable value-added toolset", "19", 146 },
                    { 246, "09203 Leroy Court", "25", "Business-focused encompassing matrices", "36", 156 },
                    { 247, "6 Parkside Road", "11", "Multi-layered logistical time-frame", "7", 126 },
                    { 248, "530 Blackbird Pass", "24", "Fundamental national capacity", "50", 157 },
                    { 249, "291 Basil Crossing", "2", "Programmable eco-centric alliance", "20", 160 },
                    { 250, "57 West Circle", "24", "Future-proofed mobile emulation", "43", 136 },
                    { 251, "8390 Delaware Junction", "20", "Assimilated eco-centric synergy", "37", 125 },
                    { 252, "397 Corscot Lane", "27", "Mandatory content-based infrastructure", "15", 101 },
                    { 253, "22 Welch Plaza", "4", "Future-proofed context-sensitive knowledge user", "27", 131 },
                    { 254, "598 Packers Crossing", "11", "Focused reciprocal intranet", "15", 144 },
                    { 255, "0 Barby Road", "17", "Persistent human-resource initiative", "51", 113 },
                    { 256, "41920 Meadow Valley Park", "26", "Optimized systematic alliance", "22", 101 },
                    { 257, "7 Barnett Junction", "7", "User-friendly systematic archive", "42", 130 },
                    { 258, "5 Charing Cross Road", "7", "Versatile composite conglomeration", "23", 102 },
                    { 259, "10394 Emmet Lane", "30", "Face to face dedicated Graphic Interface", "47", 107 },
                    { 260, "2 Boyd Pass", "14", "Enterprise-wide demand-driven migration", "16", 115 },
                    { 261, "341 Jana Point", "18", "Triple-buffered value-added framework", "11", 139 },
                    { 262, "0 Hanson Parkway", "25", "Reduced reciprocal encoding", "11", 122 },
                    { 263, "1 North Terrace", "11", "Reverse-engineered multimedia benchmark", "9", 130 },
                    { 264, "5 Rusk Park", "20", "Right-sized client-driven hardware", "17", 124 },
                    { 265, "6589 Prairieview Parkway", "5", "Triple-buffered secondary productivity", "53", 145 },
                    { 266, "710 Ridgeview Parkway", "29", "Self-enabling leading edge methodology", "17", 139 },
                    { 267, "21 Sugar Lane", "23", "Persevering optimizing productivity", "34", 103 },
                    { 268, "45546 Holy Cross Hill", "25", "Business-focused system-worthy contingency", "44", 128 },
                    { 269, "2070 Northport Terrace", "29", "Realigned bifurcated core", "52", 149 },
                    { 270, "89 Anhalt Circle", "15", "Synergized bottom-line access", "33", 148 },
                    { 271, "8 Carberry Plaza", "13", "Realigned asymmetric software", "7", 104 },
                    { 272, "9015 South Point", "18", "Enterprise-wide client-driven circuit", "31", 148 },
                    { 273, "4403 Gateway Way", "6", "Self-enabling full-range access", "28", 112 },
                    { 274, "8184 Kenwood Court", "25", "Ameliorated exuding knowledge user", "13", 116 },
                    { 275, "56010 Pawling Road", "4", "Grass-roots bottom-line algorithm", "44", 152 },
                    { 276, "6204 Chinook Trail", "26", "Right-sized composite encoding", "47", 113 },
                    { 277, "00 Oakridge Street", "14", "Inverse background strategy", "42", 139 },
                    { 278, "1276 Kenwood Pass", "4", "Integrated multimedia structure", "28", 156 },
                    { 279, "50 Debra Road", "18", "Cross-group secondary orchestration", "26", 122 },
                    { 280, "731 Red Cloud Junction", "31", "Triple-buffered stable secured line", "48", 124 },
                    { 281, "5855 Little Fleur Street", "28", "Robust heuristic support", "36", 157 },
                    { 440, "1937 Sage Crossing", "14", "De-engineered national customer loyalty", "2", 109 },
                    { 441, "26 Riverside Road", "15", "De-engineered 5th generation archive", "54", 143 },
                    { 990, "1 Kings Terrace", "10", "Re-contextualized secondary data-warehouse", "47", 140 },
                    { 991, "06674 Cascade Park", "1", "Quality-focused cohesive Graphical User Interface", "47", 104 },
                    { 992, "3755 Blaine Trail", "31", "Advanced human-resource collaboration", "26", 157 },
                    { 993, "24793 Menomonie Park", "31", "Customer-focused responsive implementation", "42", 155 },
                    { 994, "7 Spohn Trail", "12", "Fundamental neutral model", "16", 151 },
                    { 995, "47133 Mendota Hill", "2", "Organized object-oriented interface", "22", 141 },
                    { 996, "06 Basil Lane", "24", "Expanded context-sensitive infrastructure", "21", 146 },
                    { 997, "8 Vidon Street", "14", "User-centric impactful matrix", "18", 150 },
                    { 998, "5797 Eastlawn Circle", "28", "Switchable client-driven paradigm", "33", 141 },
                    { 999, "8056 Westend Plaza", "13", "Optional encompassing artificial intelligence", "48", 131 },
                    { 1000, "29 Hansons Way", "25", "Centralized regional ability", "27", 137 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Calls",
                keyColumn: "Id",
                keyValue: 1000);
        }
    }
}
