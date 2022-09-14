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
using System.Windows.Shapes;

namespace NordicBank.windows
{
    /// <summary>
    /// Interaction logic for Loggin.xaml
    /// </summary>
    public partial class Loggin : Window
    {
        public Loggin()
        {
            InitializeComponent();
        }


        private void txtbox_UserInfo_TextInput(object sender, TextCompositionEventArgs e) //user info
        {

        }

        private void createAccount_MouseDoubleClick(object sender, MouseButtonEventArgs e) //link to create an account
        {
            windows.CreateAccount createaccount = new windows.CreateAccount();
            this.Close();
            createaccount.Show();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e) //loggin
        {

        }
    }
}
