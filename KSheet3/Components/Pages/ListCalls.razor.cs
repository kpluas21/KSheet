using KSheet3.Data;

namespace KSheet3.Components.Pages
{
	public partial class ListCalls
	{
		public CallContext? _context;
		public List<Call>? searchResults { get; set; }
		public Call? callQuery {  get; set; }

		//SEARCH 

		public async Task<List<Call>> search(int position, string address)
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();
		}

	}
}
