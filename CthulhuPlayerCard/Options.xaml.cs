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
using System.Windows.Navigation;
using System.IO;
using System.Data.SqlClient;

namespace CthulhuPlayerCard
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        bool _DBConnectionSet;
        bool DBConnectionSet
        {
            get => _DBConnectionSet = CheckForDBConnection();
        }
        public Options()
        {
            InitializeComponent();
            VersionBox.Text = "1.0v";
            if (DBConnectionSet == false)
            {
                AddName.IsEnabled = false;
                AddSurname.IsEnabled = false;
                AddProfession.IsEnabled = false;
                AddPersonalItemType.IsEnabled = false;
            }
            else
            {
                AddName.IsEnabled = true;
                AddSurname.IsEnabled = true;
                AddProfession.IsEnabled = true;
                AddPersonalItemType.IsEnabled = true;
            }
        }

        private void AddNameButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewNameWindow NewName = new AddNewNameWindow();
            NewName.Show();
            Close();
        }

        private void AddSurnameButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewSurnameWindow NewSurname = new AddNewSurnameWindow();
            NewSurname.Show();
            Close();
        }

        private void AddPersonalItemTypeButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewPersonalThingType NewItem = new AddNewPersonalThingType();
            NewItem.Show();
            Close();
        }

        private void AddProfesionButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewProfessionWindow NewProfession = new AddNewProfessionWindow();
            NewProfession.Show();
            Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Back = new MainWindow();
            Back.Show();
            Close();
        }
        private bool CheckForDBConnection()
        {
            SqlConnection conn = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            bool result = true;

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (SqlException)
            {
                result = false;
            }
            return result;
        }
        private void CreateDB()
        {
            bool successfullConnection = true;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Trusted_Connection=Yes;");
            string script = File.ReadAllText(@"\InteractiveCallOfCthulhu\InteractiveCallOfCthulhu\CthulhuPlayerCard\CreateOnlyDB.sql");
            SqlCommand createDatabaseCommand = new SqlCommand(script, sqlConnection);
            try
            {
                sqlConnection.Open();
                createDatabaseCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is created successfully", "Database created!");
            }
            catch (System.Exception ex)
            {
                successfullConnection = false;
                MessageBox.Show(ex.ToString(), "Database creation");
            }
            finally
            {
                if (successfullConnection == true)
                {
                    sqlConnection.Close();
                }
            }
        }
        private void InsertIntoTables()
        {
            bool successfullConnection = true;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            string script = File.ReadAllText(@"\InteractiveCallOfCthulhu\InteractiveCallOfCthulhu\CthulhuPlayerCard\InsertIntoTables.sql");
            SqlCommand createDatabaseCommand = new SqlCommand(script, sqlConnection);
            try
            {
                sqlConnection.Open();
                createDatabaseCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted into tables", "Data inserted");
            }
            finally
            {
                if (successfullConnection == true)
                {
                    sqlConnection.Close();
                }
            }
        }
        private void CreateViews()
        {
            bool viewsCreated = true;
            string scriptCzyIstniejePostac;
            string scriptListaPostaci;
            string scriptListaPrzedmiotow;
            string scriptListaTypow;
            string scriptListaZawodow;

            scriptCzyIstniejePostac = File.ReadAllText(@"\InteractiveCallOfCthulhu\InteractiveCallOfCthulhu\CthulhuPlayerCard\ViewCzyIstniejePostac.sql");
            scriptListaPostaci = File.ReadAllText(@"\InteractiveCallOfCthulhu\InteractiveCallOfCthulhu\CthulhuPlayerCard\ViewListaPostaci.sql");
            scriptListaPrzedmiotow = File.ReadAllText(@"\InteractiveCallOfCthulhu\InteractiveCallOfCthulhu\CthulhuPlayerCard\ViewListaPrzedmiotow.sql");
            scriptListaTypow = File.ReadAllText(@"\InteractiveCallOfCthulhu\InteractiveCallOfCthulhu\CthulhuPlayerCard\ViewListaTypow.sql");
            scriptListaZawodow = File.ReadAllText(@"\InteractiveCallOfCthulhu\InteractiveCallOfCthulhu\CthulhuPlayerCard\ViewListaZawodow.sql");

            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            SqlCommand createViewCzyIstniejePostac = new SqlCommand(scriptCzyIstniejePostac, sqlConnection);
            SqlCommand createViewListaPostaci = new SqlCommand(scriptListaPostaci, sqlConnection);
            SqlCommand createViewListaPrzedmiotow = new SqlCommand(scriptListaPrzedmiotow, sqlConnection);
            SqlCommand createViewListaTypow = new SqlCommand(scriptListaTypow, sqlConnection);
            SqlCommand createViewListaZawodow = new SqlCommand(scriptListaZawodow, sqlConnection);
            try
            {
                createViewCzyIstniejePostac.ExecuteNonQuery();
                createViewListaPostaci.ExecuteNonQuery();
                createViewListaPrzedmiotow.ExecuteNonQuery();
                createViewListaTypow.ExecuteNonQuery();
                createViewListaZawodow.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                viewsCreated = false;
                MessageBox.Show(ex.ToString(), "View creation");
            }
            finally
            {
                if (viewsCreated == true)
                {
                    sqlConnection.Close();
                }
            }
        }
        private void CreateTables()
        {
            bool successfullConnection = true;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            string script = File.ReadAllText(@"\InteractiveCallOfCthulhu\InteractiveCallOfCthulhu\CthulhuPlayerCard\DatabaseCreation.sql");
            SqlCommand createDatabaseCommand = new SqlCommand(script, sqlConnection);
            try
            {
                sqlConnection.Open();
                createDatabaseCommand.ExecuteNonQuery();
                MessageBox.Show("Tables are created successfully", "Tables created!");
            }
            catch (System.Exception ex)
            {
                successfullConnection = false;
                MessageBox.Show(ex.ToString(), "Tables creation");
            }
            finally
            {
                if (successfullConnection == true)
                {
                    sqlConnection.Close();
                }
            }
        }
        private void CreateDBConnectButton_Click(object sender, RoutedEventArgs e)
        {
            if (DBConnectionSet == false)
            {
                CreateDB();
                CreateTables();
                InsertIntoTables();
                CreateViews();
                MessageBox.Show("Database was created", "Database creation");
            }
            else
            {
                MessageBox.Show("Your database has already been created", "Database creation");
            }
        }
    }
}
