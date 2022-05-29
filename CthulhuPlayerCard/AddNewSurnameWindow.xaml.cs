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
    /// Interaction logic for AddNewSurnameWindow.xaml
    /// </summary>
    public partial class AddNewSurnameWindow : Window
    {
        public AddNewSurnameWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CthulhuPlayerCard.Projekt_CthulhuDataSet projekt_CthulhuDataSet = ((CthulhuPlayerCard.Projekt_CthulhuDataSet)(this.FindResource("projekt_CthulhuDataSet")));
            // Load data into the table Nazwiska. You can modify this code as needed.
            CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.NazwiskaTableAdapter projekt_CthulhuDataSetNazwiskaTableAdapter = new CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.NazwiskaTableAdapter();
            projekt_CthulhuDataSetNazwiskaTableAdapter.Fill(projekt_CthulhuDataSet.Nazwiska);
            System.Windows.Data.CollectionViewSource nazwiskaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("nazwiskaViewSource")));
            nazwiskaViewSource.View.MoveCurrentToFirst();
        }
        private bool CheckSpelling(string givenWord, string typeOfGivenWord)
        {
            bool givenWordSpellingCheck = true;
            if (givenWord == "")
            {
                MessageBox.Show('"' + typeOfGivenWord + '"' + " cannot be empty!", "Empty " + '"' + typeOfGivenWord + '"');
            }
            else
            {
                Regex rgx = new Regex("^[A-Za-z]*$");
                bool cointainsSpecialCharacter = rgx.IsMatch(givenWord);
                if (cointainsSpecialCharacter == false)
                {
                    MessageBox.Show("Word entered in " + '"' + typeOfGivenWord + '"' + " contains characters that are not allowed. Please, use only letters and avoid spaces.", "Wrong character!");
                    givenWordSpellingCheck = false;
                }
            }
            return givenWordSpellingCheck;
        }
        private string UpdateWord(string givenWord)
        {
            givenWord = givenWord.ToUpper();
            char firstLetter;
            string restOfNewGivenWord = "";
            char[] arr;

            arr = givenWord.ToArray();
            for (int i = 1; i < arr.Length; i++)
            {
                restOfNewGivenWord = restOfNewGivenWord + arr[i];
            }
            firstLetter = arr[0];
            string updatedWord = firstLetter + restOfNewGivenWord.ToLower();
            return updatedWord;
        }
        private bool SearchForSurname(string givenSurname, string origin)
        {
            bool surnameInTable = true;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_nazwiska FROM Nazwiska WHERE Pochodzenie_nazwiska = " + "'" + origin + "'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult > 1)
            {
                MessageBox.Show("Surname with the same origin is already in table.", "Surname already in table!");
                surnameInTable = false;
            }
            return surnameInTable;        
        }
        private bool SearchForCharacter(string surnameID)
        {
            bool characterWithSurnameInTable = false;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_postaci FROM CzyIstniejePostac WHERE Id_nazwiska = " + "'" + surnameID + "'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult >= 1)
            {
                characterWithSurnameInTable = true;
            }
            return characterWithSurnameInTable;
        }
        private int RandomId()
        {
            Random roll = new Random();
            int rollResult = roll.Next(1, 9999);

            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_nazwiska FROM Nazwiska WHERE Id_nazwiska = " + rollResult + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult == 1)
            {
                RandomId();
            }
            return rollResult;
        }
        private void AddSurnameButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkSurnameSpelling = CheckSpelling(EnterNewSurname.Text, "Enter surname");
            bool checkOriginSpelling = CheckSpelling(EnterSurnameOrigin.Text, "Enter surname origin");
            bool checkIfSurnameIsInTable = SearchForSurname(EnterNewSurname.Text, EnterSurnameOrigin.Text);
            if (checkSurnameSpelling == true && checkOriginSpelling == true && checkIfSurnameIsInTable == true)
            {
                string surnameToInput = UpdateWord(EnterNewSurname.Text);
                string originToInput = UpdateWord(EnterSurnameOrigin.Text);
                int idToInput = RandomId();
                InsertIntoNamesTable(surnameToInput, originToInput, idToInput);
            }
        }
        private void InsertIntoNamesTable(string name, string origin, int id)
        {
            Projekt_CthulhuDataSetTableAdapters.NazwiskaTableAdapter nazwiskaTableAdapter = new Projekt_CthulhuDataSetTableAdapters.NazwiskaTableAdapter();
            nazwiskaTableAdapter.Insert(id.ToString(), name, origin);
            MessageBox.Show("Name " + '"' + name + '"' + " with id: " + '"' + id + '"' + " has been added", "Name added");
            AddNewSurnameWindow Window = new AddNewSurnameWindow();
            Window.Show();
            Close();
        }
        private void ClearTexboxButton_Click(object sender, RoutedEventArgs e)
        {
            if ((EnterID.Text == "") && (EnterNewSurname.Text == "") && (EnterSurnameOrigin.Text == ""))
            {
                MessageBox.Show("All spaces are clear", "All clear!");
            }
            else
            {
                EnterID.Clear();
                EnterNewSurname.Clear();
                EnterSurnameOrigin.Clear();
            }
        }

        private void DeleteSurnameButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this surname?", "Delete surname?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                bool canCharacterBeDeleted = SearchForCharacter(EnterID.Text);
                if (canCharacterBeDeleted == true)
                {
                    MessageBox.Show("There is more than one character with this surname. You cannot delete this surname.", "Deleting not possible");
                }
                else
                {
                int IdToDelete;
                SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
                sqlConnection.Open();
                string sql = "DELETE FROM Nazwiska WHERE Id_nazwiska = " + EnterID.Text + ";";
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sql;
                IdToDelete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                MessageBox.Show("Surname with id: " + EnterID.Text + " has been removed.", "Surname deleted!");
                AddNewSurnameWindow Window = new AddNewSurnameWindow();
                Window.Show();
                Close();          
                }
            }
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            Options Window = new Options();
            Window.Show();
            Close();
        }
    }
}
