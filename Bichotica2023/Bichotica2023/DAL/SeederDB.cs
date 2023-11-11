namespace Bichotica2023.DAL
{
    public class SeederDb
    {
        private readonly DataBaseContext _context;
        public SeederDb(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync(); 
            PopulateTickets(); //  con este programacion asincronica se procede el llenado de la  base de  datos

            await _context.SaveChangesAsync();
        }

        private void PopulateTickets()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 1; i <= 50000; i++)
                {
                    _context.Tickets.Add(new Entities.Ticket
                    {
                        TicketID = i,
                        UseDate = null,
                        IsUsed = false,
                        EntranceGate = null,
                        CreateDate = DateTime.Now,
                    }
                    );
                }

            }
        }
    }
}
