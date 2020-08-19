using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Author's name : Wooram Moon
    Author's student Number : 301098673
    Date last Modified : 
    Program description
    1st Revision : Aug 10th
    2nd Revision : Aug 12th
    3rd Revision : Aug 13th
    4th Revision : Aug 15th
    5th Revision : Aug 18th
 */

namespace COMP123_M2020_Assignment05
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionTextBox.Text = Program.selectProducts.condition;
            PlatFormTextBox.Text = Program.selectProducts.platform;
            ManufacTextBox.Text = Program.selectProducts.manufacturer;
            ModelTextBox.Text = Program.selectProducts.model;
            ScreenTextBox.Text = Program.selectProducts.screensize;
            MemoryTextBox.Text = Program.selectProducts.RAM_size;
            CPUBTextBox.Text = Program.selectProducts.CPU_brand;
            CPUNumTextBox.Text = Program.selectProducts.CPU_number;
            GPUTTextBox.Text = Program.selectProducts.GPU_Type;
            CPUTTextBox.Text = Program.selectProducts.CPU_type;
            CPUspeedTextBox.Text = Program.selectProducts.CPU_speed;
            WebCamTextBox.Text = Program.selectProducts.webcam;
            OSTextBox.Text = Program.selectProducts.OS;
            HDDTextBox.Text = Program.selectProducts.HDD_size;
            PriceTextBox.Text = Program.selectProducts.cost.ToString();
            double price = Convert.ToDouble(PriceTextBox.Text);
            double sales_tax = price * 0.13;
            SalesTextBox.Text = sales_tax.ToString();
            double total = price + sales_tax;
            TotalTextBox.Text = total.ToString();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBoxForm.ShowDialog();
        }
    }
}
