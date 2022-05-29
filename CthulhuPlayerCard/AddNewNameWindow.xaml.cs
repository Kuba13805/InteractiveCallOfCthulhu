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
    /// Interaction logic for AddNewNameWindow.xaml
    /// </summary>
    public partial class AddNewNameWindow : Window
    {
        public AddNewNameWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CthulhuPlayerCard.Projekt_CthulhuDataSet projekt_CthulhuDataSet = ((CthulhuPlayerCard.Projekt_CthulhuDataSet)(this.FindResource("projekt_CthulhuDataSet")));
            // Load data into the table Imiona. You can modify this code as needed.
            CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ImionaTableAdapter projekt_CthulhuDataSetImionaTableAdapter = new CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ImionaTableAdapter();
            projekt_CthulhuDataSetImionaTableAdapter.Fill(projekt_CthulhuDataSet.Imiona);
            System.Windows.Data.CollectionViewSource imionaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("imionaViewSource")));
            imionaViewSource.View.MoveCurrentToFirst();

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
        private bool CheckNameSex()
        {
            bool nameSexChecked = true;
            EnterNameSex.Text.ToUpper();
            if (EnterNameSex.Text == "M" || EnterNameSex.Text == "F")
            {
                nameSexChecked = true;
            }
            else
            {
                MessageBox.Show("Enter " + '"' + 'M' + '"' + "for male name and " + 'F' + '"' + "for female name.", "Wrong name sex");
                nameSexChecked = false;
            }
            return nameSexChecked;
        }
        private bool SearchForName(string nameSex, string origin)
        {
            bool nameInTable = true;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select * FROM Imiona WHERE Pochodzenie_imienia = " + "'" + origin + "'" +" AND Plec_imienia = " +"'" + nameSex +"'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult > 1)
            {
                MessageBox.Show("Name with the same origin and sex is already in table." + searchResult, "Name already in table!");
                nameInTable = false;
            }
            return nameInTable;
        }
        private bool SearchForCharacter(string nameID)
        {
            bool characterWithNameInTable = false;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_postaci FROM CzyIstniejePostac WHERE Id_imienia = " + "'" + nameID + "'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult >= 1)
            {
                characterWithNameInTable = true;
            }
            return characterWithNameInTable;
        }
        private int RandomId()
        {
            Random roll = new Random();
            int rollResult = roll.Next(1, 9999);

            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_imienia FROM Imiona WHERE Id_imienia = " + rollResult + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult == 1)
            {
                RandomId();
            }
            return rollResult;
        }
        private void AddNameButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkNameSpelling = CheckSpelling(EnterNewName.Text, "Enter name");
            bool checkOriginSpelling = CheckSpelling(EnterNameOrigin.Text, "Enter name origin");
            bool checkMaleFemaleName = CheckNameSex();
            bool checkIfNameIsInTable = SearchForName(EnterNameSex.Text, EnterNameOrigin.Text);
            if (checkNameSpelling == true && checkOriginSpelling == true && checkMaleFemaleName == true && checkIfNameIsInTable == true)
            {
                string nameToInput = UpdateWord(EnterNewName.Text);
                string originToInput = UpdateWord(EnterNameOrigin.Text);
                int idToInput = RandomId();
                string nameSexToInput = EnterNameSex.Text;
                InsertIntoNamesTable(nameToInput, originToInput, nameSexToInput, idToInput);
            }
        }
        private void InsertIntoNamesTable(string name, string origin, string nameSex, int id)
        {
            Projekt_CthulhuDataSetTableAdapters.ImionaTableAdapter imionaTableAdapter = new Projekt_CthulhuDataSetTableAdapters.ImionaTableAdapter();
            imionaTableAdapter.Insert(id.ToString(), name, origin, nameSex);
            MessageBox.Show("Name " + '"' + name + '"' + " with id: " + '"' + id+ '"' + " has been added", "Name added");
            AddNewNameWindow Window = new AddNewNameWindow();
            Window.Show();
            Close();
        }
        private void ClearTexboxButton_Click(object sender, RoutedEventArgs e)
        {
            if ((EnterID.Text == "") && (EnterNewName.Text == "") && ( EnterNameSex.Text == "") && (EnterNameOrigin.Text == ""))
            {
                MessageBox.Show("All spaces are clear", "All clear!");
            }
            else
            {
                EnterID.Clear();
                EnterNewName.Clear();
                EnterNameSex.Clear();
                EnterNameOrigin.Clear();
            }
        }

        private void DeleteNameButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this name?", "Delete name?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                bool canCharacterBeDeleted = SearchForCharacter(EnterID.Text);
                if (canCharacterBeDeleted == true)
                {
                    MessageBox.Show("There is more than one character with this name. You cannot delete this name.", "Deleting not possible");
                }
                else
                {
                    int IdToDelete;
                    SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
                    sqlConnection.Open();
                    string sql = "DELETE FROM Imiona WHERE Id_imienia = " + EnterID.Text + ";";
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = sql;
                    IdToDelete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    MessageBox.Show("Name with id: " + EnterID.Text + " has been removed.", "Name deleted!");
                    AddNewNameWindow Window = new AddNewNameWindow();
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
