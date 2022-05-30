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
    /// Interaction logic for QuickItemTypeAdding.xaml
    /// </summary>
    public partial class QuickItemTypeAdding : Window
    {
        public QuickItemTypeAdding()
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
        private bool SearchForType(string givenType)
        {
            bool TypeInTable = true;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_typu FROM Typy_przedmiotów WHERE Nazwa_typu = " + "'" + givenType + "'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult >= 1)
            {
                MessageBox.Show("This type is already in table.", "Type already in table!");
                TypeInTable = false;
            }
            return TypeInTable;
        }
        private bool SearchForItem(string givenTypeID)
        {
            bool itemWithTypeInTable = false;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_postaci FROM ListaPrzedmiotow WHERE Id_typu = " + "'" + givenTypeID + "'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult >= 1)
            {
                itemWithTypeInTable = true;
            }
            return itemWithTypeInTable;
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
        private int RandomId()
        {
            Random roll = new Random();
            int rollResult = roll.Next(1, 9999);

            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_typu FROM ListaPrzedmiotow WHERE Id_typu = " + rollResult + ";";
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
            bool checkTypeSpelling = CheckSpelling(EnterType.Text, "Enter type name");
            bool checkIfTypeIsInTable = SearchForType(EnterType.Text);
            if (checkTypeSpelling == true && checkIfTypeIsInTable == true)
            {
                string typeToInput = UpdateWord(EnterType.Text);
                int idToInput = RandomId();
                InsertIntoNamesTable(typeToInput, idToInput);
            }
        }
        private void InsertIntoNamesTable(string name, int id)
        {
            Projekt_CthulhuDataSetTableAdapters.Typy_przedmiotówTableAdapter typyPrzedmiotowTableAdapter = new Projekt_CthulhuDataSetTableAdapters.Typy_przedmiotówTableAdapter();
            typyPrzedmiotowTableAdapter.Insert(id.ToString(), name);
            MessageBox.Show("Type " + '"' + name + '"' + " with id: " + '"' + id + '"' + " has been added", "Type added");
            Close();
        }
    }
}
