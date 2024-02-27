using KSheet3.Data;
using Microsoft.EntityFrameworkCore;

namespace KSheet3.Components.Pages
{
	public partial class ListCalls
	{
		public CallContext? _context;
		public List<Call>? searchResults { get; set; }
		public Call? callQuery {  get; set; }

		protected override void OnInitialized()
		{
			callQuery = new Call();
		}

		//SEARCH 

		public async Task<List<Call>> Search()
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();

			if(_context != null)
			{
				IQueryable<Call> query = _context.Calls;
				
				if(!string.IsNullOrEmpty(callQuery?.Address))
				{
					query = query.Where(m => m.Address.Contains(callQuery.Address));
				}

				if(callQuery?.Position != 0) 
				{
					query = query.Where(m => m.Position == callQuery.Position);
				}
				searchResults =  await query.ToListAsync();
			}

			return null;

			
		}

	}
}
