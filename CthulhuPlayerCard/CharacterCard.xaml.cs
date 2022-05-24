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
            ChoosenID = LoadCharacterWindow._LoadedCharacterID.ToString();
            CharacterIdDisplay.Text = "Character ID: " + ChoosenID;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
