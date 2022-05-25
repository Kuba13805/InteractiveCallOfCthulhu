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

namespace CthulhuPlayerCard
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
            VersionBox.Text = "1.0v";
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
    }
}
