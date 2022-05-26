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
    /// Interaction logic for AddNewProfessionWindow.xaml
    /// </summary>
    public partial class AddNewProfessionWindow : Window
    {
        public AddNewProfessionWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CthulhuPlayerCard.Projekt_CthulhuDataSet projekt_CthulhuDataSet = ((CthulhuPlayerCard.Projekt_CthulhuDataSet)(this.FindResource("projekt_CthulhuDataSet")));
            // Load data into the table Zawody. You can modify this code as needed.
            CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ZawodyTableAdapter projekt_CthulhuDataSetZawodyTableAdapter = new CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ZawodyTableAdapter();
            projekt_CthulhuDataSetZawodyTableAdapter.Fill(projekt_CthulhuDataSet.Zawody);
            System.Windows.Data.CollectionViewSource zawodyViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("zawodyViewSource")));
            zawodyViewSource.View.MoveCurrentToFirst();
        }
    }
}
