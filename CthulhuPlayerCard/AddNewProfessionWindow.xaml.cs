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
    /// Interaction logic for AddNewProfessionWindow.xaml
    /// </summary>
    public partial class AddNewProfessionWindow : Window
    {
        public AddNewProfessionWindow()
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
        private bool SearchForProfession(string givenprofession)
        {
            bool professionInTable = true;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_zawodu FROM Zawody WHERE Nazwa_zawodu = " + "'" + givenprofession + "'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult > 1)
            {
                MessageBox.Show("This profession is already in table.", "Profession already in table!");
                professionInTable = false;
            }
            return professionInTable;
        }
        private bool SearchForCharacter(string givenprofessionID)
        {
            bool characterWithProfessionInTable = false;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_postaci FROM CzyIstniejePostac WHERE Id_zawodu = " + "'" + givenprofessionID + "'" + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult >= 1)
            {
                characterWithProfessionInTable = true;
            }
            return characterWithProfessionInTable;
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
            string sql = "Select Id_zawodu FROM Zawody WHERE Id_zawodu = " + rollResult + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult == 1)
            {
                RandomId();
            }
            return rollResult;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CthulhuPlayerCard.Projekt_CthulhuDataSet projekt_CthulhuDataSet = ((CthulhuPlayerCard.Projekt_CthulhuDataSet)(this.FindResource("projekt_CthulhuDataSet")));
            // Load data into the table ListaZawodow. You can modify this code as needed.
            CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ListaZawodowTableAdapter projekt_CthulhuDataSetListaZawodowTableAdapter = new CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ListaZawodowTableAdapter();
            projekt_CthulhuDataSetListaZawodowTableAdapter.Fill(projekt_CthulhuDataSet.ListaZawodow);
            System.Windows.Data.CollectionViewSource listaZawodowViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("listaZawodowViewSource")));
            listaZawodowViewSource.View.MoveCurrentToFirst();
        }

        private void AddProfessionButton_Click(object sender, RoutedEventArgs e)
        {
            bool checkProfessionSpelling = CheckSpelling(EnterProfessionName.Text, "Enter profession name");
            bool checkIfProfessionIsInTable = SearchForProfession(EnterProfessionName.Text);
            if (checkProfessionSpelling == true && checkIfProfessionIsInTable == true)
            {
                string historyChecked = CheckForSkill(HistoryCheckBox);
                string brawlChecked = CheckForSkill(BrawlCheckBox);
                string perceptivityChecked = CheckForSkill(PerceptivityCheckBox);
                string firstAidChecked = CheckForSkill(FirstAidCheckBox);
                string firearmChecked = CheckForSkill(FirearmCheckBox);
                string professionToInput = UpdateWord(EnterProfessionName.Text);
                int idToInput = RandomId();
                InsertIntoNamesTable(professionToInput, idToInput, historyChecked, brawlChecked, perceptivityChecked, firstAidChecked, firearmChecked);
            }
        }
        private void InsertIntoNamesTable(string name, int id, string skill1, string skill2, string skill3, string skill4, string skill5)
        {
            Projekt_CthulhuDataSetTableAdapters.ZawodyTableAdapter zawodyTableAdapter = new Projekt_CthulhuDataSetTableAdapters.ZawodyTableAdapter();
            zawodyTableAdapter.Insert(id.ToString(), name, skill1, skill2, skill3, skill4, skill5);
            MessageBox.Show("Profession " + '"' + name + '"' + " with id: " + '"' + id + '"' + " has been added", "Profession added");
            AddNewProfessionWindow Window = new AddNewProfessionWindow();
            Window.Show();
            Close();
        }
        private void ClearTexboxButton_Click(object sender, RoutedEventArgs e)
        {
            if ((EnterID.Text == "") && (EnterProfessionName.Text == ""))
            {
                MessageBox.Show("All spaces are clear", "All clear!");
            }
            else
            {
                EnterID.Clear();
                EnterProfessionName.Clear();
                HistoryCheckBox.IsChecked = false;
                BrawlCheckBox.IsChecked = false;
                PerceptivityCheckBox.IsChecked = false;
                FirstAidCheckBox.IsChecked = false;
                FirearmCheckBox.IsChecked = false;
            }
        }

        private void DeleteProfessionButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this profession?", "Delete profession?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                bool canCharacterBeDeleted = SearchForCharacter(EnterID.Text);
                if (canCharacterBeDeleted == true)
                {
                    MessageBox.Show("There is more than one character with this profession. You cannot delete this profession.", "Deleting not possible");
                }
                else
                {
                    int IdToDelete;
                    SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
                    sqlConnection.Open();
                    string sql = "DELETE FROM Zawody WHERE Id_zawodu = " + EnterID.Text + ";";
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = sql;
                    IdToDelete = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    MessageBox.Show("Profession with id: " + EnterID.Text + " has been removed.", "Profession deleted!");
                    AddNewProfessionWindow Window = new AddNewProfessionWindow();
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
        private string CheckForSkill(CheckBox skill)
        {
            string skillIsChecked = "N";
            if (skill.IsChecked == true)
            {
                skillIsChecked = "T";
            }
            return skillIsChecked;
        }
    }
}
