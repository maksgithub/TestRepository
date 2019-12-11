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
using DBCore;

namespace UsersStorage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DBReactor _dbReactor;
        public MainWindow()
        {
            _dbReactor = new DBReactor();
            _dbReactor.Open();
            InitializeComponent();
            lableAnswer.Content = "Enter user Name and Password";
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _dbReactor.AddUser(TextBoxName.Text.ToUpper(), TextBoxPassword.Text.ToUpper());
            lableAnswer.Content = $"User {TextBoxName.Text} created";
            TextBoxName.Clear();
            TextBoxPassword.Clear();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            lableAnswer.Content = "";
            if (TextBoxName.Text != "")
            {
                lableAnswer.Content = _dbReactor.Search(TextBoxName.Text.ToUpper());
            }
        }
    }
}
