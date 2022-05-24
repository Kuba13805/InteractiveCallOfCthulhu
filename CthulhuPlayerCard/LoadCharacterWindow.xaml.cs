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
    /// Interaction logic for LoadCharacterWindow.xaml
    /// </summary>
    public partial class LoadCharacterWindow : Window
    {
        public static int _LoadedCharacterID;
        private int LoadedCharacterID
        {
            get => _LoadedCharacterID;
        }
        bool success;
        public LoadCharacterWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CthulhuPlayerCard.Projekt_CthulhuDataSet projekt_CthulhuDataSet = ((CthulhuPlayerCard.Projekt_CthulhuDataSet)(this.FindResource("projekt_CthulhuDataSet")));
            // Load data into the table ListaPostaci. You can modify this code as needed.
            CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ListaPostaciTableAdapter projekt_CthulhuDataSetListaPostaciTableAdapter = new CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ListaPostaciTableAdapter();
            projekt_CthulhuDataSetListaPostaciTableAdapter.Fill(projekt_CthulhuDataSet.ListaPostaci);
            System.Windows.Data.CollectionViewSource listaPostaciViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("listaPostaciViewSource")));
            listaPostaciViewSource.View.MoveCurrentToFirst();
        }

        private void listaPostaciDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private int LastRowID()
        {
            int rowCount;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT COUNT(*) FROM ListaPostaci";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            rowCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
            return rowCount;
        }
        private void GettingCharacterId(string TextboxString)
        {
            success = int.TryParse(TextboxString, out _LoadedCharacterID);
            if (!success)
            {
                string caption = "Wrong ID!";
                string message = "Ensure that ID is an integer!";
                MessageBoxResult result = MessageBox.Show(message, caption);
                CharacterIdInput.Clear();
            }
            int rowCount = LastRowID();
            if ((_LoadedCharacterID > rowCount) ^ (_LoadedCharacterID < 0))
            {
                MessageBox.Show("Character with this ID does not exist!", "Character not found!");
                success = false;
                CharacterIdInput.Clear();
            }
        }
     
        private void LoadCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            GettingCharacterId(CharacterIdInput.Text);
            if (success)
            {
                CharacterCard LoadedCharacter = new CharacterCard();
                LoadedCharacter.Show();
                Close();
            }
        }

        private void DeleteCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            GettingCharacterId(CharacterIdInput.Text);
            if (success)
            {
                DeleteCharacterData(LoadedCharacterID);
            }
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Window = new MainWindow();
            Window.Show();
            Close();
        }
        private void DeleteCharacterData(object sender)
        {
            if (MessageBox.Show("Are you sure you want to delete this character?", "Delete character", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                
            }
        }
    }
}
