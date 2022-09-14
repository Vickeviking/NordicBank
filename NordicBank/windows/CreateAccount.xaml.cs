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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        string password = "";
        string phoneNumber = "";
        string SocialNumber = "";

        public CreateAccount()
        {
            InitializeComponent();
        }


        private void Create_btn_Click(object sender, RoutedEventArgs e) // create account --> send to login page
        {
            password = txtbox_Password.Text;
            phoneNumber = txtbox_PhoneNumber.Text;
            SocialNumber = txtbox_UserName.Text;

            if (password.Length < 1 || SocialNumber.Length < 1 || phoneNumber.Length < 1)
            {
                error_msg.Content = "Fill in all fields";
            }
            else if (SocialNumber.Length < 9)
            {
                error_msg.Content = "Socialnumber is incomplete";
            }
            else if (phoneNumber.ToString().Length < 9)
            {
                error_msg.Content = "Socialnumber is incomplete";
            }
            else
            {
                ClassLibrary1.User user = new ClassLibrary1.User(SocialNumber, password, phoneNumber);
                ClassLibrary1.Bank.AddUser(user);

                //switch to login page

                windows.Loggin login = new windows.Loggin();
                this.Hide();
                login.Show();

            }
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            windows.Loggin loggin = new windows.Loggin();
            this.Hide();
            loggin.Show();
        }
    }
}
