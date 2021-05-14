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
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Page {
        public Frame F;
        public History(Frame F) {
            this.F = F;
            InitializeComponent();
            foreach(string T in MainWindow.U.Calls) {
                listBox.Items.Add("Дзвінок на номер " + T.Split('/')[0] + " тривалістю " + T.Split('/')[1] + " хв");
            }
        }

        private void Label_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            PhoneService.Classes.Pages.SetMainPage(F);
            F.Navigate(PhoneService.Classes.Pages.MainPage);
        }
    }
}
