using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class inventoryManagerForm : Form
    {
        DataTable inventory = new DataTable();
        public inventoryManagerForm()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            priceTextBox.Text = "";
            typeComboBox.SelectedIndex = -1;
           quantityTextBox.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            String description = descriptionTextBox.Text;
            String price = priceTextBox.Text;
            String type = (string)typeComboBox.SelectedItem;
            String quantity = quantityTextBox.Text;

            inventory.Rows.Add(name, description, price, type, quantity);

            newBtn_Click(sender, e);

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error);
            }
        }


        private void inventoryManagerForm_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Type");
            inventory.Columns.Add("Quantity");

            inventoryGridView.DataSource = inventory;
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nameTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                descriptionTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                quantityTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();

                String itemToLookFor = nameTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                typeComboBox.SelectedIndex = typeComboBox.Items.IndexOf(itemToLookFor);

            }
            catch ( Exception error ) 
            {
                Console.WriteLine("Error: " + error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
