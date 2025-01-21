using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    public class repos : IRepo
    {
        private Context _context;
        public repos()
        {
            _context = new Context();
        }

        public bool Add(TickDetails ticket)
        {
           _context.TicketDB1.Add(ticket);
           _context.SaveChanges();
            return true;
        }

        public List<TickDetails> GetAll()
        {
            return _context.TicketDB1.ToList();
        }
    }
}
