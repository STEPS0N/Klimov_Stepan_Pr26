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

namespace Airlines_Klimov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public MainWindow mainWindow;

        public Main(MainWindow _mainWindow)    
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void Shutdown(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            DateTime fromDateValue = fromDate.SelectedDate == null ? DateTime.MinValue : fromDate.SelectedDate.Value;
            DateTime whereDateValue = whereDate.SelectedDate == null ? DateTime.MinValue : whereDate.SelectedDate.Value;

            mainWindow.frame.Navigate(new Pages.Ticket(mainWindow, fromTb.Text, whereTb.Text, fromDateValue, whereDateValue));
        }
    }
}
