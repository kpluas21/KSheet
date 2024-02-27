namespace KSheet3.Data
{
	public class Call
	{
		public int Id { get; set; }

		public DateTime? Time { get; set; }
		public int Position { get; set; }
		public string? Address { get; set; }
		public string? PdSignal { get; set; }
		public string? FdSignal { get; set; }
		public string? Notes { get; set; }

		public int? Incident { get; set; }

	}
}
