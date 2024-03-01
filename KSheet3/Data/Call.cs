using System.ComponentModel.DataAnnotations;

namespace KSheet3.Data
{
	public class Call
	{
		public int Id { get; set; }

		public DateTime Time { get; set; }
		[Required]
		public int? Position { get; set; }
		[Required]
		public int? Incident { get; set; }
		[Required]
		[StringLength(50, ErrorMessage ="Address is too long")]
		public string Address { get; set; }
		
		//These fields can be null (in other words, not required in order to create the call)
		public string? PdSignal { get; set; }
		public string? FdSignal { get; set; }
		public string? Notes { get; set; }


	}
}
