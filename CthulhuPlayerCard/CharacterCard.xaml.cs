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

namespace CthulhuPlayerCard
{
    /// <summary>
    /// Interaction logic for CharacterCard.xaml
    /// </summary>
    public partial class CharacterCard : Window
    {
        string ChoosenID;
        public CharacterCard()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayFullData();
        }
        private void GetCharacterID()
        {
            ChoosenID = LoadCharacterWindow._LoadedCharacterID.ToString();
            CharacterIdDisplay.Text = "Character ID: " + ChoosenID;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private string GetNameFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Imie FROM ListaPostaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string nameFromTable = sqlCommand.ExecuteScalar().ToString();
            return nameFromTable;
        }
        private string GetSurnameFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Nazwisko FROM ListaPostaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string surnameFromTable = sqlCommand.ExecuteScalar().ToString();
            return surnameFromTable;
        }
        private void DisplayFullData()
        {
            GetCharacterID();
            NameFromData.Text = GetNameFromTable();
            SurnameFromData.Text = GetSurnameFromTable();
            ProfessionFromData.Text = GetProfessionFromTable();
            AgeFromData.Text = GetAgeFromTable();
            SexFromData.Text = GetSexFromTable();
            PlaceOfResidenceFromData.Text = GetPlaceOfResidenceFromTable();
            CountryOfBirthFromData.Text = GetCountryOfBirthFromTable();
            SFromData.Text = GetStrenghtFromTable();
            ConFromData.Text = GetConstitutionFromTable();




        }
        private string GetProfessionFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Nazwa_zawodu FROM ListaPostaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string professionFromTable = sqlCommand.ExecuteScalar().ToString();
            return professionFromTable;
        }
        private string GetAgeFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Wiek FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string ageFromTable = sqlCommand.ExecuteScalar().ToString();
            return ageFromTable;
        }
        private string GetSexFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Plec FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string sexFromTable = sqlCommand.ExecuteScalar().ToString();
            return sexFromTable;
        }
        private string GetPlaceOfResidenceFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Miejsce_zamieszkania FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string placeOfResidenceFromTable = sqlCommand.ExecuteScalar().ToString();
            return placeOfResidenceFromTable;
        }
        private string GetCountryOfBirthFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Pochodzenie FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string countryOfBirthFromTable = sqlCommand.ExecuteScalar().ToString();
            return countryOfBirthFromTable;
        }
        private string GetStrenghtFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Sila FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string strengthFromTable = sqlCommand.ExecuteScalar().ToString();
            return strengthFromTable;
        }
        private string GetConstitutionFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Budowa_ciala FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string constitutionFromTable = sqlCommand.ExecuteScalar().ToString();
            return constitutionFromTable;
        }
        private void TestAttributeOrSkill(int chance)
        {
            
            Random roll = new Random();
            int rollResult = roll.Next(0, 100);
            if ((rollResult <= chance) && (rollResult > 5))
            {
                MessageBox.Show("Succes! Roll result: " + rollResult + ".", "Succes!");
            }
            else if ((rollResult > chance) && (rollResult < 95))
            {
                MessageBox.Show("Failure! Roll result: " + rollResult + ".", "Failure!");

            }
            else if ((rollResult > chance) && (rollResult <= 5))
            {
                MessageBox.Show("Critical succes! Roll result: " + rollResult + ".", "Critical succes!");
            }
            else if ((rollResult <= chance) && (rollResult >= 95))
            {
                MessageBox.Show("Critical failure! Roll result: " + rollResult + ".", "Critical failure!");
            }

        }
        private void RollStrengthButton_Click(object sender, RoutedEventArgs e)
        {
            TestAttributeOrSkill(int.Parse(GetStrenghtFromTable()));
        }

        private void RollConstitutionButton_Click(object sender, RoutedEventArgs e)
        {
            TestAttributeOrSkill(int.Parse(GetConstitutionFromTable()));
        }

        private void RollDexterityButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
