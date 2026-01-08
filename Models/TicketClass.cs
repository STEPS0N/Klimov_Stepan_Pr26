using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Klimov.Models
{
    public class TicketClass
    {
        public int Price { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Time_start { get; set; }
        public DateTime Time_end { get; set; }

        public TicketClass() { }

        public TicketClass(int Price, string From, string To, DateTime Time_start, DateTime Time_end)
        {
            this.Price = Price;
            this.From = From;
            this.To = To;
            this.Time_start = Time_start;
            this.Time_end = Time_end;
        }
    }
}
