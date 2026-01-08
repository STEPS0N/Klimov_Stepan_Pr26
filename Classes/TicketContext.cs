using Airlines_Klimov.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines_Klimov.Classes
{
    public class TicketContext : TicketClass
    {
        public TicketContext(int Price, string From, string To, DateTime Time_start, DateTime Time_end) : base(Price, From, To, Time_start, Time_end) { }

        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();

            MySqlConnection connection = WorkingBD.Connection.OpenConnection();
            MySqlDataReader ticket_query = WorkingBD.Connection.Query("SELECT * FROM `Airlines`.`Tickets`;", connection);

            while (ticket_query.Read())
            {
                allTickets.Add(new TicketContext(
                    ticket_query.GetInt32(1),
                    ticket_query.GetString(2),
                    ticket_query.GetString(3),
                    ticket_query.GetDateTime(4),
                    ticket_query.GetDateTime(5)
                    ));
            }
            WorkingBD.Connection.CloseConnection(connection);

            return allTickets;
        }
    }
}
