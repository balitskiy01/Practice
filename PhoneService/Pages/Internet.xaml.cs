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
    /// Interaction logic for Internet.xaml
    /// </summary>
    public partial class Internet : Page {
        public Frame F;
        public Internet(Frame F) {
            InitializeComponent();
            this.F = F;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if(MainWindow.U.Rate == 2) {
                MessageBox.Show("Було витрачено: 0 грн");
            }
            else {
                MessageBox.Show("Було витрачено: " + (Convert.ToInt32(textBox2.Text) * Classes.Rates.Rate4).ToString() + " грн");
                MainWindow.U.Money -= Convert.ToInt32(textBox2.Text) * Classes.Rates.Rate4;
                for (int i = 0; i < MainWindow.L.Count; i++) {
                    if (MainWindow.U.Phone == MainWindow.L[i].Phone) {
                        MainWindow.L[i] = MainWindow.U;
                    }
                }
            }
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            PhoneService.Classes.Pages.SetMainPage(F);
            F.Navigate(PhoneService.Classes.Pages.MainPage);
        }
    }
}
