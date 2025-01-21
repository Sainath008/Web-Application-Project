using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement
{
    public interface IRepo
    {
        public bool Add(TickDetails ticket);
        public List<TickDetails> GetAll();

    }
}
