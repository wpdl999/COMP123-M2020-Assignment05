using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.startForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void ProductsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.selectProducts.productID = (short)(this.ProductsdataGridView.SelectedRows[0].Cells[0].Value);
            Program.selectProducts.cost = (decimal)(this.ProductsdataGridView.SelectedRows[0].Cells[1].Value);
            Program.selectProducts.manufacturer = this.ProductsdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Program.selectProducts.model = this.ProductsdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Program.selectProducts.RAM_type = ProductsdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Program.selectProducts.RAM_size = ProductsdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Program.selectProducts.displaytype = ProductsdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            Program.selectProducts.screensize = ProductsdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Program.selectProducts.resolution = ProductsdataGridView.SelectedRows[0].Cells[8].Value.ToString();
            Program.selectProducts.CPU_Class = ProductsdataGridView.SelectedRows[0].Cells[9].Value.ToString();
            Program.selectProducts.CPU_brand = ProductsdataGridView.SelectedRows[0].Cells[10].Value.ToString();
            Program.selectProducts.CPU_type = ProductsdataGridView.SelectedRows[0].Cells[11].Value.ToString();
            Program.selectProducts.CPU_speed = ProductsdataGridView.SelectedRows[0].Cells[12].Value.ToString();
            Program.selectProducts.CPU_number = ProductsdataGridView.SelectedRows[0].Cells[13].Value.ToString();
            Program.selectProducts.condition = ProductsdataGridView.SelectedRows[0].Cells[14].Value.ToString();
            Program.selectProducts.OS = ProductsdataGridView.SelectedRows[0].Cells[15].Value.ToString();
            Program.selectProducts.platform = ProductsdataGridView.SelectedRows[0].Cells[16].Value.ToString();
            Program.selectProducts.HDD_size = ProductsdataGridView.SelectedRows[0].Cells[17].Value.ToString();
            Program.selectProducts.HDD_speed = ProductsdataGridView.SelectedRows[0].Cells[18].Value.ToString();
            Program.selectProducts.GPU_Type = ProductsdataGridView.SelectedRows[0].Cells[19].Value.ToString();
            Program.selectProducts.optical_drive = ProductsdataGridView.SelectedRows[0].Cells[20].Value.ToString();
            Program.selectProducts.Audio_type = ProductsdataGridView.SelectedRows[0].Cells[21].Value.ToString();
            Program.selectProducts.LAN = ProductsdataGridView.SelectedRows[0].Cells[22].Value.ToString();
            Program.selectProducts.WIFI = ProductsdataGridView.SelectedRows[0].Cells[23].Value.ToString();
            Program.selectProducts.width = ProductsdataGridView.SelectedRows[0].Cells[24].Value.ToString();
            Program.selectProducts.height = ProductsdataGridView.SelectedRows[0].Cells[25].Value.ToString();
            Program.selectProducts.depth = ProductsdataGridView.SelectedRows[0].Cells[26].Value.ToString();
            Program.selectProducts.weight = ProductsdataGridView.SelectedRows[0].Cells[27].Value.ToString();
            Program.selectProducts.moust_type = ProductsdataGridView.SelectedRows[0].Cells[28].Value.ToString();
            Program.selectProducts.power = ProductsdataGridView.SelectedRows[0].Cells[29].Value.ToString();
            Program.selectProducts.webcam = ProductsdataGridView.SelectedRows[0].Cells[30].Value.ToString();



            SelectionTextBox.Text = $"{Program.selectProducts.manufacturer} {Program.selectProducts.model} Priced at: ${Program.selectProducts.cost}";
        }
    }
}
