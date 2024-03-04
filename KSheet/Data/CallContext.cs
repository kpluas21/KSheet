using Microsoft.EntityFrameworkCore;

namespace KSheet.Data
{
	public class CallContext : DbContext
	{
		protected readonly IConfiguration Configuration;
		private Random gen = new Random();
		public CallContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public DateTime RandomDay()
		{
			DateTime start = new DateTime(1995, 1, 1);
			int range = (DateTime.Now - start).Days;
			return start.AddDays(gen.Next(range));
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite(Configuration.GetConnectionString("CallsDB"));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Call>()
				.ToTable("Calls");

			modelBuilder.Entity<Call>()
				.HasData(
new Call { Id = 1, Time = RandomDay(), Position = 141, Address = "16 Barby Park", PdSignal = "51", FdSignal = "44", Notes = "Polarised needs-based policy", Incident = 306876 },
new Call { Id = 2, Time = RandomDay(), Position = 114, Address = "0790 Elmside Crossing", PdSignal = "41", FdSignal = "44", Notes = "Up-sized web-enabled instruction set", Incident = 733328 },
new Call { Id = 3, Time = RandomDay(), Position = 115, Address = "220 Prentice Avenue", PdSignal = "54", FdSignal = "42", Notes = "Persistent directional attitude", Incident = 365002 },
new Call { Id = 4, Time = RandomDay(), Position = 132, Address = "85465 Buell Hill", PdSignal = "36", FdSignal = "42", Notes = "Focused fresh-thinking moratorium", Incident = 704130 },
new Call { Id = 5, Time = RandomDay(), Position = 146, Address = "1 Ronald Regan Alley", PdSignal = "14", FdSignal = "37", Notes = "Reverse-engineered solution-oriented installation", Incident = 988168 },
new Call { Id = 6, Time = RandomDay(), Position = 130, Address = "09744 Tomscot Terrace", PdSignal = "10", FdSignal = "44", Notes = "Horizontal scalable attitude", Incident = 819494 },
new Call { Id = 7, Time = RandomDay(), Position = 109, Address = "41988 Sutherland Road", PdSignal = "49", FdSignal = "35", Notes = "Advanced context-sensitive info-mediaries", Incident = 545423 },
new Call { Id = 8, Time = RandomDay(), Position = 130, Address = "1598 Superior Parkway", PdSignal = "53", FdSignal = "44", Notes = "Operative mission-critical project", Incident = 975076 },
new Call { Id = 9, Time = RandomDay(), Position = 124, Address = "8553 Bashford Trail", PdSignal = "24", FdSignal = "41", Notes = "Sharable bottom-line contingency", Incident = 243339 },
new Call { Id = 10, Time = RandomDay(), Position = 133, Address = "6 Burrows Crossing", PdSignal = "41", FdSignal = "15", Notes = "Reverse-engineered 24 hour hub", Incident = 849034 },
new Call { Id = 11, Time = RandomDay(), Position = 143, Address = "9895 Del Mar Court", PdSignal = "16", FdSignal = "40", Notes = "Organized grid-enabled matrices", Incident = 287667 },
new Call { Id = 12, Time = RandomDay(), Position = 158, Address = "14 Comanche Place", PdSignal = "11", FdSignal = "20", Notes = "Multi-layered leading edge local area network", Incident = 806781 },
new Call { Id = 13, Time = RandomDay(), Position = 131, Address = "4577 Talisman Place", PdSignal = "31", FdSignal = "34", Notes = "Down-sized coherent groupware", Incident = 707657 },
new Call { Id = 14, Time = RandomDay(), Position = 149, Address = "11 Rieder Point", PdSignal = "17", FdSignal = "28", Notes = "Mandatory value-added focus group", Incident = 620511 },
new Call { Id = 15, Time = RandomDay(), Position = 146, Address = "57496 Maywood Terrace", PdSignal = "50", FdSignal = "29", Notes = "Operative intermediate encryption", Incident = 620408 },
new Call { Id = 16, Time = RandomDay(), Position = 141, Address = "14466 Rockefeller Hill", PdSignal = "27", FdSignal = "27", Notes = "Cloned reciprocal circuit", Incident = 571289 },
new Call { Id = 17, Time = RandomDay(), Position = 104, Address = "0 Dayton Crossing", PdSignal = "18", FdSignal = "45", Notes = "Business-focused full-range firmware", Incident = 476600 },
new Call { Id = 18, Time = RandomDay(), Position = 150, Address = "408 Shelley Court", PdSignal = "46", FdSignal = "19", Notes = "Implemented well-modulated alliance", Incident = 219875 },
new Call { Id = 19, Time = RandomDay(), Position = 160, Address = "6216 Dorton Center", PdSignal = "51", FdSignal = "34", Notes = "Inverse contextually-based process improvement", Incident = 767288 },
new Call { Id = 20, Time = RandomDay(), Position = 120, Address = "82 Dovetail Road", PdSignal = "17", FdSignal = "30", Notes = "De-engineered value-added software", Incident = 743809 },
new Call { Id = 21, Time = RandomDay(), Position = 129, Address = "5960 Scofield Place", PdSignal = "26", FdSignal = "47", Notes = "Optimized heuristic moderator", Incident = 303199 },
new Call { Id = 22, Time = RandomDay(), Position = 151, Address = "76548 Summit Parkway", PdSignal = "17", FdSignal = "32", Notes = "Assimilated empowering process improvement", Incident = 429386 },
new Call { Id = 23, Time = RandomDay(), Position = 154, Address = "65 Iowa Way", PdSignal = "18", FdSignal = "35", Notes = "Profit-focused full-range open system", Incident = 125483 },
new Call { Id = 24, Time = RandomDay(), Position = 137, Address = "1 Golf Road", PdSignal = "22", FdSignal = "25", Notes = "Versatile optimal protocol", Incident = 916552 },
new Call { Id = 25, Time = RandomDay(), Position = 147, Address = "79 Bluestem Hill", PdSignal = "19", FdSignal = "32", Notes = "Versatile homogeneous emulation", Incident = 895954 },
new Call { Id = 26, Time = RandomDay(), Position = 126, Address = "29 Crowley Center", PdSignal = "28", FdSignal = "49", Notes = "Organic 4th generation service-desk", Incident = 868575 },
new Call { Id = 27, Time = RandomDay(), Position = 122, Address = "324 Gateway Terrace", PdSignal = "10", FdSignal = "44", Notes = "Advanced national implementation", Incident = 246925 },
new Call { Id = 28, Time = RandomDay(), Position = 111, Address = "316 Knutson Junction", PdSignal = "47", FdSignal = "43", Notes = "Automated intangible encryption", Incident = 759686 },
new Call { Id = 29, Time = RandomDay(), Position = 142, Address = "2558 Sauthoff Parkway", PdSignal = "51", FdSignal = "26", Notes = "Enterprise-wide content-based pricing structure", Incident = 204818 },
new Call { Id = 30, Time = RandomDay(), Position = 124, Address = "276 Crowley Road", PdSignal = "17", FdSignal = "20", Notes = "Right-sized needs-based application", Incident = 602076 },
new Call { Id = 31, Time = RandomDay(), Position = 113, Address = "135 Helena Crossing", PdSignal = "30", FdSignal = "33", Notes = "Vision-oriented stable challenge", Incident = 963527 },
new Call { Id = 32, Time = RandomDay(), Position = 150, Address = "542 Dahle Terrace", PdSignal = "50", FdSignal = "23", Notes = "Grass-roots bi-directional task-force", Incident = 293820 },
new Call { Id = 33, Time = RandomDay(), Position = 143, Address = "86 Hagan Road", PdSignal = "47", FdSignal = "37", Notes = "Self-enabling intermediate data-warehouse", Incident = 884891 },
new Call { Id = 34, Time = RandomDay(), Position = 137, Address = "2022 Sutteridge Court", PdSignal = "37", FdSignal = "36", Notes = "Polarised multi-tasking pricing structure", Incident = 560421 },
new Call { Id = 35, Time = RandomDay(), Position = 142, Address = "9408 Butternut Parkway", PdSignal = "38", FdSignal = "41", Notes = "Upgradable value-added analyzer", Incident = 235074 },
new Call { Id = 36, Time = RandomDay(), Position = 128, Address = "8680 Cascade Junction", PdSignal = "16", FdSignal = "30", Notes = "Proactive client-server adapter", Incident = 638378 },
new Call { Id = 37, Time = RandomDay(), Position = 124, Address = "04806 Monument Place", PdSignal = "35", FdSignal = "44", Notes = "Reduced 24 hour software", Incident = 515460 },
new Call { Id = 38, Time = RandomDay(), Position = 155, Address = "418 Pine View Street", PdSignal = "44", FdSignal = "39", Notes = "Profit-focused secondary frame", Incident = 857433 },
new Call { Id = 39, Time = RandomDay(), Position = 160, Address = "14074 Blackbird Pass", PdSignal = "36", FdSignal = "18", Notes = "Object-based upward-trending paradigm", Incident = 594107 },
new Call { Id = 40, Time = RandomDay(), Position = 101, Address = "33 Mockingbird Way", PdSignal = "54", FdSignal = "18", Notes = "User-centric mission-critical capability", Incident = 189863 },
new Call { Id = 41, Time = RandomDay(), Position = 130, Address = "88779 Helena Place", PdSignal = "37", FdSignal = "17", Notes = "Open-source maximized initiative", Incident = 287843 },
new Call { Id = 42, Time = RandomDay(), Position = 143, Address = "23592 Monterey Center", PdSignal = "30", FdSignal = "15", Notes = "Cloned national orchestration", Incident = 340306 },
new Call { Id = 43, Time = RandomDay(), Position = 141, Address = "24 Emmet Street", PdSignal = "31", FdSignal = "49", Notes = "Function-based empowering portal", Incident = 873478 },
new Call { Id = 44, Time = RandomDay(), Position = 141, Address = "64636 East Point", PdSignal = "37", FdSignal = "32", Notes = "Switchable uniform emulation", Incident = 182172 },
new Call { Id = 45, Time = RandomDay(), Position = 102, Address = "48 Nevada Terrace", PdSignal = "45", FdSignal = "16", Notes = "Up-sized web-enabled parallelism", Incident = 546911 },
new Call { Id = 46, Time = RandomDay(), Position = 136, Address = "364 Laurel Point", PdSignal = "50", FdSignal = "27", Notes = "Total needs-based portal", Incident = 388000 },
new Call { Id = 47, Time = RandomDay(), Position = 160, Address = "79741 Dahle Pass", PdSignal = "55", FdSignal = "33", Notes = "Function-based discrete throughput", Incident = 839263 },
new Call { Id = 48, Time = RandomDay(), Position = 155, Address = "541 Northridge Point", PdSignal = "21", FdSignal = "22", Notes = "Pre-emptive next generation open system", Incident = 777107 },
new Call { Id = 49, Time = RandomDay(), Position = 116, Address = "7 Tony Junction", PdSignal = "43", FdSignal = "22", Notes = "Triple-buffered stable groupware", Incident = 915877 },
new Call { Id = 50, Time = RandomDay(), Position = 150, Address = "927 Manufacturers Lane", PdSignal = "40", FdSignal = "24", Notes = "Focused optimal time-frame", Incident = 362449 },
new Call { Id = 51, Time = RandomDay(), Position = 133, Address = "56244 Charing Cross Drive", PdSignal = "25", FdSignal = "19", Notes = "Triple-buffered 6th generation flexibility", Incident = 344237 },
new Call { Id = 52, Time = RandomDay(), Position = 157, Address = "3514 Southridge Point", PdSignal = "53", FdSignal = "24", Notes = "Profit-focused leading edge productivity", Incident = 505289 },
new Call { Id = 53, Time = RandomDay(), Position = 152, Address = "771 Mallory Street", PdSignal = "21", FdSignal = "26", Notes = "Devolved value-added success", Incident = 906690 },
new Call { Id = 54, Time = RandomDay(), Position = 158, Address = "13307 Magdeline Terrace", PdSignal = "27", FdSignal = "39", Notes = "Extended value-added migration", Incident = 258410 },
new Call { Id = 55, Time = RandomDay(), Position = 150, Address = "7 Claremont Circle", PdSignal = "14", FdSignal = "19", Notes = "Open-source local knowledge user", Incident = 862893 },
new Call { Id = 56, Time = RandomDay(), Position = 116, Address = "63 Donald Plaza", PdSignal = "36", FdSignal = "23", Notes = "User-centric client-server core", Incident = 984681 },
new Call { Id = 57, Time = RandomDay(), Position = 138, Address = "7132 Upham Center", PdSignal = "27", FdSignal = "29", Notes = "Intuitive heuristic extranet", Incident = 984292 },
new Call { Id = 58, Time = RandomDay(), Position = 132, Address = "38623 Petterle Terrace", PdSignal = "41", FdSignal = "34", Notes = "Pre-emptive hybrid budgetary management", Incident = 287572 },
new Call { Id = 59, Time = RandomDay(), Position = 152, Address = "37197 Pleasure Way", PdSignal = "41", FdSignal = "49", Notes = "Diverse dynamic migration", Incident = 561248 },
new Call { Id = 60, Time = RandomDay(), Position = 156, Address = "21 Anderson Center", PdSignal = "41", FdSignal = "24", Notes = "Face to face regional secured line", Incident = 625114 },
new Call { Id = 61, Time = RandomDay(), Position = 104, Address = "77 Garrison Hill", PdSignal = "44", FdSignal = "37", Notes = "Customer-focused reciprocal productivity", Incident = 749999 },
new Call { Id = 62, Time = RandomDay(), Position = 137, Address = "98874 Warbler Court", PdSignal = "51", FdSignal = "49", Notes = "Quality-focused motivating attitude", Incident = 773200 },
new Call { Id = 63, Time = RandomDay(), Position = 130, Address = "5 Merchant Place", PdSignal = "55", FdSignal = "49", Notes = "Reduced 24 hour website", Incident = 160597 },
new Call { Id = 64, Time = RandomDay(), Position = 144, Address = "7 Forest Run Alley", PdSignal = "27", FdSignal = "22", Notes = "Programmable exuding budgetary management", Incident = 705657 },
new Call { Id = 65, Time = RandomDay(), Position = 123, Address = "793 Sage Junction", PdSignal = "19", FdSignal = "21", Notes = "Fundamental foreground product", Incident = 481306 },
new Call { Id = 66, Time = RandomDay(), Position = 150, Address = "0782 Fremont Park", PdSignal = "18", FdSignal = "48", Notes = "User-centric executive superstructure", Incident = 789659 },
new Call { Id = 67, Time = RandomDay(), Position = 119, Address = "501 Walton Lane", PdSignal = "27", FdSignal = "15", Notes = "Extended homogeneous toolset", Incident = 449683 },
new Call { Id = 68, Time = RandomDay(), Position = 107, Address = "104 Debra Lane", PdSignal = "47", FdSignal = "36", Notes = "Mandatory coherent intranet", Incident = 108753 },
new Call { Id = 69, Time = RandomDay(), Position = 124, Address = "71881 Valley Edge Court", PdSignal = "46", FdSignal = "47", Notes = "Versatile maximized strategy", Incident = 213963 },
new Call { Id = 70, Time = RandomDay(), Position = 117, Address = "8 Maple Center", PdSignal = "54", FdSignal = "45", Notes = "Front-line grid-enabled interface", Incident = 906827 },
new Call { Id = 71, Time = RandomDay(), Position = 138, Address = "737 Basil Center", PdSignal = "17", FdSignal = "44", Notes = "Extended dynamic software", Incident = 285726 },
new Call { Id = 72, Time = RandomDay(), Position = 137, Address = "15 Arkansas Hill", PdSignal = "24", FdSignal = "40", Notes = "Versatile intangible extranet", Incident = 444584 },
new Call { Id = 73, Time = RandomDay(), Position = 142, Address = "65416 Bellgrove Hill", PdSignal = "19", FdSignal = "43", Notes = "Versatile bifurcated matrices", Incident = 227531 },
new Call { Id = 74, Time = RandomDay(), Position = 143, Address = "943 Bunting Street", PdSignal = "24", FdSignal = "23", Notes = "Face to face zero tolerance customer loyalty", Incident = 312959 },
new Call { Id = 75, Time = RandomDay(), Position = 128, Address = "6 Merchant Avenue", PdSignal = "25", FdSignal = "42", Notes = "Pre-emptive discrete data-warehouse", Incident = 970189 },
new Call { Id = 76, Time = RandomDay(), Position = 160, Address = "92658 Commercial Terrace", PdSignal = "42", FdSignal = "29", Notes = "Realigned bottom-line projection", Incident = 135922 },
new Call { Id = 77, Time = RandomDay(), Position = 145, Address = "17605 Wayridge Road", PdSignal = "22", FdSignal = "19", Notes = "Enhanced optimizing functionalities", Incident = 686952 },
new Call { Id = 78, Time = RandomDay(), Position = 150, Address = "5918 Messerschmidt Trail", PdSignal = "30", FdSignal = "23", Notes = "Managed dynamic projection", Incident = 363085 },
new Call { Id = 79, Time = RandomDay(), Position = 118, Address = "0196 Packers Avenue", PdSignal = "43", FdSignal = "31", Notes = "Virtual bifurcated throughput", Incident = 197103 },
new Call { Id = 80, Time = RandomDay(), Position = 148, Address = "66 Bay Trail", PdSignal = "23", FdSignal = "33", Notes = "Synergized fresh-thinking alliance", Incident = 608439 },
new Call { Id = 81, Time = RandomDay(), Position = 149, Address = "082 Little Fleur Hill", PdSignal = "18", FdSignal = "38", Notes = "Multi-layered empowering secured line", Incident = 912076 },
new Call { Id = 82, Time = RandomDay(), Position = 121, Address = "433 Nova Way", PdSignal = "53", FdSignal = "25", Notes = "Stand-alone transitional installation", Incident = 431833 },
new Call { Id = 83, Time = RandomDay(), Position = 116, Address = "08414 Vernon Trail", PdSignal = "48", FdSignal = "49", Notes = "Robust methodical moratorium", Incident = 848406 },
new Call { Id = 84, Time = RandomDay(), Position = 156, Address = "3327 Mayfield Pass", PdSignal = "16", FdSignal = "18", Notes = "Profit-focused 24 hour toolset", Incident = 170695 },
new Call { Id = 85, Time = RandomDay(), Position = 136, Address = "32717 Melby Terrace", PdSignal = "31", FdSignal = "44", Notes = "Managed dedicated implementation", Incident = 680604 },
new Call { Id = 86, Time = RandomDay(), Position = 140, Address = "0374 Ruskin Plaza", PdSignal = "12", FdSignal = "22", Notes = "Decentralized client-server interface", Incident = 523648 },
new Call { Id = 87, Time = RandomDay(), Position = 137, Address = "84450 Evergreen Way", PdSignal = "46", FdSignal = "42", Notes = "Quality-focused disintermediate structure", Incident = 355088 },
new Call { Id = 88, Time = RandomDay(), Position = 156, Address = "5765 American Point", PdSignal = "16", FdSignal = "15", Notes = "Decentralized bandwidth-monitored circuit", Incident = 871204 },
new Call { Id = 89, Time = RandomDay(), Position = 105, Address = "9563 Ruskin Court", PdSignal = "45", FdSignal = "46", Notes = "Organic asynchronous customer loyalty", Incident = 471207 },
new Call { Id = 90, Time = RandomDay(), Position = 145, Address = "6 Mallory Hill", PdSignal = "22", FdSignal = "42", Notes = "Integrated context-sensitive utilisation", Incident = 614140 },
new Call { Id = 91, Time = RandomDay(), Position = 147, Address = "29246 Roxbury Park", PdSignal = "49", FdSignal = "37", Notes = "Focused zero tolerance complexity", Incident = 124172 },
new Call { Id = 92, Time = RandomDay(), Position = 112, Address = "5805 Dexter Place", PdSignal = "20", FdSignal = "15", Notes = "Front-line discrete policy", Incident = 929592 },
new Call { Id = 93, Time = RandomDay(), Position = 144, Address = "768 Maywood Avenue", PdSignal = "43", FdSignal = "18", Notes = "Assimilated high-level ability", Incident = 986208 },
new Call { Id = 94, Time = RandomDay(), Position = 110, Address = "85 Homewood Lane", PdSignal = "51", FdSignal = "40", Notes = "Horizontal asynchronous superstructure", Incident = 966315 },
new Call { Id = 95, Time = RandomDay(), Position = 107, Address = "47962 Fuller Terrace", PdSignal = "13", FdSignal = "15", Notes = "Progressive exuding flexibility", Incident = 374980 },
new Call { Id = 96, Time = RandomDay(), Position = 149, Address = "41223 Calypso Circle", PdSignal = "49", FdSignal = "42", Notes = "Enterprise-wide dynamic analyzer", Incident = 399710 },
new Call { Id = 97, Time = RandomDay(), Position = 122, Address = "7 Eagan Trail", PdSignal = "16", FdSignal = "15", Notes = "Quality-focused discrete strategy", Incident = 395087 },
new Call { Id = 98, Time = RandomDay(), Position = 159, Address = "6653 Sage Avenue", PdSignal = "53", FdSignal = "34", Notes = "Future-proofed logistical protocol", Incident = 431106 },
new Call { Id = 99, Time = RandomDay(), Position = 126, Address = "2159 Cordelia Park", PdSignal = "16", FdSignal = "25", Notes = "Configurable asynchronous archive", Incident = 183348 },
new Call { Id = 100, Time = RandomDay(), Position = 123, Address = "05582 Larry Hill", PdSignal = "53", FdSignal = "49", Notes = "Re-engineered heuristic approach", Incident = 625218 }


				);
		}

		public DbSet<Call> Calls { get; set; }

	}
}
