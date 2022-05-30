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
        private bool CheckForNameInTable(string nameTextBox)
        {
            bool nameChecked = true;
            int nameToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_postaci FROM ListaPostaci WHERE Imie = " + "'" + nameTextBox +  "';";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            nameToSearch = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (nameToSearch == 0)
            {
                if (MessageBox.Show("Given name was not found in names list. Do you want to add this name?", "Name not found", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    nameChecked = false;
                    QuickNameAdding Window = new QuickNameAdding();
                    Window.Show();
                }
            }
            return nameChecked;
        }
        private bool CheckForSurnameInTable(string surnameTextBox)
        {
            bool surnameChecked = true;
            int surnameToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_postaci FROM ListaPostaci WHERE Nazwisko = '" + surnameTextBox + "';";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            surnameToSearch = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (surnameToSearch == 0)
            {
                if (MessageBox.Show("Given surname was not found in surnames list. Do you want to add this surname?", "Surname not found", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    surnameChecked = false;
                    QuickSurnameAdding Window = new QuickSurnameAdding();
                    Window.Show();
                }
            }
            return surnameChecked;
        }
        private bool CheckForItemTypeInTable(string typeTextBox)
        {
            bool typeChecked = true;
            int typeToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_typu FROM ListaTypow WHERE Nazwa_typu = '" + typeTextBox + "';";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            typeToSearch = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (typeToSearch == 0)
            {
                if (MessageBox.Show("Given type was not found in types list. Do you want to add this type?", "Type not found", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    typeChecked = false;
                    QuickItemTypeAdding Window = new QuickItemTypeAdding();
                    Window.Show();
                }
            }
            return typeChecked;
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Window = new MainWindow();
            Window.Show();
            Close();
        }
        private bool CheckAttribute(string attribute, string attributeName)
        {
            bool attributeChecked = true;
            if (int.Parse(attribute) < 1 || int.Parse(attribute) > 99)
            {
                MessageBox.Show("Number given in: " + '"' + attributeName + '"' + " is wrong! Attribute must be between 1 and 99", "Wrong number!");
                attributeChecked = false;
            }
            return attributeChecked;
        }
        private bool CheckSkill(string skill, string skillName)
        {
            bool skillChecked = true;
            if (int.Parse(skill) < 1)
            {
                MessageBox.Show("Number given in: " + '"' + skillName + '"' + " is wrong! Skill must be bigger than 0", "Wrong number!");
                skillChecked = false;
            }
            return skillChecked;
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
        private bool CheckSex()
        {
            bool nameSexChecked = true;
            EnterSex.Text.ToUpper();
            if (EnterSex.Text == "M" || EnterSex.Text == "F")
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
        private void CreateCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            bool itemNameCheck = CheckSpelling(EnterItemName.Text, "Personal thing name");
            bool checkSex = CheckSex();
            bool placeOfResidenceSpelling = CheckSpelling(EnterPlaceOfResidence.Text, "Place of residence");
            bool countryOfBirthSpelling = CheckSpelling(EnterCountryOfBirth.Text, "Country of birth");
            bool nameChecked = CheckForNameInTable(EnterName.Text);
            bool surnameChecked = CheckForSurnameInTable(EnterSurname.Text);
            bool sChecked = CheckAttribute(EnterS.Text, "Strength");
            bool conChecked = CheckAttribute(EnterCon.Text, "Constitution");
            bool dexChecked = CheckAttribute(EnterDex.Text, "Dexterity");
            bool sizChecked = CheckAttribute(EnterSiz.Text, "Size");
            bool powChecked = CheckAttribute(EnterPow.Text, "Power");
            bool appChecked = CheckAttribute(EnterApp.Text, "Appearance");
            bool eduChecked = CheckAttribute(EnterEdu.Text, "Education");
            bool intChecked = CheckAttribute(EnterInt.Text, "Inteligence");
            bool sanityChecked = CheckAttribute(EnterSanity.Text, "Sanity");
            bool luckChecked = CheckAttribute(EnterLuck.Text, "Luck");
            bool historyCheck = CheckSkill(EnterHistory.Text, "History");
            bool brawlCheck = CheckSkill(EnterBrawl.Text, "History");
            bool PerceptivityCheck = CheckSkill(EnterPerceptivity.Text, "History");
            bool firstAidCheck = CheckSkill(EnterFirstAid.Text, "History");
            bool firearmCheck = CheckSkill(EnterFirearm.Text, "History");
            bool typeChecked = CheckForItemTypeInTable(EnterType.Text);
            if ((itemNameCheck == true) && (checkSex == true) && (countryOfBirthSpelling == true) && (placeOfResidenceSpelling == true) && (nameChecked == true) && (surnameChecked == true) && (sChecked == true) && (conChecked == true) && (dexChecked == true) && (sizChecked == true) && (powChecked == true) && (appChecked == true) && (eduChecked == true) && (intChecked == true) && (sanityChecked == true) && (luckChecked == true) && (typeChecked == true) && (historyCheck == true) && (brawlCheck == true) && (PerceptivityCheck == true) && (firstAidCheck == true) && (firearmCheck == true))
            {
                int idToInput = RandomId();
                string itemNameToInput = UpdateWord(EnterItemName.Text);
                string placeOfResidenceToInput = UpdateWord(EnterPlaceOfResidence.Text);
                string countryOfBirthToInput = UpdateWord(EnterCountryOfBirth.Text);
            }
        }
        private void InsertIntoNamesTable(int id, string name, string surname, string profession, string age, string sex, string placeOfResidence, string countryOfBirth)
        {
            Projekt_CthulhuDataSetTableAdapters.ImionaTableAdapter imionaTableAdapter = new Projekt_CthulhuDataSetTableAdapters.ImionaTableAdapter();
            imionaTableAdapter.Insert(id.ToString(), name, origin, nameSex);
            MessageBox.Show("Name " + '"' + name + '"' + " with id: " + '"' + id + '"' + " has been added", "Name added");
            Close();
        }
    }
}
