using System.ComponentModel.DataAnnotations;

namespace KSheet3.Data
{
	public class Call
	{
		public int Id { get; set; }

		public DateTime Time { get; set; }
		[Required]
		[Range(1, 160, ErrorMessage = "Position out of range")]
		public int? Position { get; set; }
		[Required]
		[Range(000000, 999999, ErrorMessage="Incident must be 6 digits long")]
		public int? Incident { get; set; }
		[Required]
		[StringLength(50, ErrorMessage ="Address is too long")]
		public string Address { get; set; }

		//These fields can be null (in other words, not required in order to create the call)
		[StringLength(10, ErrorMessage = "Signal too long")]
		public string? PdSignal { get; set; }
		[StringLength(10, ErrorMessage = "Signal too long")]
		public string? FdSignal { get; set; }
		public string? Notes { get; set; }


	}
}
