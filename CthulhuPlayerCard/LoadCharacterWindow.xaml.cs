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

namespace CthulhuPlayerCard
{
    /// <summary>
    /// Interaction logic for LoadCharacterWindow.xaml
    /// </summary>
    public partial class LoadCharacterWindow : Window
    {
        int LoadedCharacterID;
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
        private void GettingCharacterId(string TextboxString)
        {
            bool success = int.TryParse(TextboxString, out LoadedCharacterID);
            if (!success)
            {
                string caption = "Wrong ID!";
                string message = "Ensure that ID is an integer!";
                MessageBoxResult result = MessageBox.Show(message, caption);
                CharacterIdInput.Clear();
            }
        }
     
        private void LoadCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            GettingCharacterId(CharacterIdInput.Text);
        }

        private void DeleteCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            GettingCharacterId(CharacterIdInput.Text);
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Window = new MainWindow();
            Window.Show();
            Close();
        }
    }
}
