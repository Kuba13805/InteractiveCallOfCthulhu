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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CthulhuPlayerCard
{
    /// <summary>
    /// Interaction logic for NewCharacterWindow.xaml
    /// </summary>
    public partial class NewCharacterWindow : Window
    {
        public NewCharacterWindow()
        {
            InitializeComponent();
        }
        private void CheckForNameInTable(TextBox nameTextBox)
        {
            int nameToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_postaci FROM ListaPostaci WHERE Imie = " + nameTextBox.Text + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            nameToSearch = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (nameToSearch == 0)
            {
                if (MessageBox.Show("Given name was not found in names list. Do you want to add this name?", "Name not found", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    QuickNameAdding Window = new QuickNameAdding();
                    Window.Show();
                }
            }
        }
        private void CheckForSurnameInTable(TextBox surnameTextBox)
        {
            int surnameToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_postaci FROM ListaPostaci WHERE Nazwisko = " + surnameTextBox.Text + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            surnameToSearch = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (surnameToSearch == 0)
            {
                if (MessageBox.Show("Given surname was not found in surnames list. Do you want to add this surname?", "Surname not found", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    QuickSurnameAdding Window = new QuickSurnameAdding();
                    Window.Show();
                }
            }
        }
        private void CheckForItemTypeInTable(TextBox typeTextBox)
        {
            int typeToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_typu FROM ListaTypow WHERE Nazwa_typu = " + typeTextBox.Text + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            typeToSearch = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (typeToSearch == 0)
            {
                if (MessageBox.Show("Given type was not found in types list. Do you want to add this type?", "Type not found", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    QuickSurnameAdding Window = new QuickSurnameAdding();
                    Window.Show();
                }
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Window = new MainWindow();
            Window.Show();
            Close();
        }
    }
}
