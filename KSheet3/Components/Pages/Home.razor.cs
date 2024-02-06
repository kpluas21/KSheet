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
		public List<Call>? AllCalls { get; set; }
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

		//CREATE
		public async Task CreateNewCall()
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();
			if(NewCall != null)
			{
				_context?.Calls.Add(NewCall);
				_context?.SaveChangesAsync();

			}
			ShowCreate = false;
			await ShowCalls();
		}
		//READ
		public async Task ShowCalls()
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();

			if(_context != null)
			{
				AllCalls = await _context.Calls.ToListAsync();
			}
			if(_context != null)
			{
				await _context.DisposeAsync();
			}
		}

		//Shows only a handful of calls when requested
		public async Task ShowSomeCalls()
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();

			if(_context != null)
			{
				AllCalls = await _context.Calls.Take<Call>(20).ToListAsync();
			}

			if(_context != null)
			{
				await _context.DisposeAsync();
			}
		}
	}
}
