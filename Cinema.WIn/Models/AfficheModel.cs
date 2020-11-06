using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Win
{
    public class AfficheModel
    {
        public int Id { get; set; }
        public int Movie_Id { get; set; }
        public string Title { get; set; }
        public DateTime Premier_Date { get; set; }
        public int Ticket_Price { get; set; }
        public DateTime End_Date { get; set; }
        public double Rating { get; set; }
    }
}
