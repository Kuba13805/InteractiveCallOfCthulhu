﻿using System;
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
    /// Interaction logic for AddNewNameWindow.xaml
    /// </summary>
    public partial class AddNewNameWindow : Window
    {
        string ChoosenId;
        public AddNewNameWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CthulhuPlayerCard.Projekt_CthulhuDataSet projekt_CthulhuDataSet = ((CthulhuPlayerCard.Projekt_CthulhuDataSet)(this.FindResource("projekt_CthulhuDataSet")));
            // Load data into the table Imiona. You can modify this code as needed.
            CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ImionaTableAdapter projekt_CthulhuDataSetImionaTableAdapter = new CthulhuPlayerCard.Projekt_CthulhuDataSetTableAdapters.ImionaTableAdapter();
            projekt_CthulhuDataSetImionaTableAdapter.Fill(projekt_CthulhuDataSet.Imiona);
            System.Windows.Data.CollectionViewSource imionaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("imionaViewSource")));
            imionaViewSource.View.MoveCurrentToFirst();
            
        }
        private void CheckName(string givenName)
        {
            int SearchedId;
            SqlConnection sqlConnection = new SqlConnection(@"Server=(LocalDb)\MSSQLLocalDB;Database=Projekt_Cthulhu;Trusted_Connection=Yes;");
            sqlConnection.Open();
            string sql = "SELECT COUNT(*) FROM ListaPostaci where Id_postaci = " + LoadedCharacterID.ToString() + ";";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sql;
            SearchedId = Convert.ToInt32(sqlCommand.ExecuteScalar());
        }
        private void AddNameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearTexboxButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteNameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
