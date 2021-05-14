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
using PhoneService.Classes;

namespace PhoneService.Pages {
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page {
        public Frame F;
        public Login(Frame F) {
            this.F = F;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            foreach(User U in MainWindow.L) {
                if(U.Phone == textBox1.Text && U.Password == textBox2.Text) {
                    MainWindow.U = U;
                    PhoneService.Classes.Pages.SetMainPage(F);
                    F.Navigate(PhoneService.Classes.Pages.MainPage);
                    break;
                }
            }
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            Classes.Pages.SetRegisterPage(F);
            F.Navigate(Classes.Pages.RegisterPage);
        }
    }
}
