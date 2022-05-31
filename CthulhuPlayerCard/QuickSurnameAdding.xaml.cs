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
    /// Interaction logic for QuickSurnameAdding.xaml
    /// </summary>
    public partial class QuickSurnameAdding : Window
    {
        public QuickSurnameAdding()
        {
            InitializeComponent();
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
            string sql = "Select Id_nazwiska FROM Nazwiska WHERE Pochodzenie_nazwiska = " + "'" + origin + "'" + "AND Nazwisko = " + "'" + givenSurname + "'" + ";";
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
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkSurnameSpelling = CheckSpelling(EnterSurname.Text, "Enter surname");
            bool checkOriginSpelling = CheckSpelling(EnterSurnameOrigin.Text, "Enter surname origin");
            bool checkIfSurnameIsInTable = SearchForSurname(EnterSurname.Text, EnterSurnameOrigin.Text);
            if (checkSurnameSpelling == true && checkOriginSpelling == true && checkIfSurnameIsInTable == true)
            {
                string surnameToInput = UpdateWord(EnterSurname.Text);
                string originToInput = UpdateWord(EnterSurnameOrigin.Text);
                int idToInput = RandomId();
                InsertIntoNamesTable(surnameToInput, originToInput, idToInput);
                Close();
            }
        }
        private void InsertIntoNamesTable(string name, string origin, int id)
        {
            Projekt_CthulhuDataSetTableAdapters.NazwiskaTableAdapter nazwiskaTableAdapter = new Projekt_CthulhuDataSetTableAdapters.NazwiskaTableAdapter();
            nazwiskaTableAdapter.Insert(id.ToString(), name, origin);
            MessageBox.Show("Surname " + '"' + name + '"' + " with id: " + '"' + id + '"' + " has been added", "Surname added");
            Close();
        }
    }
}
