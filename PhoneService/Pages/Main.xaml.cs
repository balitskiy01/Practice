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

namespace PhoneService.Pages {
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page {
        public Frame F;
        public Main(Frame F) {
            InitializeComponent();
            this.F = F;
            label1.Content = "Вітаємо, " + MainWindow.U.PIB;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Заборгованість: " + MainWindow.U.Money.ToString() + " грн");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            PhoneService.Classes.Pages.SetPhonePage(F);
            F.Navigate(PhoneService.Classes.Pages.PhonePage);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            PhoneService.Classes.Pages.SetHistoryPage(F);
            F.Navigate(PhoneService.Classes.Pages.HistoryPage);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            PhoneService.Classes.Pages.SetRatesPage(F);
            F.Navigate(PhoneService.Classes.Pages.RatesPage);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            PhoneService.Classes.Pages.SetInternetPage(F);
            F.Navigate(PhoneService.Classes.Pages.InternetPage);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) {
            PhoneService.Classes.Pages.SetLoginPage(F);
            F.Navigate(PhoneService.Classes.Pages.LoginPage);
        }
    }
}
