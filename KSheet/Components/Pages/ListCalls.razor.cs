using KSheet.Data;


namespace KSheet.Components.Pages
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

        public List<Call>? SearchResults { get; set; }
        public CallSearchModel? CallSearch { get; set; }

        protected override void OnInitialized()
        {
            CallSearch = new CallSearchModel();
        }

        //SEARCH 

        public async Task Search()
        {
            _context ??= await CallContextFactory.CreateDbContextAsync();

            if (_context != null)
            {
                var result = _context.Calls.AsQueryable();

                if (CallSearch.Id.HasValue)
                {
                    Console.WriteLine(CallSearch.Id.Value.ToString());
                    result = result.Where(m => m.Id.Equals(CallSearch.Id));
                }

                if (CallSearch.Incident.HasValue)
                {
                    Console.WriteLine(CallSearch.Incident.Value);

                    result = result.Where(m => m.Incident.Equals(CallSearch.Incident));
                }

                if (!string.IsNullOrEmpty(CallSearch.Address))
                {
                    CallSearch.Address = CallSearch.Address.ToUpper();
                    result = result.Where(m => m.Address.Contains(CallSearch.Address));
                }

                if (!string.IsNullOrEmpty(CallSearch.PdSignal))
                {
                    CallSearch.PdSignal = CallSearch.PdSignal.ToUpper();
                    result = result.Where(m => m.PdSignal.Contains(CallSearch.PdSignal));
                }

                if (!string.IsNullOrEmpty(CallSearch.FdSignal))
                {
                    CallSearch.FdSignal = CallSearch.FdSignal.ToUpper();
                    result = result.Where(m => m.FdSignal.Contains(CallSearch.FdSignal));
                }

                if (CallSearch.Position.HasValue)
                {
                    result = result.Where(m => m.Position.Equals(CallSearch.Position));
                }

                if (CallSearch.TimeFrom.HasValue && CallSearch.TimeTo.HasValue)
                {
                    result = result.Where(m => m.Time >= CallSearch.TimeFrom && m.Time <= CallSearch.TimeTo);
                }

                if (!string.IsNullOrEmpty(CallSearch.Notes))
                {
                    result = result.Where(m => m.Notes.ToUpper().Contains(CallSearch.Notes.ToUpper()));
                }

                SearchResults = result.ToList();
            }

        }

    }
}
