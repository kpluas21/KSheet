using KSheet.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

namespace KSheet.Components.Pages
{
	public partial class Entercall
	{
		public bool ShowCreate { get; set; }
		public bool EditRecord { get; set; }
		public int CallId { get; set; }
		[SupplyParameterFromForm]
		public Call? NewCall { get; set; }
		public List<Call>? AllCalls { get; set; }

		public Call? CallToUpdate { get; set; }
		private CallContext? _context;
		AuthenticationState? _authenticationState;
		protected override void OnInitialized()
		{
			ShowCreate = false;
			ShowCallsSync();
		}

		private void ShowCallsSync()
		{
			Task.Run(async () => {
				await ShowCalls();
			}).Wait();
		}

		public void ShowCreateForm()
		{
			ShowCreate = true;
			NewCall = new Call();
		}

		//CREATE
		//By default, any text field is auto capitalized to make searching easier. 
		public async Task CreateNewCall()
		{

			_context ??= await CallContextFactory.CreateDbContextAsync();
			_authenticationState ??= await AuthenticationStateProvider.GetAuthenticationStateAsync();
			var user = UserManager.GetUserAsync(_authenticationState.User);


			if (NewCall != null)
			{
				NewCall.Time = DateTime.Now;

				NewCall.User = user.Result.UserName;

				if (!string.IsNullOrEmpty(NewCall.Address))
				{
					NewCall.Address = NewCall.Address.ToUpper();
				}
				else
				{//This shouldn't be reached with the validation messages in place
					NewCall.Address = "N/A";
				}

				if (!string.IsNullOrEmpty(NewCall.PdSignal))
				{
					NewCall.PdSignal = NewCall.PdSignal.ToUpper();
				}
				else
				{//same here
					NewCall.PdSignal = "N/A";
				}

				if (!string.IsNullOrEmpty(NewCall.FdSignal))
				{
					NewCall.FdSignal = NewCall.FdSignal.ToUpper();
				}
				else
				{//here too
					NewCall.FdSignal = "N/A";
				}

				if(!string.IsNullOrEmpty(NewCall.Notes))
				{
					NewCall.Notes = NewCall.Notes.ToUpper();
				}

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

			if (_context != null)
			{
				AllCalls = await _context.Calls.ToListAsync();
				AllCalls.Reverse();
			}

		}

		//Shows only a handful of calls when requested
		public async Task ShowSomeCalls()
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();

			if (_context != null)
			{
				AllCalls = await _context.Calls.Take<Call>(20).ToListAsync();
			}

		}

		//UPDATE

		public async Task ShowEditForm(Call call)
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();
			if (_context != null)
			{
				CallToUpdate = _context.Calls.FirstOrDefault(x => x.Id == call.Id);
				CallId = call.Id;
				EditRecord = true;
			}

		}
		public async Task UpdateCall()
		{
			EditRecord = false;
			_context ??= await CallContextFactory.CreateDbContextAsync();

			if (_context != null)
			{
				if (CallToUpdate != null) { _context.Calls.Update(CallToUpdate); }
				await _context.SaveChangesAsync();
			}

		}

		//DELETE
		public async Task DeleteCall(Call call)
		{
			_context ??= await CallContextFactory.CreateDbContextAsync();

			if (_context != null)
			{
				if (call != null)
				{
					_context.Calls.Remove(call);
					await _context.SaveChangesAsync();
				}

				await ShowCalls();
			}
		}
	}
}
