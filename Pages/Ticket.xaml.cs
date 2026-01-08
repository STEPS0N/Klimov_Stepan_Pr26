using Airlines_Klimov.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Airlines_Klimov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Ticket.xaml
    /// </summary>
    public partial class Ticket : Page
    {
        public MainWindow mainWindow;
        public List<TicketContext> AllTickets;

        public Ticket(MainWindow _mainWindow, string from, string where, DateTime dateFrom, DateTime dateWhere)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            AllTickets = TicketContext.AllTickets().FindAll(x =>
                (string.IsNullOrEmpty(from) || x.From == from) &&
                (string.IsNullOrEmpty(where) || x.To == where) &&
                (dateFrom == DateTime.MinValue || x.Time_start.Date == dateFrom.Date) &&
                (dateWhere == DateTime.MinValue || x.Time_end.Date == dateWhere.Date));
            CreateUI();

            if (AllTickets.Count == 0)
            {
                Label myLabel = new Label();
                myLabel.Content = "По данному запросу рейсов нет!";
                myLabel.HorizontalAlignment = HorizontalAlignment.Center;
                myLabel.VerticalAlignment = VerticalAlignment.Center;
                myLabel.FontWeight = FontWeights.Bold;
                myLabel.FontSize = 30;
                myLabel.Margin = new Thickness(10);
                parent.Children.Add(myLabel);
            }
        }

        public void CreateUI()
        {
            parent.Children.Clear();

            foreach (TicketContext ticket in AllTickets)
            {
                parent.Children.Add(new Elements.Item(ticket));
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.main);
        }
    }
}
