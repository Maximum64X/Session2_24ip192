using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPack
{
    public partial class AddMaterialForm : Form
    {
        private string CalculateCost(string minimalAmountString,  string priceString) 
        {
            if(minimalAmountString == "" || priceString == "") 
            {
                return "0";
            }

            float minimalAmount = float.Parse(minimalAmountString);
            float price = float.Parse(priceString);
            float cost = minimalAmount * price;
            return cost.ToString();
        }

        public AddMaterialForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMaterialForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suppliers_24ip192DataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.suppliers_24ip192DataSet.Supplier);

        }

        private void MinimalAmountTextBox_TextChanged(object sender, EventArgs e)
        {

            CostTextBox.Text = CalculateCost(MinimalAmountTextBox.Text, PriceTextBox.Text);
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CostTextBox.Text = CalculateCost(MinimalAmountTextBox.Text, PriceTextBox.Text);
        }

        private void MinimalAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 это код клавиши Backspace
            {
                e.Handled = true; // Запрещаем обработку нажатия клавиши
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 это код клавиши Backspace
            {
                e.Handled = true; // Запрещаем обработку нажатия клавиши
            }
        }
    }
}
