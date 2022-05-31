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
using System.IO;
using System.Data.SqlClient;

namespace CthulhuPlayerCard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _DBConnectionSet;
        bool DBConnectionSet
        {
            get => _DBConnectionSet = CheckForDBConnection();
        }
        public MainWindow()
        {
            InitializeComponent();
            if (DBConnectionSet == false)
            {
                NewCharacterButton.IsEnabled = false;
                LoadCharacterButton.IsEnabled = false;
            }
            else
            {
                NewCharacterButton.IsEnabled = true;
                LoadCharacterButton.IsEnabled = true;
            }


        }

        private void ButtonExitClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void LoadCharacterButtonClick(object sender, RoutedEventArgs e)
        {
            LoadCharacterWindow LoadCharacterWindow = new LoadCharacterWindow();
            LoadCharacterWindow.Show();
            Close();
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        { 
            Options Options = new Options();
            Options.Show();
            Close();
        }

        private void NewCharacter_Click(object sender, RoutedEventArgs e)
        {
            NewCharacterWindow NewCharacterWindow = new NewCharacterWindow();
            NewCharacterWindow.Show();
            Close();
        }
        private bool CheckForDBConnection()
        {
            SqlConnection conn = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            bool result = true;

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection with database cannot be opened!", "Wrong Database");
                result = false;
            }
            return result;
        }
    }
}
