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
            DexFromData.Text = GetDexterityFromTable();
            SizeFromData.Text = GetSizeFromTable();
            PowFromData.Text = GetPowerFromTable();
            AppFromData.Text = GetPowerFromTable();
            EduFromData.Text = GetEducationFromTable();
            IntFromData.Text = GetIntelligenceFromTable();
            LuckFromData.Text = GetLuckFromTable();
            MoveBox.Text = GetMove();
            SanityBox.Text = GetSanity(int.Parse(GetPowerFromTable()));
            HitPointsBox.Text = GetHitPoints(int.Parse(GetConstitutionFromTable()), int.Parse(GetSizeFromTable()));
            MagicPointsBox.Text = GetMagicPoints(float.Parse(GetPowerFromTable()));
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
            string sql = "SELECT Kondycja FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string constitutionFromTable = sqlCommand.ExecuteScalar().ToString();
            return constitutionFromTable;
        }
        private string GetDexterityFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Zrecznosc FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string dexterityFromTable = sqlCommand.ExecuteScalar().ToString();
            return dexterityFromTable;
        }
        private string GetSizeFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Budowa_ciala FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string dexterityFromTable = sqlCommand.ExecuteScalar().ToString();
            return dexterityFromTable;
        }
        private string GetPowerFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Moc FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string dexterityFromTable = sqlCommand.ExecuteScalar().ToString();
            return dexterityFromTable;
        }
        private string GetAppearanceFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Wyglad FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string dexterityFromTable = sqlCommand.ExecuteScalar().ToString();
            return dexterityFromTable;
        }
        private string GetEducationFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Wyksztalcenie FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string educationFromTable = sqlCommand.ExecuteScalar().ToString();
            return educationFromTable;
        }
        private string GetIntelligenceFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Inteligencja FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string educationFromTable = sqlCommand.ExecuteScalar().ToString();
            return educationFromTable;
        }
        private string GetLuckFromTable()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT Szczescie FROM Spis_postaci WHERE Id_postaci = " + ChoosenID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            string luckFromTable = sqlCommand.ExecuteScalar().ToString();
            return luckFromTable;
        }
        private string GetSanity(int power)
        {
            string sanity = power.ToString();
            return sanity;
        }
        private string GetHitPoints(int constitution, int size)
        {
            string hitPoints = ((constitution + size)/10).ToString();
            return hitPoints;
        }
        private string GetMagicPoints(double power)
        {
            double magicPoints;
            int result = 0;
            magicPoints = power / 5;
            result = Convert.ToInt32(Math.Floor(magicPoints));
            return result.ToString();
        }
        private string GetMove()
        {
            string move = CalculateMove(int.Parse(GetStrenghtFromTable()), int.Parse(GetDexterityFromTable()), int.Parse(GetSizeFromTable()), int.Parse(GetAgeFromTable())).ToString();
            return move;
        }
        private int CalculateMove(int strength, int dexterity, int size, int age)
        {
            int move = 0;
            if ((strength < size) && (dexterity < size))
            {
                move = 7;
            }
            else if ((strength >= size) || (dexterity >= size) || ((strength == size) && (dexterity == size)))
            {
                move = 8;
            }
            else if ((strength > size) && (dexterity > size))
            {
                move = 9;
            }
            int disadvantageFromAge = 0;
            if ((age >= 40) && (age <=49))
            {
                disadvantageFromAge = - 1;
            }
            else if ((age >= 50) && (age <= 59))
            {
                disadvantageFromAge = -2;
            }
            else if ((age >= 60) && (age <= 69))
            {
                disadvantageFromAge = -3;
            }
            else if ((age >= 70) && (age <= 79))
            {
                disadvantageFromAge = -4;
            }
            else if ((age >= 80) && (age <= 90))
            {
                disadvantageFromAge = -5;
            }
            return move + disadvantageFromAge;
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
            TestAttributeOrSkill(int.Parse(GetDexterityFromTable()));
        }
        private void RollSizeButton_Click(object sender, RoutedEventArgs e)
        {
            TestAttributeOrSkill(int.Parse(GetSizeFromTable()));
        }
        private void RollPowerButton_Click(object sender, RoutedEventArgs e)
        {
            TestAttributeOrSkill(int.Parse(GetPowerFromTable()));
        }
        private void RollAppearanceButton_Click(object sender, RoutedEventArgs e)
        {
            TestAttributeOrSkill(int.Parse(GetAppearanceFromTable()));
        }
        private void RollEducationButton_Click(object sender, RoutedEventArgs e)
        {
            TestAttributeOrSkill(int.Parse(GetEducationFromTable()));
        }
        private void RollInteligenceButton_Click(object sender, RoutedEventArgs e)
        {
            TestAttributeOrSkill(int.Parse(GetIntelligenceFromTable()));
        }
        private void RollSanityButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void RollLuckButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
