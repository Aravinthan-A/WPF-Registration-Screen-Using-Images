using System.Windows;

namespace Username2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pwdpassword.Password == "1234" && pwdlogin.Password == "1234" && txtFullname.Text == "Aravinthan" && txtmail.Text == "aravinthan1606@gmail.com") 
            {
                MessageBoxResult result = MessageBox.Show("Are You Sure Create Account", "Coform", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Yes");
                }
                else if (result == MessageBoxResult.No)
                {
                    MessageBox.Show("No");
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
            if (pwdpassword.Password != "1234" && pwdlogin.Password != "" && txtFullname.Text != "" && txtmail.Text != "")
            {
                lblpass.Content = " Invalid";
                lbllogin.Content = "";
                lblname.Content = "";
                lblmail2.Content = "";
            }
            else if (pwdpassword.Password != "" && pwdlogin.Password != "1234" && txtFullname.Text != "" && txtmail.Text != "")
            {
                lblpass.Content = " ";
                lbllogin.Content = "Invalid";
                lblname.Content = "";
                lblmail2.Content = "";
            }
            else if (pwdpassword.Password != "" && pwdlogin.Password != "" && txtFullname.Text != "Aravinthan" && txtmail.Text != "")
            {
                lblpass.Content = " ";
                lbllogin.Content = "";
                lblname.Content = "Invalid Name";
                lblmail2.Content = "";
            }
            else if (pwdpassword.Password != "" && pwdlogin.Password != "" && txtFullname.Text != "" && txtmail.Text != "aravinthan1606@gmail.com")
            {
                lblpass.Content = " ";
                lbllogin.Content = "";
                lblname.Content = "";
                lblmail2.Content = "Invalidmail";
            }
            else if (pwdpassword.Password == "1234" && pwdlogin.Password == "1234" && txtFullname.Text == "Aravinthan" && txtmail.Text == "aravinthan1606@gmail.com")
            {
                lblpass.Content = "";
                lbllogin.Content = "";
                lblname.Content = "";
                lblmail2.Content = "";
            }
            else if (pwdpassword.Password == "" && pwdlogin.Password == "" && txtFullname.Text == "" && txtmail.Text == "") 
            {
                MessageBoxResult result = MessageBox.Show("Are You Sure Create Account", "Coform", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    lblpass.Content = "Cannot Create Account"; 
                }
            }
            }
            }












            //if (txtFullname.Text == "Aravinthan" && txtmail.Text == "aravinthan1606@gmail.com" && c)
            //{

                //    MessageBoxResult result = MessageBox.Show("Are You Sure Create Account", "Coform", MessageBoxButton.YesNoCancel);
                //    if (result == MessageBoxResult.Yes)
                //    {
                //        MessageBox.Show("Account created", "Conform", MessageBoxButton.OK);
                //    }
                //    else if (result == MessageBoxResult.No)
                //    {
                //        MessageBox.Show("Account Not created", "Conform", MessageBoxButton.OK);
                //    }
                //    else if (result == MessageBoxResult.Cancel)
                //    {
                //        MessageBox.Show("Account creation cancelled", "Conform", MessageBoxButton.OK);
                //    }
                //    else if (txtFullname.Text != "Aravinthan" && txtmail.Text != "aravinthan1606@gmail.com" && pwdpassword.Password != "1234" && pwdlogin.Password != "1234")
                //    {
                //        MessageBox.Show("Invalid Details", "Conform", MessageBoxButton.YesNoCancel);

                }

            
        
    





















//                else if (txtFullname.Text != "" && txtmail.Text == "" && pwdpassword.Password == "" && pwdlogin.Password == "")
//                {
//                    MessageBox.Show("Enter the Email password conform password", "conform", MessageBoxButton.OK, MessageBoxImage.Error);
//                }
//                else if (txtFullname.Text == "" && txtmail.Text != "" && pwdpassword.Password == "" && pwdlogin.Password == "")
//                {
//                    MessageBox.Show("Enter Fullname password Conform password", "Conform", MessageBoxButton.OK, MessageBoxImage.Error);
//                }
//                else if (txtFullname.Text == "" && txtmail.Text == "" && pwdpassword.Password != "" && pwdlogin.Password == "")
//                {
//                    MessageBox.Show("Enter Fullname mail confornpassword");
//                }
//                else if (txtFullname.Text == "" && txtmail.Text == "" && pwdpassword.Password == "" && pwdlogin.Password != "")
//                {
//                    MessageBox.Show("Enter Fullname mail password", "Conform", MessageBoxButton.OK, MessageBoxImage.Error);
//                }
//            else if (txtFullname.Text == "" && txtmail.Text == "" && pwdpassword.Password == "" && pwdlogin.Password == "")
//            {
//                MessageBox.Show("Fill all the Details", "Conform", MessageBoxButton.OK, MessageBoxImage.Error);
//            }
//            else if (txtFullname.Text != "" && txtmail.Text != "" && pwdpassword.Password != "" && pwdlogin.Password == "")
//                {
//                    MessageBox.Show("Fill Conform password", "Conform", MessageBoxButton.OK, MessageBoxImage.Error);
//                }
//                else if (txtFullname.Text != "" && txtmail.Text != "" && pwdpassword.Password == "" && pwdlogin.Password != "")
//                {
//                    MessageBox.Show("Fill Pasword", "Conform", MessageBoxButton.OK, MessageBoxImage.Error);
//                }
//                else if (txtFullname.Text != "" && txtmail.Text == "" && pwdpassword.Password != "" && pwdlogin.Password != "")
//                {
//                    MessageBox.Show("Fill Email", "Conform", MessageBoxButton.OK, MessageBoxImage.Error);
//                }
//                else if (txtFullname.Text != "" && txtmail.Text != "" && pwdpassword.Password != "" && pwdlogin.Password != "")
//                {
//                    MessageBox.Show("Enter Full name", "Conform", MessageBoxButton.OK, MessageBoxImage.Error);
//                }
//                else if (txtFullname.Text == "")
//                {
//                    MessageBox.Show("Enter the Name");
//                }
//            }
//        }
//    }
//}

