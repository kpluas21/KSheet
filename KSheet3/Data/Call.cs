namespace KSheet3.Data
{
	public class Call
	{
		public int Id { get; set; }

		public DateTime Time { get; set; }
		public int Position { get; set; }
		public int Incident { get; set; }
		public string Address { get; set; }
		
		//These fields can be null (in other words, not required in order to create the call)
		public string? PdSignal { get; set; }
		public string? FdSignal { get; set; }
		public string? Notes { get; set; }


	}
}
