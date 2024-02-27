using KSheet3.Data;
using Microsoft.EntityFrameworkCore;


namespace KSheet3.Components.Pages
{
	public class CallSearchModel
	{
		public int? Id { get; set; }
		public int? Position { get; set; }
		public int? Incident { get; set; }
		public string? Address { get; set; }
		public string? PdSignal { get; set; }
		public string? FdSignal { get; set; }
		public string? Notes { get; set; }
		public DateTime? TimeFrom { get; set; }
		public DateTime? TimeTo { get; set; }

	}


	public partial class ListCalls
	{
		public CallContext? _context;

		public List<Call>? searchResults { get; set; }
		public CallSearchModel? callSearch {  get; set; }

		protected override void OnInitialized()
		{
			callSearch = new CallSearchModel();
		}

		//SEARCH 

		public async Task Search()
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();

			if(_context != null)
			{
				searchResults = _context.Calls.ToList(

				if(callSearch.Id.HasValue)
				{
					result = result.Where(m => m.Id.Equals(callSearch.Id));
				}

				if(callSearch.Incident.HasValue)
				{
					result = result.Where(m => m.Incident.Equals(callSearch.Incident));
				}

				if(!string.IsNullOrEmpty(callSearch.Address))
				{
					result = result.Where(m => m.Address.Contains(callSearch.Address));
				}

				if(!string.IsNullOrEmpty(callSearch.PdSignal))
				{
					result = result.Where(m => m.PdSignal.Contains(callSearch.PdSignal));
				}

				if(!string.IsNullOrEmpty(callSearch.FdSignal))
				{
					result = result.Where(m => m.FdSignal.Contains(callSearch.FdSignal));
				}

				if(callSearch.Position.HasValue)
				{
					result = result.Where(m => m.Position.Equals(callSearch.Position));
				}
			}
			
		}

	}
}
