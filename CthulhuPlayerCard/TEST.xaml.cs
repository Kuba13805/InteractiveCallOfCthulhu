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
    /// Interaction logic for TEST.xaml
    /// </summary>
    public partial class TEST : Window
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CthulhuPlayerCard.Projekt_CthulhuDataSet projekt_CthulhuDataSet = ((CthulhuPlayerCard.Projekt_CthulhuDataSet)(this.FindResource("projekt_CthulhuDataSet")));
            // Load data into the table Typy_przedmiotow. You can modify this code as needed.
            CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.Typy_przedmiotowTableAdapter projekt_CthulhuDataSetTypy_przedmiotowTableAdapter = new CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.Typy_przedmiotowTableAdapter();
            projekt_CthulhuDataSetTypy_przedmiotowTableAdapter.Fill(projekt_CthulhuDataSet.Typy_przedmiotow);
            System.Windows.Data.CollectionViewSource typy_przedmiotowViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("typy_przedmiotowViewSource")));
            typy_przedmiotowViewSource.View.MoveCurrentToFirst();
        }
    }
}
