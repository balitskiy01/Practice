using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using PhoneService.Classes;
using PhoneService.Pages;

namespace PhoneService.Classes {
    public static class Pages {
        public static Register RegisterPage { get; set; }
        public static Login LoginPage { get; set; }
        public static Main MainPage { get; set; }
        public static Phone PhonePage { get; set; }
        public static PhoneService.Pages.Rates RatesPage { get; set; }
        public static Internet InternetPage { get; set; }
        public static History HistoryPage { get; set; }

        public static void SetRegisterPage(Frame F) {
            RegisterPage = new Register(F);
        }
        public static void SetLoginPage(Frame F) {
            LoginPage = new Login(F);
        }
        public static void SetMainPage(Frame F) {
            MainPage = new Main(F);
        }
        public static void SetPhonePage(Frame F) {
            PhonePage = new Phone(F);
        }
        public static void SetRatesPage(Frame F) {
            RatesPage = new PhoneService.Pages.Rates(F);
        }
        public static void SetInternetPage(Frame F) {
            InternetPage = new Internet(F);
        }
        public static void SetHistoryPage(Frame F) {
            HistoryPage = new History(F);
        }
    }
}
