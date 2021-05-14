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
using PhoneService.Pages;

namespace PhoneService.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Register : Page {
        public Frame F { get; set; }
        public Register(Frame F) {
            this.F = F;
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            User U = new User();
            U.Phone = textBox1.Text;
            U.PIB = textBox2.Text;
            U.Address = textBox3.Text;
            U.CodePass = textBox4.Text;
            U.Password = textBox5.Text;
            U.Rate = -1;
            U.Money = 0;
            U.Calls = new List<string>();
            MainWindow.L.Add(U);
            Classes.Pages.SetLoginPage(F);
            F.Navigate(Classes.Pages.LoginPage);
        }
    }
}
