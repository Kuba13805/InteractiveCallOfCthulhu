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
    /// Interaction logic for QuickNameAdding.xaml
    /// </summary>
    public partial class QuickNameAdding : Window
    {
        public QuickNameAdding()
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
        private bool SearchForName(string name, string nameSex, string origin)
        {
            bool nameInTable = true;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select * FROM Imiona WHERE Pochodzenie_imienia = " + "'" + origin + "'" + " AND Plec_imienia = " + "'" + nameSex + "'" + " AND Imie = " + "'" + name + "'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult > 1)
            {
                MessageBox.Show("Name with the same origin and sex is already in table.", "Name already in table!");
                nameInTable = false;
            }
            return nameInTable;
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
        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkNameSpelling = CheckSpelling(EnterNewName.Text, "Enter name");
            bool checkOriginSpelling = CheckSpelling(EnterNameOrigin.Text, "Enter name origin");
            bool checkMaleFemaleName = CheckNameSex();
            bool checkIfNameIsInTable = SearchForName(EnterNewName.Text, EnterNameSex.Text, EnterNameOrigin.Text);
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
            MessageBox.Show("Name " + '"' + name + '"' + " with id: " + '"' + id + '"' + " has been added", "Name added");
            Close();
        }
    }
}
