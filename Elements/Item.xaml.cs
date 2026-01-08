using Airlines_Klimov.Classes;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airlines_Klimov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(TicketContext ticket)
        {
            InitializeComponent();

            lPrice.Content = ticket.Price + " руб.";
            from.Content = ticket.From;
            to.Content = ticket.To;

            startTime.Content = ticket.Time_start.ToString("HH:mm");
            startDate.Content = ticket.Time_start.ToString("dd.MM.yyyy");

            endTime.Content = ticket.Time_end.ToString("HH:mm");
            endDate.Content = ticket.Time_end.ToString("dd.MM.yyyy");

            TimeSpan wayTime = ticket.Time_end.Subtract(ticket.Time_start);

            int totalHours = (wayTime.Days * 24) + wayTime.Hours;
            int minutes = wayTime.Minutes;

            string Hours = totalHours.ToString();
            if (totalHours < 10) Hours = "0" + totalHours;
            string Minutes = minutes.ToString();
            if (minutes < 10) Minutes = "0" + minutes;

            way.Content = "В пути: " + Hours + " ч. " + Minutes + " мин.";
        }
    }
}
