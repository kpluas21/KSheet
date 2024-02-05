using KSheet3.Data;
using KSheet3.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace KSheet3.Components.Pages
{
	public partial class Home
	{
		public bool ShowCreate { get; set; }
		public Call? NewCall { get; set; }
		private CallContext? _context;

		protected override async Task OnInitializedAsync()
		{
			ShowCreate = false;
		}

		public void ShowCreateForm()
		{
			ShowCreate = true;
			NewCall = new Call();
		}

		public async Task CreateNewCall()
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();
			if(NewCall != null)
			{
				_context?.Calls.Add(NewCall);
				_context?.SaveChangesAsync();

			}
			ShowCreate = false;
		}
	}
}
