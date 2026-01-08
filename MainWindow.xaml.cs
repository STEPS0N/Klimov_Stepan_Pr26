using Airlines_Klimov.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airlines_Klimov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<TicketClass> TicketClasses = new List<TicketClass>();

        public MainWindow()
        {
            InitializeComponent();
            OpenPage(pages.main);
        }

        public enum pages
        {
            main,
            ticket
        }

        public void OpenPage(pages _pages)
        {
            if (_pages == pages.main)
                frame.Navigate(new Pages.Main(this));
            if (_pages == pages.ticket)
                frame.Navigate(new Pages.Ticket(this, this.ToString(), this.ToString()));
        }
    }
}