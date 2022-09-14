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

        string password = "";
        string socialNumber = "";

        private void createAccount_MouseDoubleClick(object sender, MouseButtonEventArgs e) //link to create an account
        {
            windows.CreateAccount createaccount = new windows.CreateAccount();
            this.Close();
            createaccount.Show();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e) //loggin
        {

            password = txtbox_Password.Text;
            socialNumber = txtbox_UserName.Text;

            bool match = false; 
            List<ClassLibrary1.User> users = ClassLibrary1.Bank.getUsers();

            foreach (ClassLibrary1.User u in users)
            { 
                if(u.Password == password && u.socialNumber == socialNumber)
                {
                    match = true;
                    ClassLibrary1.Bank.setUserIndex(u);
                }
            }

            if (match)
            {
                //login 
                windows.User user = new windows.User();
                this.Close();
                user.Show();
            }
            else
            {
                error_msg.Content = "Does not match any user";
            }
        }
    }
}
