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
            string sql = "Select Id_postaci FROM Spis_postaci WHERE Id_postaci = " + rollResult + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult == 1)
            {
                RandomId();
            }
            return rollResult;
        }
        private int RandomItemId()
        {
            Random roll = new Random();
            int rollResult = roll.Next(1, 9999);

            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_przedmiotu FROM Rzeczy_osobiste WHERE Id_przedmiotu = " + rollResult + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            int searchResult = Convert.ToInt32(sqlCommand.ExecuteScalar());
            if (searchResult == 1)
            {
                RandomItemId();
            }
            return rollResult;
        }
        private int professionIdReturn(string profession)
        {
            int foundId;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_zawodu FROM Zawody WHERE Nazwa_zawodu = " + "'" + profession + "';";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            foundId = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return foundId;
        }
        private bool CheckForNameInTable(string nameTextBox)
        {
            bool nameChecked = true;
            if (nameTextBox != null & nameTextBox != " " & nameTextBox != string.Empty)
            {
                int nameToSearch;
                SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
                sqlConnection.Open();
                string sql = "Select Id_imienia FROM Imiona WHERE Imie = " + "'" + nameTextBox + "';";
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sql;
                nameToSearch = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (nameToSearch == 0)
                {
                    if (MessageBox.Show("Given name was not found in names list. Do you want to add this name?" + nameToSearch, "Name not found", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        nameChecked = false;
                        QuickNameAdding Window = new QuickNameAdding();
                        Window.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Name cannot be empty!", "Wrong name!");
                nameChecked = false;
            }
            return nameChecked;
        }
        private bool CheckForSurnameInTable(string surnameTextBox)
        {
            bool surnameChecked = true;
            if (surnameTextBox != null & surnameTextBox != " " & surnameTextBox != string.Empty)
            {
                int surnameToSearch;
                SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
                sqlConnection.Open();
                string sql = "Select Id_nazwiska FROM Nazwiska WHERE Nazwisko = '" + surnameTextBox + "';";
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sql;
                surnameToSearch = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (surnameToSearch == 0)
                {
                    if (MessageBox.Show("Given surname was not found in surnames list. Do you want to add this surname?" + surnameToSearch, "Surname not found", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        surnameChecked = false;
                        QuickSurnameAdding Window = new QuickSurnameAdding();
                        Window.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Surname cannot be empty!", "Wrong surname!");
                surnameChecked = false;
            }
            return surnameChecked;
        }
        private bool CheckForItemTypeInTable(string typeTextBox)
        {
            bool typeChecked = true;
            if (typeTextBox != null & typeTextBox != " " & typeTextBox != string.Empty)
            {
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
            }
            else
            {
                MessageBox.Show("Type cannot be empty!", "Wrong type!");
                typeChecked = false;
            }
            return typeChecked;
        }
        private string CheckForItemIdInTable(string typeName)
        {
            string typeIdToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_typu FROM ListaTypow WHERE Nazwa_typu = '" + typeName + "';";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            typeIdToSearch = sqlCommand.ExecuteScalar().ToString();
            return typeIdToSearch;
        }
        private string CheckForNameIdInTable(string name)
        {
            string nameIdToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_imienia FROM Imiona WHERE Imie = '" + name + "';";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            nameIdToSearch = sqlCommand.ExecuteScalar().ToString();
            return nameIdToSearch;
        }
        private string CheckForSurnameIdInTable(string surname)
        {
            string surnameIdToSearch;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "Select Id_nazwiska FROM Nazwiska WHERE Nazwisko = '" + surname + "';";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            surnameIdToSearch = sqlCommand.ExecuteScalar().ToString();
            return surnameIdToSearch;
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
            if (attribute == "" || attribute == " ")
            {
                MessageBox.Show('"' + attributeName + '"' + " must be a number and cannot be empty!", "Attribute error");
                attributeChecked = false;
            }
            else if (int.Parse(attribute) < 1 || int.Parse(attribute) > 99)
            {
                MessageBox.Show("Number given in: " + '"' + attributeName + '"' + " is wrong! Attribute must be between 1 and 99", "Wrong number!");
                attributeChecked = false;
            }
            return attributeChecked;
        }
        private bool CheckSkill(string skill, string skillName)
        {
            bool skillChecked = true;
            if (skill == "" || skill == " ")
            {
                MessageBox.Show('"' + skillName + '"' + " must be a number and cannot be empty!", "Skill error");
                skillChecked = false;
            }
            else if (int.Parse(skill) < 1)
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
            bool characterSexChecked = true;
            EnterSex.Text.ToUpper();
            if (EnterSex.Text == "M" || EnterSex.Text == "F")
            {
                characterSexChecked = true;
            }
            else
            {
                MessageBox.Show("Enter " + '"' + 'M' + '"' + " for male character and " + '"' + 'F' + '"' + " for female character.", "Wrong character sex");
                characterSexChecked = false;
            }
            return characterSexChecked;
        }
        private void CreateCharacterButton_Click(object sender, RoutedEventArgs e)
        {
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
            bool brawlCheck = CheckSkill(EnterBrawl.Text, "Brawl");
            bool PerceptivityCheck = CheckSkill(EnterPerceptivity.Text, "Perceptivity");
            bool firstAidCheck = CheckSkill(EnterFirstAid.Text, "FirstAid");
            bool firearmCheck = CheckSkill(EnterFirearm.Text, "Firearm");
            bool typeChecked = CheckForItemTypeInTable(EnterType.Text);
            if ((checkSex == true) && (countryOfBirthSpelling == true) && (placeOfResidenceSpelling == true) && (nameChecked == true) && (surnameChecked == true) && (sChecked == true) && (conChecked == true) && (dexChecked == true) && (sizChecked == true) && (powChecked == true) && (appChecked == true) && (eduChecked == true) && (intChecked == true) && (sanityChecked == true) && (luckChecked == true) && (typeChecked == true) && (historyCheck == true) && (brawlCheck == true) && (PerceptivityCheck == true) && (firstAidCheck == true) && (firearmCheck == true))
            {
                int professionIdToInput = professionIdReturn(EnterProfession.Text);
                int idToInput = RandomId();
                int itemIdToInput = RandomItemId();
                string itemNameToInput = EnterItemName.Text;
                string placeOfResidenceToInput = UpdateWord(EnterPlaceOfResidence.Text);
                string countryOfBirthToInput = UpdateWord(EnterCountryOfBirth.Text);
                int nameIdToInput = int.Parse(CheckForNameIdInTable(EnterName.Text));
                int surnameIdToInput = int.Parse(CheckForSurnameIdInTable(EnterSurname.Text));
                InsertIntoItemTable(itemIdToInput, EnterType.Text, itemNameToInput);
                InsertIntoCharactersTable(idToInput, nameIdToInput.ToString(), surnameIdToInput.ToString(), professionIdToInput.ToString(), short.Parse(EnterAge.Text), EnterSex.Text, placeOfResidenceToInput, countryOfBirthToInput, short.Parse(EnterS.Text), short.Parse(EnterDex.Text), short.Parse(EnterCon.Text), short.Parse(EnterApp.Text), short.Parse(EnterEdu.Text), short.Parse(EnterSiz.Text), short.Parse(EnterInt.Text), byte.Parse(EnterLuck.Text), short.Parse(EnterPow.Text), itemIdToInput.ToString(), byte.Parse(EnterHistory.Text), byte.Parse(EnterBrawl.Text), byte.Parse(EnterPerceptivity.Text), byte.Parse(EnterFirstAid.Text), byte.Parse(EnterFirearm.Text));
                LoadCharacterWindow Window = new LoadCharacterWindow();
                Window.Show();
                Close();
            }
        }
        private void InsertIntoItemTable(int itemId, string typeName, string itemName) 
        {
            string typeId = CheckForItemIdInTable(typeName);
            Projekt_CthulhuDataSetTableAdapters.Rzeczy_osobisteTableAdapter RzeczyTableAdapter = new Projekt_CthulhuDataSetTableAdapters.Rzeczy_osobisteTableAdapter();
            RzeczyTableAdapter.Insert(itemId.ToString(), typeId, itemName);
        }
        private void InsertIntoCharactersTable(int id, string name, string surname, string profession, short age, string sex, string placeOfResidence, string countryOfBirth, short s, short dex, short con, short app, short edu, short siz, short Int, byte luck, short pow, string itemID, byte history, byte brawl, byte perceptivity, byte firstAid, byte firearm)
        {
            Projekt_CthulhuDataSetTableAdapters.Spis_postaciTableAdapter imionaTableAdapter = new Projekt_CthulhuDataSetTableAdapters.Spis_postaciTableAdapter();
            imionaTableAdapter.Insert(id.ToString(), name, surname, age, profession, sex, placeOfResidence, countryOfBirth, s, dex, con, app, edu, siz, Int , luck, pow, itemID, history, brawl, perceptivity, firstAid, firearm);
            MessageBox.Show("Character with id: " + '"' + id + '"' + " has been added", "Character added");

        }
    }
}
