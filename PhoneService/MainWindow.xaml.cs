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

namespace PhoneService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static List<User> L { get; set; } = new List<User>();
        public static User U { get; set; }
        public MainWindow() {
            InitializeComponent();
            Classes.Pages.SetLoginPage(F);
            F.Navigate(Classes.Pages.LoginPage);
        }
    }
}
