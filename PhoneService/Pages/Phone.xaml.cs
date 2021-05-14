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
    /// Interaction logic for Phone.xaml
    /// </summary>
    public partial class Phone : Page {
        public Frame F;
        public Phone(Frame F) {
            InitializeComponent();
            this.F = F;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if(combo.SelectedIndex != -1 && MainWindow.U.Rate == -1) {
                int T = 0;
                if(combo.SelectedIndex == 0) {
                    MainWindow.U.Money -= Convert.ToInt32(textBox2.Text) * Classes.Rates.Rate1;
                    T = Convert.ToInt32(textBox2.Text) * Classes.Rates.Rate1;
                }
                else if(combo.SelectedIndex == 1) {
                    MainWindow.U.Money -= Convert.ToInt32(textBox2.Text) * Classes.Rates.Rate2;
                    T = Convert.ToInt32(textBox2.Text) * Classes.Rates.Rate2;
                }
                else if(combo.SelectedIndex == 2) {
                    MainWindow.U.Money -= Convert.ToInt32(textBox2.Text) * Classes.Rates.Rate3;
                    T = Convert.ToInt32(textBox2.Text) * Classes.Rates.Rate3;
                }
                MainWindow.U.Calls.Add(textBox1.Text + "/" + textBox2.Text);
                for(int i = 0; i < MainWindow.L.Count; i++) {
                    if(MainWindow.U.Phone == MainWindow.L[i].Phone) {
                        MainWindow.L[i] = MainWindow.U;
                    }
                }
                MessageBox.Show("Номер телефону: " + textBox1.Text + "\n" +
                    "Тривалість дзвінку: " + textBox2.Text + "\n"
                    + "Вартість дзвінку: " + T.ToString() + " грн");
            }
            else {
                if(combo.SelectedIndex != -1 && MainWindow.U.Rate != -1) {
                    MainWindow.U.Calls.Add(textBox1.Text + "/" + textBox2.Text);
                    MessageBox.Show("Номер телефону: " + textBox1.Text + "\n" +
                   "Тривалість дзвінку: " + textBox2.Text + "\n"
                   + "Вартість дзвінку: 0 грн");
                }
            }
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            PhoneService.Classes.Pages.SetMainPage(F);
            F.Navigate(PhoneService.Classes.Pages.MainPage);
        }
    }
}
