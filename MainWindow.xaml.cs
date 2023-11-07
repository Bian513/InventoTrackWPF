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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.ComponentModel;
using System.Drawing;

namespace InventoTrack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable inventory = new DataTable();  
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
            DataGridViewCell.Items.Add(nameTextBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save all the values from our fields into variables
          
            String name = nameTextBox.Text;
            String price = priceTextBox.Text;
            String quantity = quantityTextBox.Text;
          
            String category = (string)categoryComboBox.SelectedItem;

            // Add these values to the datatable
            inventory.Rows.Add(name, category, price, quantity);

            // Clear fields after save
            newButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void part_TextBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
